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

namespace BolotinTour
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppData.MainFrame = MainFrame;
            AppData.MainFrame.Navigate(new Pages.Step1Page());
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            var page = AppData.MainFrame.Content as Page;
            this.Title = $"Туристическое агенство | {page.Title}";
            if (page.Title == "Шаг 1")
            {
                EllipseStep1.Fill = Brushes.LimeGreen;
                EllipseStep2.Fill = Brushes.White;
                EllipseStep3.Fill = Brushes.White;
                EllipseStep4.Fill = Brushes.White;
                txtStep1.FontWeight = FontWeights.Bold;

            }
            if (page.Title == "Шаг 2")
            {
                EllipseStep1.Fill = Brushes.Gray;
                EllipseStep2.Fill = Brushes.LimeGreen;
                EllipseStep3.Fill = Brushes.White;
                EllipseStep4.Fill = Brushes.White;
                txtStep1.FontWeight = FontWeights.Normal;
                txtStep2.FontWeight = FontWeights.Bold;
            }
            if (page.Title == "Шаг 3")
            {
                EllipseStep1.Fill = Brushes.Gray;
                EllipseStep2.Fill = Brushes.Gray;
                EllipseStep3.Fill = Brushes.LimeGreen;
                EllipseStep4.Fill = Brushes.White;
                txtStep1.FontWeight = FontWeights.Normal;
                txtStep2.FontWeight = FontWeights.Normal;
                txtStep3.FontWeight = FontWeights.Bold;
            }
            if (page.Title == "Шаг 4")
            {
                EllipseStep1.Fill = Brushes.Gray;
                EllipseStep2.Fill = Brushes.Gray;
                EllipseStep3.Fill = Brushes.Gray;
                EllipseStep4.Fill = Brushes.LimeGreen;
                txtStep1.FontWeight = FontWeights.Normal;
                txtStep2.FontWeight = FontWeights.Normal;
                txtStep3.FontWeight = FontWeights.Normal;
                txtStep4.FontWeight = FontWeights.Bold;
            }
        }
    }
}
