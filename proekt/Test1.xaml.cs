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
    /// Interaction logic for Test1.xaml
    /// </summary>
    public partial class Test1 : Page
    {
        public bool c;
        public bool condition;
        public int a;
        public Test1(int g)
        {
            InitializeComponent();
            c = false;
            condition = false;
            a = 0;
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            c = false;
            condition = true;
            if (c == false)
            {
                a = a;
            }
        }

        private void testc_Checked(object sender, RoutedEventArgs e)
        {
            c = true;
            if (c == true)
            {
                a = a + 1;
            }
            condition = true;
        }

        private void testcc_Checked(object sender, RoutedEventArgs e)
        {
            c = false;
            condition = true;
            if (c == false)
            {
                a = a;
            }
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (condition == true)
            {
                Test2 test2 = new Test2(a);
                Manager.MainFrame.Navigate(test2);
            }
        }
    }
}
