using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;


namespace WykopInbox.Pages
{

    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        public List<Datum> Values { get; set; }
        public async Task OnGetAsync()
        {
            JObject data = JObject.Parse(System.IO.File.ReadAllText("secrets.json"));

            HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://wykop.pl/api/v3/entries");


            request.Headers.Add("accept", "application/json");
            request.Headers.Add("Authorization", data["secret"].ToString());


            HttpResponseMessage response = await client.SendAsync(request);
             
            //response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(request.Headers.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(request.ToString());
            if (responseBody!= null)
            {
                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(responseBody);
                this.Values = myDeserializedClass.data;
                Console.WriteLine(responseBody);

                foreach (var el in myDeserializedClass.data)
                {
                    Console.WriteLine(el.content);
                }
            }


        }
    }
}
