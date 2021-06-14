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
    /// Interaction logic for Step2Page.xaml
    /// </summary>
    public partial class Step2Page : Page
    {
        List<TourType> _tour = new List<TourType>();
        public Step2Page()
        {
            InitializeComponent();
            LViewType.ItemsSource = AppData.Context.TourType.ToList();
        }
        private void MakeDrag_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //var block = sender as TextBlock;
            //if (block.DataContext is Type type)
            //{
            //    DragDrop.DoDragDrop(block, type, DragDropEffects.Move);
            //}
        }

        private void LViewPrioryti_Drop(object sender, DragEventArgs e)
        {

            var data = e.Data.GetData(typeof(TourType)) as TourType;
            _tour.Add(data);
            LViewPrioryti.ItemsSource = _tour.ToList();

        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            AppData.MainFrame.Navigate(new Pages.Step3Page());
        }

        private void BtnSkip_Click(object sender, RoutedEventArgs e)
        {
            AppData.MainFrame.Navigate(new Pages.Step3Page());
        }

        private void ItemType_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var grid = (sender as Grid).DataContext as TourType;
            DataObject data = new DataObject(typeof(TourType), AppData.Context.TourType.ToList().FirstOrDefault(p => p.Name == grid.Name));
            DragDrop.DoDragDrop(LViewType, data, DragDropEffects.Move);
        }
    }
}
