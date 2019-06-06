using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MetricExporter
{
    

    public class MetricValue
    {

        [JsonProperty("startTimeInMillis")]
        public long startTimeInMillis { get; set; }

        [JsonProperty("occurrences")]
        public int occurrences { get; set; }

        [JsonProperty("current")]
        public int current { get; set; }

        [JsonProperty("min")]
        public int min { get; set; }

        [JsonProperty("max")]
        public int max { get; set; }

        [JsonProperty("useRange")]
        public bool useRange { get; set; }

        [JsonProperty("count")]
        public int count { get; set; }

        [JsonProperty("sum")]
        public int sum { get; set; }

        [JsonProperty("value")]
        public int value { get; set; }

        [JsonProperty("standardDeviation")]
        public int standardDeviation { get; set; }
    }
    
    [JsonObject]
    public class MetricData
    {

        [JsonProperty(PropertyName = "metricId")]
        public int metricId { get; set; }

        [JsonProperty(PropertyName = "metricName")]
        public string metricName { get; set; }

        [JsonProperty(PropertyName = "metricPath")]
        public string metricPath { get; set; }

        [JsonProperty(PropertyName = "frequency")]
        public string frequency { get; set; }

        [JsonProperty(PropertyName = "metricValues")]
        public ICollection<MetricValue> metricValues { get; set; }
    }

    [JsonObject]
    public class MetricDatas : ICollection<MetricData>
    {
        public int Count => metricDatas.Count;

        public bool IsReadOnly => metricDatas.IsReadOnly;

        ICollection<MetricData> metricDatas { get; set; }

        public void Add(MetricData item)
        {
            metricDatas.Add(item);
        }

        public void Clear()
        {
            metricDatas.Clear();
        }

        public bool Contains(MetricData item)
        {
            return metricDatas.Contains(item);
        }

        public void CopyTo(MetricData[] array, int arrayIndex)
        {
            metricDatas.CopyTo(array, arrayIndex);
        }

        public IEnumerator<MetricData> GetEnumerator()
        {
            return metricDatas.GetEnumerator();
        }

        public bool Remove(MetricData item)
        {
            return metricDatas.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return metricDatas.GetEnumerator();
        }
    }
}
