using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetricExporter
{
    //<metricId>20455618</metricId>
    //<metricName>BTM|BTs|BT:605274|Component:19539|Average Response Time(ms)</metricName>
    //<metricPath>Business Transaction Performance|Business Transactions|SM-RemoteObjectServer|Device - Work Lookup|Average Response Time(ms)</metricPath>
    //<frequency>SIXTY_MIN</frequency>
    
    public class MetricValue
    {
        #region Properties
        [JsonProperty("metricId")]
        public long MetricId { get; set; }
        [JsonProperty("metricName")]
        public string MetricName { get; set; }
        [JsonProperty("metricPath")]
        public string MetricPath { get; set; }
        [JsonProperty("frequency")]
        public string Frequency { get; set; }
        [JsonProperty("metricValues")]
        public List<Metrics> MetricValues {get;set;}

        #endregion

        #region HelperMethods
        public string[] GetMetricPathItems()
        {
            return returnSplitStrings(MetricPath, '|');
        }
        public string[] getMetricNameStrings()
        {
            return returnSplitStrings(MetricName, '|');
        }
        public string GetMetricBTName()
        {
            return GetMetricPathItems()[3];
        }
        public string GetMetricBTType()
        {
            return GetMetricPathItems()[4];
        }
        private string[] returnSplitStrings(string Content, char Delim)
        {
            return Content.Split(Delim);
        }
        #endregion

    }
}
