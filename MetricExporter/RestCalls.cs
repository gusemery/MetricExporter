using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MetricExporter
{
    public class RestCalls
    {
        HttpClient client = new HttpClient();
        public RestCalls()
        {
                    }

        public async Task<string> getMetrics(string metricData)
        {
            MetricData product =new MetricData();
            
            client.BaseAddress = new Uri("https://honeywell-sps.saas.appdynamics.com/controller/rest/");
            var path = "applications/BigLots-Prod/metric-data?metric-path=Business%20Transaction%20Performance%7CBusiness%20Transactions%7CSM-RemoteObjectServer%7CDevice%20-%20Work%20Lookup%7CAverage%20Response%20Time%20%28ms%29&time-range-type=BEFORE_NOW&duration-in-mins=43200&output=json";
            //HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, path);

            var byteArray = Encoding.ASCII.GetBytes("gus@honeywell-sps:appdynamics");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            HttpResponseMessage response =  client.GetAsync(path).Result;

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync(); //response.Content.ReadAsAsync<Product>();
                return content;
            }

            return string.Empty;
        }
    }
}
