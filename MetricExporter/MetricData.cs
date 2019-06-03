using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MetricExporter
{
    public class MetricData
    {
        [JsonProperty("metric-data")]
        public List<MetricValue> Metrics { get; set; }

    }
}
