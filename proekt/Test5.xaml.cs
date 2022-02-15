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
    /// Interaction logic for Test5.xaml
    /// </summary>
    public partial class Test5 : Page
    {
        public bool c;
        public bool condition;
        public int t;
      
        public Test5(int l)
        {
            InitializeComponent();
            c = false;
            condition = false;
            t = l;
           
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            c = false;
            condition = true;
            if (c == false)
            {
                t = t;
            }
        }

        private void testc_Checked(object sender, RoutedEventArgs e)
        {
            c = true;
            if (c == true)
            {
                t = t + 1;
            }
            condition = true;
        }

        private void testcc_Checked(object sender, RoutedEventArgs e)
        {
            c = false;
            condition = true;
            if (c == false)
            {
                t = t;
            }
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (condition == true)
            {
                Test6 test6 = new Test6(t);
                Manager.MainFrame.Navigate(test6);
            }
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {

            Manager.MainFrame.GoBack();
        }
    }
}
