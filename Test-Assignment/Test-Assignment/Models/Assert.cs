using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Test_Assignment.Models
{
    internal class Assert : INotifyPropertyChanged
    {
        private string id;
        private string rank;
        private string symbol;
        private string name;
        private string supply;
        private string maxSupply;
        private string marketCapUsd;
        private string volumeUsd24Hr;
        private string priceUsd;
        private string changePercent24Hr;
        private string vwap24Hr;
        public string Id { get { return id; } set { id = value; OnPropertyChanged("Id"); } }
        public string Rank { get { return rank; } set { rank = value; OnPropertyChanged("Rank"); } }
        public string Symbol { get { return symbol; } set { symbol = value; OnPropertyChanged("Symbol"); } }
        public string Name { get { return name; } set { name = value; OnPropertyChanged("Name"); } }
        public string Supply { get { return supply; } set { supply = value; OnPropertyChanged("Supply"); } }
        public string MaxSupply { get { return maxSupply; } set { maxSupply = value; OnPropertyChanged("MaxSupply"); } }
        public string MarketCapUsd { get { return marketCapUsd; } set { marketCapUsd = value; OnPropertyChanged("MarketCapUsd"); } }
        public string VolumeUsd24Hr { get { return volumeUsd24Hr; } set { volumeUsd24Hr = value; OnPropertyChanged("VolumeUsd24Hr"); } }
        public string PriceUsd { get { return priceUsd; } set { priceUsd = value; OnPropertyChanged("PriceUsd"); } }
        public string ChangePercent24Hr { get { return changePercent24Hr; } set { changePercent24Hr = value; OnPropertyChanged("ChangePercent24Hr"); } }
        public string Vwap24Hr { get { return vwap24Hr; } set { vwap24Hr = value; OnPropertyChanged("Vwap24Hr"); } }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
