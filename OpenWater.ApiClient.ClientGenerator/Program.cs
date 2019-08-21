using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using NJsonSchema.CodeGeneration.CSharp;
using NSwag;
using NSwag.CodeGeneration.CSharp;
using NSwag.CodeGeneration.OperationNameGenerators;

namespace OpenWater.ApiClient.ClientGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string apiClientClassName = "OpenWaterApiClient";
            const string apiExceptionClassName = "OpenWaterApiException";
            const string generatedClientFilePostfix = "Generated";
            const string apiClientNamespace = "OpenWater.ApiClient";
            var outputPath = GetApiClientProjectDirectoryPath();

            var apiDocument = OpenApiDocument.FromUrlAsync("https://api.secure-platform.com/swagger/v2/swagger.json").Result;

            GenerateClient(apiDocument, outputPath, apiClientClassName, generatedClientFilePostfix, CSharpClientGeneratorSettingsCreator, out var typeNameHintsModelWithNamespaceInfos);

            GenerateModels(apiDocument, Path.Combine(outputPath, "Models"), apiClientNamespace, CSharpClientGeneratorSettingsCreator, typeNameHintsModelWithNamespaceInfos);

            Console.Write("Press any key to exit...");
            Console.ReadKey(true);

            CSharpClientGeneratorSettings CSharpClientGeneratorSettingsCreator()
            {
                return new CSharpClientGeneratorSettings
                {
                    CSharpGeneratorSettings =
                    {
                        Namespace = apiClientNamespace,
                        ClassStyle = CSharpClassStyle.Record,
                        GenerateDataAnnotations = false
                    },
                    OperationNameGenerator = new SingleClientFromOperationIdOperationNameGenerator(),
                    ClientClassAccessModifier = "public sealed",
                    ExcludedParameterNames = new[] { "X-ClientKey", "X-OrganizationCode", "X-ApiKey", "X-SuppressEmails" },
                    GenerateOptionalParameters = true,
                    ExceptionClass = apiExceptionClassName
                };
            }
        }

        private static void GenerateClient(OpenApiDocument apiDocument, string outputDirectory, string apiClientClassName, string generatedClientFilePostfix, Func<CSharpClientGeneratorSettings> cSharpClientGeneratorSettingsCreator, out IReadOnlyDictionary<string, ModelNameWithNamespaceInfo> typeNameHintsModelWithNamespaceInfos)
        {
            Console.Write("Generating Api Client...");

            var modelWithNamespaceTypeNameGenerator = new ModelWithNamespaceTypeNameGenerator();

            var settings = cSharpClientGeneratorSettingsCreator();
            settings.ClassName = apiClientClassName;
            settings.GenerateDtoTypes = false;
            settings.GenerateClientClasses = true;
            settings.CSharpGeneratorSettings.TypeNameGenerator = modelWithNamespaceTypeNameGenerator;
            settings.HttpClientType = "OpenWater.ApiClient.OpenWaterHttpClient";

            var generator = new CSharpClientGenerator(apiDocument, settings);
            var generatedClientFile = generator.GenerateFile();

            // there are no options to make constructor protected using generator settings
            generatedClientFile = generatedClientFile.Replace($"public {apiClientClassName}(", $"private {apiClientClassName}(");

            // sealed class doesn't contain virtual and protected methods
            generatedClientFile = generatedClientFile.Replace(" virtual ", " ");
            generatedClientFile = generatedClientFile.Replace("protected ", "private ");

            var path = Path.Combine(outputDirectory, $"{settings.ClassName}.{generatedClientFilePostfix}.cs");
            File.WriteAllText(path, generatedClientFile);

            typeNameHintsModelWithNamespaceInfos = modelWithNamespaceTypeNameGenerator.TypeNameHintsModelNameWithNamespaceInfos;

            Console.WriteLine("Done");
        }

        private static void GenerateModels(OpenApiDocument apiDocument, string outputDirectory, string rootNamespace, Func<CSharpClientGeneratorSettings> cSharpClientGeneratorSettingsCreator, IReadOnlyDictionary<string, ModelNameWithNamespaceInfo> typeNameHintsModelWithNamespaceInfos)
        {
            Console.WriteLine("Generating Api Models");

            var modelNamespaces = typeNameHintsModelWithNamespaceInfos.Values.ToArray().Select(i => i.ModelNamespace).Distinct();

            foreach (var modelNamespace in modelNamespaces)
            {
                GenerateModelsForNamespace(apiDocument, outputDirectory, rootNamespace, modelNamespace, ModelInNamespaceSettingsCreator, typeNameHintsModelWithNamespaceInfos);
            }

            CSharpClientGeneratorSettings ModelInNamespaceSettingsCreator()
            {
                var settings = cSharpClientGeneratorSettingsCreator();

                settings.GenerateDtoTypes = true;
                settings.GenerateClientClasses = false;

                return settings;
            }
        }

        private static void GenerateModelsForNamespace(OpenApiDocument apiDocument, string outputDirectory, string rootNamespace, string currentNamespace, Func<CSharpClientGeneratorSettings> cSharpClientGeneratorSettingsCreator, IReadOnlyDictionary<string, ModelNameWithNamespaceInfo> typeNameHintsModelWithNamespaceInfos)
        {
            Console.Write($"{currentNamespace}... ");

            var modelWithNamespaceTypeNameGenerator = new NamespaceRelatedModelTypeNameGenerator(typeNameHintsModelWithNamespaceInfos, currentNamespace);

            var settings = cSharpClientGeneratorSettingsCreator();
            settings.CSharpGeneratorSettings.Namespace = $"{rootNamespace}.{currentNamespace}";
            settings.CSharpGeneratorSettings.ExcludedTypeNames = typeNameHintsModelWithNamespaceInfos.Values.Where(i => i.ModelNamespace != currentNamespace).Select(i => i.FullName).ToArray();
            settings.CSharpGeneratorSettings.TypeNameGenerator = modelWithNamespaceTypeNameGenerator;

            var generator = new CSharpClientGenerator(apiDocument, settings);

            var generatedModelsFile = generator.GenerateFile();
           
            var path = Path.Combine(outputDirectory, $"{currentNamespace}.cs");
            File.WriteAllText(path, generatedModelsFile);

            Console.WriteLine("Done");
        }

        private static string GetApiClientProjectDirectoryPath()
        {
            var executingAssembly = Assembly.GetExecutingAssembly();
            var projectRootDirectoryName = executingAssembly.EntryPoint.DeclaringType.Namespace;
            var executingAssemblyPath = executingAssembly.Location;

            var solutionRootDirectoryPath = executingAssemblyPath.Substring(0, executingAssemblyPath.IndexOf($@"{Path.DirectorySeparatorChar}{projectRootDirectoryName}{Path.DirectorySeparatorChar}"));
            var apiClientProjectPath = Path.Combine(solutionRootDirectoryPath, "OpenWater.ApiClient");

            if (!Directory.Exists(apiClientProjectPath))
                throw new DirectoryNotFoundException("Failed to resolve api client project directory.");

            return apiClientProjectPath;
        }
    }
}