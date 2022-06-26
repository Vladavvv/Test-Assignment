using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Test_Assignment.ViewModels;

namespace Test_Assignment
{
    /// <summary>
    /// Логика взаимодействия для Coin.xaml
    /// </summary>
    public partial class Coin : Window
    {
        public Coin(string name)
        {
            InitializeComponent();
            DataContext = new CoinViewModel(name);
        }
        public Coin()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            await Task.Delay(100);
            this.Close();
        }
    }
}
