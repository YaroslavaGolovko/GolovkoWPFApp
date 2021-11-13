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

namespace PizzeriaApp
{
    /// <summary>
    /// Логика взаимодействия для StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void BtnInfo_Click(object sender, RoutedEventArgs e)
        {
            Manager.StartFrame.Navigate(new InfoPage());
        }

        private void BtnReview_Click(object sender, RoutedEventArgs e)
        {
            Manager.StartFrame.Navigate(new ReviewPage());
            if (Manager.review == true)
            {
                MessageBox.Show("Вы уже получили ваш уникальный промокод - 100200!", "Готово!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnOrder_Click(object sender, RoutedEventArgs e)
        {
            Manager.StartFrame.Navigate(new OrderPage());
        }
    }
}
