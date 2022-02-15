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
    /// Interaction logic for Test3.xaml
    /// </summary>
    public partial class Test3 : Page
    {
        public bool c;
        public bool condition;
        public int k;
        public Test3(int b)
        {
            InitializeComponent();
            c = false;
            condition = false;
            k = b;
           
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            c = false;
            condition = true;
        }

        private void testc_Checked(object sender, RoutedEventArgs e)
        {
            c = true;
            if (c == true)
            {
                k = k + 1;
            }
            condition = true;
        }

        private void testcc_Checked(object sender, RoutedEventArgs e)
        {
            c = false;
            condition = true;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (condition == true)
            {
                Test4 test4 = new Test4(k);
                Manager.MainFrame.Navigate(test4);
            }
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {

            Manager.MainFrame.GoBack();

        }
    }
}
