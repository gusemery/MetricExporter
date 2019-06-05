using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MetricExporter
{
    [JsonArrayAttribute("metric-data")]
    public class MetricData
    {
        
        public IList<MetricValue> Metrics { get; set; }

    }
}
