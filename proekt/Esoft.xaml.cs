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
    /// Логика взаимодействия для Esoft.xaml
    /// </summary>
    public partial class Esoft : Window
    {
        ApplicationContext db;
        public Esoft()
        {
            InitializeComponent();
            db = new ApplicationContext();
            MainFrame.Navigate(new StTest());
            Manager.MainFrame = MainFrame;
        }

        private void ListOfUsers_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListClients());
        }

        private void ListOfAgents_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new StTest());
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(0);
        }

        private void TextReader(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TextReader());
        }
    }
}
