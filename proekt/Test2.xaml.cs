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

namespace proekt
{
    /// <summary>
    /// Interaction logic for Test2.xaml
    /// </summary>
    public partial class Test2 : Page
    {
        public bool c;
        public bool condition;
        public int b;
        public Test2(int a)
        {
            InitializeComponent();
            c = false;
            condition = false;
            b = a;
            
        }

      

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            c = false;
            condition = true;
            if (c == false)
            {
                b = b ;
            }
        }

        private void testc_Checked(object sender, RoutedEventArgs e)
        {
            c = true;
            if (c == true)
            {
                b = b + 1;
            }
            condition = true;
        }

        private void testcc_Checked(object sender, RoutedEventArgs e)
        {
            c = false;
            condition = true;
            if (c == false)
            {
                b = b;
            }
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (condition == true)
            {
                Test3 test3 = new Test3(b);
                Manager.MainFrame.Navigate(test3);
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {

            Manager.MainFrame.GoBack();

        }
    }
}
