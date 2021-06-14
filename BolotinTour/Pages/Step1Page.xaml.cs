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
    /// Логика взаимодействия для Step1Page.xaml
    /// </summary>
    public partial class Step1Page : Page
    {
        public Step1Page()
        {
            InitializeComponent();
        }
        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            string error = null;
            if (DpickStart.SelectedDate >= DpickEnd.SelectedDate ||
                TBoxQuantityPeaple.Text == "")
            {
                error += "Дата начала периода не может быть позже даты окончания \n";
                //MessageBox.Show("У ВАС ЕСТЬ ОШИБКИ УГАДАЙТЕ САМИ ГДЕ )))0)", "Прикол", MessageBoxButton.YesNoCancel, MessageBoxImage.Exclamation);
            }
            if (TBoxQuantityPeaple.Text == "")
            {
                error += "Заполните поле 'Количество человек'";
            }
            if(error != null)
            {
                MessageBox.Show(error, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                error = null;
            }
            else
            {
                AppData.MainFrame.Navigate(new Pages.Step2Page());
            }

        }

        private void PrevTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !char.IsDigit(e.Text, 0);
        }
    }
}
