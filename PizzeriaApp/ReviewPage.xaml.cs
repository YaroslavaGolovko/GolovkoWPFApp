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
using System.IO;
using Microsoft.Win32;

namespace PizzeriaApp
{
    /// <summary>
    /// Логика взаимодействия для ReviewPage.xaml
    /// </summary>
    public partial class ReviewPage : Page
    {
        public ReviewPage()
        {
            InitializeComponent();
            if(Manager.review==true)
            {
                btnSaveFile.IsEnabled = false;
            }
        }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.StartFrame.GoBack();
        }

        private void BtnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(tbReview.Text!="")
            {
                File.WriteAllText("Отзыв.txt", tbReview.Text);
                MessageBox.Show("Ваш уникальный промокод - 100200!", "Готово!", MessageBoxButton.OK, MessageBoxImage.Information);
                Manager.review = true;
                Manager.StartFrame.GoBack();
            }
            else
            {
                MessageBox.Show("Поле отзыва не должно быть пустым!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
