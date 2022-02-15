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
    /// Interaction logic for Test6.xaml
    /// </summary>
    public partial class Test6 : Page
    {
        public bool c;
        public bool condition;
        public int a;
        public bool f;
        public int g;
        public Test6(int t)
        {
            InitializeComponent();
            c = false;
            condition = false;
            g = t;
            f = false;
          
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
                g = g + 1;
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
            EndTest end = new EndTest(g);
            Manager.MainFrame.Navigate(end);
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {

            Manager.MainFrame.GoBack();

        }
    }
}
