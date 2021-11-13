using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для BuyPage.xaml
    /// </summary>
    public partial class BuyPage : Page
    {
        public BuyPage()
        {
            InitializeComponent();
            cmbStation.ItemsSource = File.ReadAllLines("Station.txt");
            tbSum.Text = $"Стоимость: {Manager.sum} руб.";
            datePicker.SelectedDate = DateTime.Today;
        }

        private void RbtnWithoutDel_Checked(object sender, RoutedEventArgs e)
        {
            cmbStation.IsEnabled = true;
            tbDelivery.IsEnabled = false;
        }

        private void RbtnWithDel_Checked(object sender, RoutedEventArgs e)
        {
            tbDelivery.IsEnabled = true;
            cmbStation.IsEnabled = false;
        }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.StartFrame.Navigate(new StartPage());
        }

        private void BtnOrder_Click(object sender, RoutedEventArgs e)
        {
            if (tbName.Text==""||tbNumber.Text=="")
            {
                MessageBox.Show("Заполнены не все поля для оформления заказа!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if ((cmbStation.IsEnabled==true && cmbStation.Text=="")||(tbDelivery.IsEnabled==true &&tbDelivery.Text==""))
                {
                    MessageBox.Show("Заполнены не все поля для получения заказа!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    if (Manager.ValidFound(tbName.Text,@"[а-яА-Я]")&&Manager.ValidFound(tbNumber.Text,@"[0-9]"))
                    {
                        MessageBox.Show("Заказ успешно оформлен!", "Готово!", MessageBoxButton.OK, MessageBoxImage.Information);
                        File.AppendAllText(".../Resources/Отзывы/Чек.txt", $"\nКем заказан: {tbName.Text}.\nНомер телефона: {tbNumber.Text}.\nЗаказ на сумму: {Manager.sum} руб.\nДата: {datePicker.Text}");
                        btnOrder.IsEnabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Проверьте правильность вводимых данных!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }
    }
}
