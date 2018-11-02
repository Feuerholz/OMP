using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OMP
{
    public static class APIAccessor
    {
        public static string ApiKey { get; set; }
        
        public static async Task<JArray> RetrieveMatchDataAsync(string matchid)
        {
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri("https://osu.ppy.sh/")
            };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string matchAsJSON;
            HttpResponseMessage response = await client.GetAsync(string.Format("api/get_match?k={0}&mp={1}", ApiKey, matchid)).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            matchAsJSON = await response.Content.ReadAsStringAsync();
            JToken matchJSONToken = JToken.Parse(matchAsJSON);
            JArray matchJSON = matchJSONToken["games"].Value<JArray>();
            return matchJSON;
        }

        public static async Task<JArray> RetrieveMapDataAsync(string mapid)
        {
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri("http://osu.ppy.sh/")
            };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string mapAsJSON;
            HttpResponseMessage response = await client.GetAsync(string.Format("api/get_beatmaps?k={0}&b={1}", ApiKey, mapid)).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            mapAsJSON = await response.Content.ReadAsStringAsync();
            JArray mapJSON = JArray.Parse(mapAsJSON);

            return mapJSON;
        }
    }
}
