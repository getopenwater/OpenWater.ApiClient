using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;
using NSwag;
using NSwag.CodeGeneration.CSharp;
using NSwag.CodeGeneration.OperationNameGenerators;

namespace OpenWater.ApiClient.ClientGenerator
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            const string apiClientClassName = "OpenWaterApiClient";
            const string apiExceptionClassName = "OpenWaterApiException";
            const string generatedClientFilePostfix = "Generated";
            const string apiClientNamespace = "OpenWater.ApiClient";
            var outputPath = GetApiClientProjectDirectoryPath();
            var generatedModelsPath = Path.Combine(outputPath, "Models", "Generated");

#if DEBUG
            var apiDocument = await OpenApiDocument.FromUrlAsync("http://localhost:11100/swagger/v2/swagger.json");
#else
            var apiDocument = await OpenApiDocument.FromUrlAsync("https://api.secure-platform.com/swagger/v2/swagger.json");
#endif

            apiDocument.SchemaType = SchemaType.OpenApi3;

            GenerateClient(apiDocument, outputPath, apiClientClassName, generatedClientFilePostfix, CSharpClientGeneratorSettingsCreator, out var typeNameHintsModelWithNamespaceInfos);

            GenerateModels(apiDocument, generatedModelsPath, apiClientNamespace, CSharpClientGeneratorSettingsCreator, typeNameHintsModelWithNamespaceInfos);

            GenerateDefinitions(apiDocument, generatedModelsPath, apiClientNamespace, CSharpClientGeneratorSettingsCreator, typeNameHintsModelWithNamespaceInfos);

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
                        GenerateDataAnnotations = false,
                        TemplateDirectory = "Templates",
                        RequiredPropertiesMustBeDefined = true
                    },
                    ParameterNameGenerator = new ParameterNameGenerator(),
                    AdditionalNamespaceUsages = new[] { "OpenWater.ApiClient.Definitions" },
                    OperationNameGenerator = new SingleClientFromOperationIdOperationNameGenerator(),
                    ClientClassAccessModifier = "public sealed",
                    ExcludedParameterNames = new[] { "X-ClientKey", "X-ApiKey" },
                    GenerateOptionalParameters = true,
                    ExceptionClass = apiExceptionClassName,
                    GenerateSyncMethods = true,
                    GenerateExceptionClasses = false,
                    ParameterDateTimeFormat = "u"
                };
            }
        }

        private static void GenerateClient(OpenApiDocument apiDocument, string outputDirectory, string apiClientClassName, string generatedClientFilePostfix, Func<CSharpClientGeneratorSettings> cSharpClientGeneratorSettingsCreator, out IReadOnlyDictionary<string, ModelNameWithNamespaceInfo> typeNameHintsModelWithNamespaceInfos)
        {
            Console.Write(InsertSpaces("Generating Api Client..."));

            var modelWithNamespaceTypeNameGenerator = new ModelWithNamespaceTypeNameGenerator();

            var settings = cSharpClientGeneratorSettingsCreator();
            settings.ClassName = apiClientClassName;
            settings.GenerateDtoTypes = false;
            settings.GenerateClientClasses = true;
            settings.GenerateOptionalParameters = true;

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

            var modelNamespaces = typeNameHintsModelWithNamespaceInfos.Values.Select(i => i.ModelNamespace).Distinct().OrderBy(n => n).ToArray();

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
            const string definitions = "Definitions";

            if (string.IsNullOrEmpty(currentNamespace))
                currentNamespace = definitions;

            Console.Write(InsertSpaces($"{currentNamespace}... "));

            var excludedTypeModelList = typeNameHintsModelWithNamespaceInfos.Values.Where(i => i.ModelNamespace != currentNamespace).Select(i => i.FullName).ToList();

            if (currentNamespace != definitions)
                excludedTypeModelList.AddRange(apiDocument.Definitions.Select(x => x.Key).ToArray());

            var modelWithNamespaceTypeNameGenerator = new NamespaceRelatedModelTypeNameGenerator(typeNameHintsModelWithNamespaceInfos, currentNamespace);

            var settings = cSharpClientGeneratorSettingsCreator();
            settings.CSharpGeneratorSettings.Namespace = $"{rootNamespace}.{currentNamespace}";
            settings.CSharpGeneratorSettings.ExcludedTypeNames = excludedTypeModelList.ToArray();
            settings.CSharpGeneratorSettings.TypeNameGenerator = modelWithNamespaceTypeNameGenerator;

            var generator = new CustomCSharpClientGenerator(apiDocument, settings) { IsDefinitionGeneration = currentNamespace == definitions };

            var generatedModelsFile = generator.GenerateFile();

            var path = Path.Combine(outputDirectory, $"{currentNamespace}.cs");
            File.WriteAllText(path, generatedModelsFile);

            Console.WriteLine("Done");
        }

        private static string GetApiClientProjectDirectoryPath()
        {
            var executingAssembly = Assembly.GetExecutingAssembly();
            var projectRootDirectoryName = executingAssembly.EntryPoint.DeclaringType?.Namespace;
            var executingAssemblyPath = executingAssembly.Location;

            var solutionRootDirectoryPath = executingAssemblyPath.Substring(0, executingAssemblyPath.IndexOf($@"{Path.DirectorySeparatorChar}{projectRootDirectoryName}{Path.DirectorySeparatorChar}", StringComparison.Ordinal));
            var apiClientProjectPath = Path.Combine(solutionRootDirectoryPath, "OpenWater.ApiClient");

            if (!Directory.Exists(apiClientProjectPath))
                throw new DirectoryNotFoundException("Failed to resolve api client project directory.");

            return apiClientProjectPath;
        }

        private static void GenerateDefinitions(OpenApiDocument apiDocument, string outputDirectory, string rootNamespace, Func<CSharpClientGeneratorSettings> cSharpClientGeneratorSettingsCreator, IReadOnlyDictionary<string, ModelNameWithNamespaceInfo> typeNameHintsModelWithNamespaceInfos)
        {
            var excluded = typeNameHintsModelWithNamespaceInfos.Values.Select(m => m.FullName).ToList();
            excluded.AddRange(apiDocument.Paths.Select(p => p.Key));

            var settings = cSharpClientGeneratorSettingsCreator();
            settings.CSharpGeneratorSettings.Namespace = $"{rootNamespace}.Definitions";
            settings.CSharpGeneratorSettings.ExcludedTypeNames = excluded.ToArray();

            Console.WriteLine("Done");

            Console.WriteLine("Generating Api Definitions");
            GenerateModelsForNamespace(apiDocument, outputDirectory, rootNamespace, "", ModelInNamespaceSettingsCreator, typeNameHintsModelWithNamespaceInfos);

            CSharpClientGeneratorSettings ModelInNamespaceSettingsCreator()
            {
                var cSharpClientGeneratorSettings = cSharpClientGeneratorSettingsCreator();

                cSharpClientGeneratorSettings.GenerateDtoTypes = true;
                cSharpClientGeneratorSettings.GenerateClientClasses = false;

                return cSharpClientGeneratorSettings;
            }
        }

        private static string InsertSpaces(string text)
        {
            const int spaceCount = 30;

            var y = spaceCount - text.Length;

            var sb = new StringBuilder(text);

            for (var i = 0; i < y; i++)
            {
                sb.Append(" ");
            }

            return sb.ToString();
        }
    }
}