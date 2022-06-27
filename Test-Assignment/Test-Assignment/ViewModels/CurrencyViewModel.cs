using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using Test_Assignment.Models;

namespace Test_Assignment.ViewModels
{
    internal class CurrencyViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Assert selectedAssert;
        public List<Assert> asserts { get; set; }
        public Assert SelectedAssert
        {
            get { return selectedAssert; }
            set
            {
                selectedAssert = value;
                OnPropertyChanged("SelectedAssert");
            }
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public CurrencyViewModel()
        {
            HttpClient httpClient = new HttpClient();
            var get = httpClient.GetStringAsync("https://api.coincap.io/v2/assets");
            var repositories = JsonConvert.DeserializeObject<Data>(get.Result);
            asserts = repositories.data.Take(10).ToList();
        }
        public CurrencyViewModel(string name)
        {
            HttpClient httpClient = new HttpClient();
            var get = httpClient.GetStringAsync("https://api.coincap.io/v2/assets");
            var repositories = JsonConvert.DeserializeObject<Data>(get.Result);
            asserts = repositories.data.Where(x => string.Equals(x.Name, name, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }
    }
}
