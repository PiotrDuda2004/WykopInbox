using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WykopInbox.Pages
{

    public class CreateRequest
    {
        public async Task Main()
        {

            JObject data = JObject.Parse(File.ReadAllText("secrets.json"));
            
            HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://wykop.pl/api/v3/entries");

            
            request.Headers.Add("accept", "application/json");
            request.Headers.Add("Authorization",  data["secret"].ToString() );

            HttpResponseMessage response = await client.SendAsync(request);
            //response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(responseBody);

            foreach(var el in myDeserializedClass.data)
            {
                Console.WriteLine(el.content);
            }
        }

    }
}
