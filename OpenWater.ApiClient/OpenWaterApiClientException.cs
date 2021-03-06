﻿using System;
using System.Collections.Generic;

namespace OpenWater.ApiClient
{
    public class OpenWaterApiException : Exception
    {
        public int StatusCode { get; }

        public string Response { get; }

        public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; }

        public OpenWaterApiException(string message, int statusCode, string response, IReadOnlyDictionary<string, IEnumerable<string>> headers, Exception innerException)
            : base($"{message}\n\nStatus: {statusCode}\nResponse: \n{response.Substring(0, response.Length >= 512 ? 512 : response.Length)}", innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return $"HTTP Response: \n\n{Response}\n\n{base.ToString()}";
        }
    }

    public class OpenWaterApiException<TResult> : OpenWaterApiException
    {
        public TResult Result { get; }

        public OpenWaterApiException(string message, int statusCode, string response, IReadOnlyDictionary<string, IEnumerable<string>> headers, TResult result, Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }
}