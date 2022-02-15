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
using System.Windows.Shapes;

namespace proekt
{
    /// <summary>
    /// Interaction logic for Testing.xaml
    /// </summary>
    public partial class Testing : Window
    {
        public bool f;
        public int a;
        public int b;
        public int k;
        public int l;
        public int t;
        public int g;
        public bool j;
        public Testing()
        {
            InitializeComponent();
            MainFrame.Navigate(new Test1(g));
            Manager.MainFrame = MainFrame;
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Test1(g));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Test2(a));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Test3(b));
           
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Test4(k));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Test5(l));
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

            MainFrame.Navigate(new Test6(t));
           
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack == true)
            {
                BtnBack.Visibility = Visibility.Visible;
            }
            else
            {
                BtnBack.Visibility = Visibility.Hidden;
            }
        }

        private void Btn_back(object sender, RoutedEventArgs e)
        {
            
            Close();
        }
    }
}
