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
            
            //var result = @"{ ""metricId"" : 20455618,""metricName"" : ""BTM|BTs|BT:605274|Component:19539|Average Response Time (ms)"",""metricPath"" : ""Business Transaction Performance|Business Transactions|SM-RemoteObjectServer|Device - Work Lookup|Average Response Time (ms)"",""frequency"" : ""SIXTY_MIN"",""metricValues"" : [ { ""startTimeInMillis"" : 1557000060000, ""occurrences"" : 711, ""current"" : 13, ""min"" : 0, ""max"" : 41796,""useRange"" : true, ""count"" : 51551936, ""sum"" : 314112437, ""value"" : 6, ""standardDeviation"" : 0 } ]}";
            var calls = new RestCalls();
            var result = calls.getMetrics("controller/rest/applications/913/metric-data?metric-path=Business%20Transaction%20Performance%7CBusiness%20Transactions%7C*%7C%2Fajax%2Fdaily%7C*&time-range-type=BEFORE_NOW&duration-in-mins=10080").Result;
            //if (result.StartsWith('[') && result.EndsWith(']'))
            //    result = result.Substring(1, result.Length - 2);
            var x = JsonConvert.DeserializeObject<ICollection<MetricData>>(result);

            //var name = x.GetMetricBTName();

            Console.WriteLine("Hello World!");
        }
    }
}
