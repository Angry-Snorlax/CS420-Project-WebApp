using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Net;
using Newtonsoft.Json;
using CS420_Project_WebApp;

namespace CS420_Project_WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            using (WebClient client = new WebClient())
            {
                string thina = client.DownloadString("https://www.alphavantage.co/query?function=CURRENCY_EXCHANGE_RATE&from_currency=BTC&to_currency=USD&apikey=EVUWUA3ID1W5BEQF");
                JsonParse items = JsonConvert.DeserializeObject<JsonParse>(thina);
                items.Display();
            }
        }
        /*public static string testing()
        {
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString("https://www.alphavantage.co/query?function=CURRENCY_EXCHANGE_RATE&from_currency=BTC&to_currency=USD&apikey=EVUWUA3ID1W5BEQF");
                return parseTest(json);
            }
        }
        public static string parseTest(string testing)
        {
            string josn = JsonConvert.DeserializeObject<string>(testing);
            List<string> jon;
            foreach (var item in josn.)
            {
                jon.Add(item. )
            }
        }*/

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
        public static string Parse()
        {
            using (WebClient client = new WebClient())
            {
                string thina = client.DownloadString("https://www.alphavantage.co/query?function=CURRENCY_EXCHANGE_RATE&from_currency=BTC&to_currency=USD&apikey=EVUWUA3ID1W5BEQF");
                JsonParse items = JsonConvert.DeserializeObject<JsonParse>(thina);
                return items.Display();
            }
        }
    }
}
