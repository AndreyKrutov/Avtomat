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

namespace Avtomat
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int itog = 0;
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            itog++;
            Itog.Text = itog.ToString() + " руб.";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            itog = itog + 2;
            Itog.Text = itog.ToString() + " руб.";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            itog = itog + 5;
            Itog.Text = itog.ToString() + " руб.";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            itog = itog + 10;
            Itog.Text = itog.ToString() + " руб.";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if(Code.Text == "123")
            {
                Admin admin = new Admin();
                admin.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Не верный пароль!");
            }
        }
    }
}
