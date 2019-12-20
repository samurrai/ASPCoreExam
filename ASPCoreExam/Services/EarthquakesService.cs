using ASPCoreExam.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ASPCoreExam.Services
{
    public class EarthquakesService
    {
        private readonly string url = "https://earthquake.usgs.gov/fdsnws/event/1/application.json";
        public async Task<List<EarthquakeInfo>> GetEarthquakes(int amount)
        {
            using (WebClient client = new WebClient())
            {
                string json = await client.DownloadStringTaskAsync(new Uri(url));
                Root root = JsonConvert.DeserializeObject<Root>(json);
                root.Features.Earthquakes.RemoveRange(amount + 1, root.Features.Earthquakes.Count);
                return root.Features.Earthquakes;
            }
        }
    }
}
