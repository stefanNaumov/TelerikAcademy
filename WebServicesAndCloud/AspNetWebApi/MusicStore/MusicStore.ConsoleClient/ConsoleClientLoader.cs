using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using MusicStore.Models;
using MusicStore.Services.Models;

namespace MusicStore.ConsoleClient
{
    public class ConsoleClientLoader
    {
        static void Main(string[] args)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:50950/")
            };
            
            client.DefaultRequestHeaders.Accept.Add(new
                MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response =
                client.GetAsync("api/Song/All").Result;
            
            if (response.IsSuccessStatusCode)
            {
                //TODO:parse with Json.Net
                var products = response.Content.ReadAsStringAsync().Result;

                Console.WriteLine(products);
            }
            else
                Console.WriteLine("{0} ({1})",
                    (int)response.StatusCode, response.ReasonPhrase);

        }
    }
}
