using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MetricExporter
{
    class Program


    {
        static void Main(string[] args)
        {
            //var result = @"{ ""metricId"" : 20455618,""metricName"" : ""BTM|BTs|BT:605274|Component:19539|Average Response Time (ms)"",""metricPath"" : ""Business Transaction Performance|Business Transactions|SM-RemoteObjectServer|Device - Work Lookup|Average Response Time (ms)"",""frequency"" : ""SIXTY_MIN"",""metricValues"" : [ { ""startTimeInMillis"" : 1557000060000, ""occurrences"" : 711, ""current"" : 13, ""min"" : 0, ""max"" : 41796,""useRange"" : true, ""count"" : 51551936, ""sum"" : 314112437, ""value"" : 6, ""standardDeviation"" : 0 } ]}";
            var calls = new RestCalls();
            var result = calls.getMetrics("a").Result;
            //if (result.StartsWith('[') && result.EndsWith(']'))
            //    result = result.Substring(1, result.Length - 2);
            var x = JsonConvert.DeserializeObject<ICollection<MetricData>>(result);

            //var name = x.GetMetricBTName();

            Console.WriteLine("Hello World!");
        }
    }
}
