﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetricExporter
{
    class MetricDatas
    {
        [JsonProperty("metric-datas")]
        public List<MetricData> MetricDataList {get;set;}
    }
}
3eabe71fbc9493b2b21825ad04b7519d5a05aa14