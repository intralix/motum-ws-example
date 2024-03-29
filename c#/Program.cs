using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LGPS_Ws_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            // Url Base del servicio
            var base_url = "http://signals.intralix.com";  
            // Endpoint del servicio deseado
            var uri = "/api/v1/utrax/last_positions";
            // Reemplazar API_TOKEN con el valor proporcionado
            var api_token = "API_TOKEN";

            // HTTP POST Configuration
            var client = new System.Net.Http.HttpClient();
            client.BaseAddress = new Uri(base_url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", api_token);                
            
            // Body Configuration
            // Reemplzar CLIENT_ID por el valor proporcionado
            var data = "{\"client_id\":\"CLIENT_ID\"}"; // Ws Parameters (depends on documentation)
            var contentRes = new StringContent(data.ToString(), Encoding.UTF8, "application/json");
            
            // Request data
            var response = client.PostAsync(uri, contentRes).Result;

            string res = "";
            using (HttpContent content = response.Content)
            {
                // ... Read the string.
                Task<string> result = content.ReadAsStringAsync();
                res = result.Result;
                Console.WriteLine(res);
                Console.ReadLine();
            }
        }
    }
}
