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
    /// Interaction logic for Test4.xaml
    /// </summary>
    public partial class Test4 : Page
    {
        public bool c;
        public bool condition;
        public int l;
        public Test4(int k)
        {
            InitializeComponent();
            c = false;
            condition = false;
            l = k;
       
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            c = false;
            condition = true;
            if (c == false)
            {
                l = l;
            }
        }

        private void testc_Checked(object sender, RoutedEventArgs e)
        {
            c = true;
            if (c == true)
            {
                l = l + 1;
            }
            condition = true;
        }

        private void testcc_Checked(object sender, RoutedEventArgs e)
        {
            c = false;
            condition = true;
            if (c == false)
            {
                l = l;
            }
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (condition == true)
            {
                Test5 test5 = new Test5(l);
                Manager.MainFrame.Navigate(test5);
            }
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {

            Manager.MainFrame.GoBack();

        }
    }
}
