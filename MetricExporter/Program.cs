using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MetricExporter
{
    class Program

    
    {
        //static IConfiguration config;
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();
            var calls = new RestCalls();

            var appResult = calls.getMetrics("controller/rest/applications").Result;
            var applications = JsonConvert.DeserializeObject<ICollection<Application>>(appResult);
            
            //var result = @"{ ""metricId"" : 20455618,""metri
            var result = calls.getMetrics("controller/rest/applications/913/metric-data?metric-path=Business%20Transaction%20Performance%7CBusiness%20Transactions%7C*%7C%2Fajax%2Fdaily%7C*&time-range-type=BEFORE_NOW&duration-in-mins=10080").Result;
            //if (result.StartsWith('[') && result.EndsWith(']'))
            //    result = result.Substring(1, result.Length - 2);
            var x = JsonConvert.DeserializeObject<ICollection<MetricData>>(result);

            //var name = x.GetMetricBTName();

            Console.WriteLine("Hello World!");
        }
    }
}
