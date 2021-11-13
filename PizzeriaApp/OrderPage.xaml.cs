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
    /// Логика взаимодействия для OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        public OrderPage()
        {
            InitializeComponent();
        }

        private void BtnPromocode_Click(object sender, RoutedEventArgs e)
        {
            if(tbPromocode.Text== "100200")
            {
                MessageBox.Show("На ваш заказ действует скидка 10%!", "Готово!", MessageBoxButton.OK, MessageBoxImage.Information);
                Manager.promocode = true;
            }
            else
            {
                MessageBox.Show("Заполните поле или проверьте правильность введенного кода!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.StartFrame.GoBack();
        }

        private void BtnOrder_Click(object sender, RoutedEventArgs e)
        {
            if(Manager.sum==0)
            {
                MessageBox.Show("Нельзя оформить пустой заказ!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (Manager.promocode == true)
                { Manager.sum -= Manager.sum / 100 * 10; }
                Manager.StartFrame.Navigate(new BuyPage());
            }
        }

        private void CbPizzaCheese_Checked(object sender, RoutedEventArgs e)
        {
            Manager.sum += 600;
        }

        private void CbPizzaMeet_Checked(object sender, RoutedEventArgs e)
        {
            Manager.sum += 619;
        }

        private void CbPizzaHot_Checked(object sender, RoutedEventArgs e)
        {
            Manager.sum += 519;
        }

        private void CbPizzaGrec_Checked(object sender, RoutedEventArgs e)
        {
            Manager.sum += 560;
        }

        private void CbPizzaBacon_Checked(object sender, RoutedEventArgs e)
        {
            Manager.sum += 589;
        }

        private void CbPizzaHawaiian_Checked(object sender, RoutedEventArgs e)
        {
            Manager.sum += 527;
        }

        private void CbPizzaVegan_Checked(object sender, RoutedEventArgs e)
        {
            Manager.sum += 513;
        }

        private void CbPizzaMargarita_Checked(object sender, RoutedEventArgs e)
        {
            Manager.sum += 613;
        }

        private void CbPizzaMushrooms_Checked(object sender, RoutedEventArgs e)
        {
            Manager.sum += 640;
        }

        private void CbCheesecake_Checked(object sender, RoutedEventArgs e)
        {
            Manager.sum += 179;
        }

        private void CbCheesecakeChoco_Checked(object sender, RoutedEventArgs e)
        {
            Manager.sum += 189;
        }

        private void CbSweets_Checked(object sender, RoutedEventArgs e)
        {
            Manager.sum += 89;
        }

        private void CbPancake_Checked(object sender, RoutedEventArgs e)
        {
            Manager.sum += 239;
        }

        private void CbDonat_Checked(object sender, RoutedEventArgs e)
        {
            Manager.sum += 119;
        }

        private void CbPepsi_Checked(object sender, RoutedEventArgs e)
        {
            Manager.sum += 89;
        }

        private void CbPepsiLight_Checked(object sender, RoutedEventArgs e)
        {
            Manager.sum += 80;
        }

        private void CbLiptonLemon_Checked(object sender, RoutedEventArgs e)
        {
            Manager.sum += 99;
        }

        private void CbLiptonPeach_Checked(object sender, RoutedEventArgs e)
        {
            Manager.sum += 99;
        }

        private void CbPizzaCheese_Unchecked(object sender, RoutedEventArgs e)
        {
            Manager.sum -= 600;
        }

        private void CbPizzaMeet_Unchecked(object sender, RoutedEventArgs e)
        {
            Manager.sum -= 619;
        }

        private void CbPizzaHot_Unchecked(object sender, RoutedEventArgs e)
        {
            Manager.sum -= 519;
        }

        private void CbPizzaGrec_Unchecked(object sender, RoutedEventArgs e)
        {
            Manager.sum -= 560;
        }

        private void CbPizzaBacon_Unchecked(object sender, RoutedEventArgs e)
        {
            Manager.sum -= 589;
        }

        private void CbPizzaHawaiian_Unchecked(object sender, RoutedEventArgs e)
        {
            Manager.sum -= 527;
        }

        private void CbPizzaVegan_Unchecked(object sender, RoutedEventArgs e)
        {
            Manager.sum -= 513;
        }

        private void CbPizzaMargarita_Unchecked(object sender, RoutedEventArgs e)
        {
            Manager.sum -= 613;
        }

        private void CbPizzaMushrooms_Unchecked(object sender, RoutedEventArgs e)
        {
            Manager.sum -= 640;
        }

        private void CbCheesecake_Unchecked(object sender, RoutedEventArgs e)
        {
            Manager.sum -= 179;
        }

        private void CbCheesecakeChoco_Unchecked(object sender, RoutedEventArgs e)
        {
            Manager.sum -= 189;
        }

        private void CbSweets_Unchecked(object sender, RoutedEventArgs e)
        {
            Manager.sum -= 89;
        }

        private void CbPancake_Unchecked(object sender, RoutedEventArgs e)
        {
            Manager.sum -= 239;
        }

        private void CbDonat_Unchecked(object sender, RoutedEventArgs e)
        {
            Manager.sum -= 119;
        }

        private void CbPepsi_Unchecked(object sender, RoutedEventArgs e)
        {
            Manager.sum -= 89;
        }

        private void CbPepsiLight_Unchecked(object sender, RoutedEventArgs e)
        {
            Manager.sum -= 80;
        }

        private void CbLiptonLemon_Unchecked(object sender, RoutedEventArgs e)
        {
            Manager.sum -= 99;
        }

        private void CbLiptonPeach_Unchecked(object sender, RoutedEventArgs e)
        {
            Manager.sum -= 99;
        }
    }
}
