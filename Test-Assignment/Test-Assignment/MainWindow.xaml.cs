﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using Test_Assignment.Models;
using Test_Assignment.ViewModels;

namespace Test_Assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            /*HttpClient httpClient = new HttpClient();
            var get = httpClient.GetStringAsync("https://api.coincap.io/v2/assets");
            var repositories = JsonConvert.DeserializeObject<Data>(get.Result);*/
            InitializeComponent();
            DataContext = new CurrencyViewModel();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Coin coin = new Coin(nameTextBox.Text);
            coin.Show();
            await Task.Delay(100);
            this.Close();
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(searchTextBox.Text);
            main.Show();
            await Task.Delay(100);
            this.Close();
        }
        public MainWindow(string name)
        {
            /*HttpClient httpClient = new HttpClient();
            var get = httpClient.GetStringAsync("https://api.coincap.io/v2/assets");
            var repositories = JsonConvert.DeserializeObject<Data>(get.Result);*/
            InitializeComponent();
            DataContext = new CurrencyViewModel(name);
        }
    }
}
