using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using Test_Assignment.Models;

namespace Test_Assignment.ViewModels
{
    internal class CoinViewModel
    {
        public Assert coin { get; set; }
        public List<Market> markets { get; set; }
        public CoinViewModel(string name)
        {
            HttpClient httpClient = new HttpClient();
            var get = httpClient.GetStringAsync("https://api.coincap.io/v2/assets");
            var repositories = JsonConvert.DeserializeObject<Data>(get.Result);
            coin = repositories.data.First(x => x.Name == name);
            get = httpClient.GetStringAsync($"https://api.coincap.io/v2/assets/{coin.Id}/markets");
            var repos = JsonConvert.DeserializeObject<DataMarkets>(get.Result);
            markets = repos.data.Distinct().ToList();
        }
    }
}
