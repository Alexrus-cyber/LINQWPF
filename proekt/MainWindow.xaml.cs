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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext db;

        private readonly Personalizer personalizer;
        public MainWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
            personalizer = new Personalizer(db); 
        }



        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (NameUTb.Text.Length <= 2)
                {
                    
                    NameUTb.ToolTip = "Поле введено не корректно";
                    MessageBox.Show("Имя должно быть минимум из 3 символов");
                    MainWindow mainWindow = new MainWindow();
                   
                }
                else if (NameUTb.Text.Length >= 15)
                {
                    NameUTb.ToolTip = "Поле введено не корректно";
                    MessageBox.Show("Имя должно быть максимум из 10 символов");
                    MainWindow mainWindow = new MainWindow();
                    

                }
                else if (SubnameUTb.Text.Length <= 3)
                {
                    SubnameUTb.ToolTip = "Поле введено не корректно";
                    MessageBox.Show("Фамилия должна быть минимум из 4 символов");
                    MainWindow mainWindow = new MainWindow();
                 
                }
                else if (SubnameUTb.Text.Length >= 15)
                {
                    SubnameUTb.ToolTip = "Поле введено не корректно";
                    MessageBox.Show("Фамилия должна быть максимум из 15 символов");
                    MainWindow mainWindow = new MainWindow();
                   
                }
                else if (PatronymicUTb.Text.Length >= 15)
                {
                    PatronymicUTb.ToolTip = "Поле введено не корректно";
                    MessageBox.Show("Отчество должно быть максимум из 12 символов");
                    MainWindow mainWindow = new MainWindow();
           
                }
                else if (PatronymicUTb.Text.Length <= 3)
                {
                    PatronymicUTb.ToolTip = "Поле введено не корректно";
                    MessageBox.Show("Отчество должно быть максимум из 4 символов");
                    MainWindow mainWindow = new MainWindow();
     
                }
                else if (PhoneTb.Text.Length >= 7)
                {
                  
                    PhoneTb.ToolTip = "Поле введено не корректно";
                    MessageBox.Show("Код должен быть максимум из 6 символов");
                    MainWindow mainWindow = new MainWindow();
                }
                else
                {
                    bool successRegister = personalizer.Register(NameUTb.Text.Trim(), SubnameUTb.Text.Trim(), PatronymicUTb.Text.Trim(), PhoneTb.Text.Trim());
                    MessageBox.Show(successRegister ? "Вы успешно зарегестрировались" : "Пользовтель с таким логином уже существует");
                    if (successRegister == true)
                    {
                        Esoft esoft = new Esoft();
                        esoft.Show();
                    }
                    Close();

                }
            }
            catch(Exception)
            {
                Application.Current.Shutdown(0);
            }
        }

        }
        
    }

