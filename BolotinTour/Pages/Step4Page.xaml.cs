using System;
using System.Collections.Generic;
using System.Linq;
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

namespace BolotinTour.Pages
{
    /// <summary>
    /// Логика взаимодействия для Step4Page.xaml
    /// </summary>
    public partial class Step4Page : Page
    {
        public Step4Page()
        {
            InitializeComponent();
            if (AppData.minPrice == -1 && AppData.maxPrice == -1)
                DGridPoisk.ItemsSource = AppData.Context.ContractClient.ToList();
            else
                DGridPoisk.ItemsSource = AppData.Context.ContractClient.ToList().Where(p => p.ContractPrice >= (AppData.minPrice * 1000) && p.ContractPrice <= (AppData.maxPrice * 1000));
        }
        private void BtnReservation_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Тур забронирован", "OK", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
