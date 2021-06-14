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
    /// Логика взаимодействия для Step3Page.xaml
    /// </summary>
    public partial class Step3Page : Page
    {
        public Step3Page()
        {
            InitializeComponent();
            LViewService.ItemsSource = AppData.Context.Service.ToList();
            CBoxEat.ItemsSource = AppData.Context.Service.ToList();
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            AppData.minPrice = Convert.ToInt32(Math.Round(slMin.Value));
            AppData.maxPrice = Convert.ToInt32(Math.Round(slMax.Value));
            AppData.MainFrame.Navigate(new Pages.Step4Page());
        }

        private void BtnSkip_Click(object sender, RoutedEventArgs e)
        {
            AppData.minPrice = -1;
            AppData.maxPrice = -1;
            AppData.MainFrame.Navigate(new Pages.Step4Page());
        }

        private void SlMax_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (slMax.Value != 50)
            {
                txtMax.Text = $"До {Math.Round(slMax.Value)}.000";
                if (Convert.ToInt32(Math.Round(slMin.Value)) == Convert.ToInt32(Math.Round(slMax.Value)))
                {
                    slMin.Value = slMin.Value - 1;
                }
            }
        }

        private void SlMin_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (slMin.Value != 0)
            {
                txtMin.Text = $"От {Math.Round(slMin.Value)}.000";
                if(Convert.ToInt32(Math.Round(slMin.Value)) == Convert.ToInt32(Math.Round(slMax.Value)))
                {
                    slMax.Value = slMin.Value + 1;
                }
            }
            else
            {
                txtMin.Text = $"От {slMin.Value}";
            }
        }
    }
}
