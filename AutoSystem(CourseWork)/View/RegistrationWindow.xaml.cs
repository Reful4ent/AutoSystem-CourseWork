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

namespace AutoSystem_CourseWork_.View
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
            MouseLeftButtonDown += Navbar_MouseLeftButtonDown;
        }

        private void Exit_MouseDown(object sender, MouseButtonEventArgs e) => this.Close();

        private void Minimize_MouseDown(object sender, MouseButtonEventArgs e) => this.WindowState = WindowState.Minimized;

        private void Navbar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => this.DragMove();

        int CountClick = 0; //Для показа пароля!
        private void Watch_Password_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if ((e.ChangedButton == MouseButton.Left) && ((CountClick % 2) == 0))
            {
                CountClick += 1;
                Form_Input_Password_TB.Text = Form_Input_Password_PB.Password;
                Form_Input_Password_TB.Visibility = Visibility.Visible;
                Form_Input_Password_PB.Visibility = Visibility.Hidden;
                Form_Input_Password_TB.Select(Form_Input_Password_TB.Text.Length, 0);
                Form_Input_Password_RepTB.Text = Form_Input_Password_RepPB.Password;
                Form_Input_Password_RepTB.Visibility = Visibility.Visible;
                Form_Input_Password_RepPB.Visibility = Visibility.Hidden;

            }
            else
            {
                CountClick += 1;
                Form_Input_Password_PB.Password = Form_Input_Password_TB.Text;
                Form_Input_Password_PB.Visibility = Visibility.Visible;
                Form_Input_Password_TB.Visibility = Visibility.Hidden;
                Form_Input_Password_RepPB.Password = Form_Input_Password_RepTB.Text;
                Form_Input_Password_RepPB.Visibility = Visibility.Visible;
                Form_Input_Password_RepTB.Visibility = Visibility.Hidden;
            }
        }

        private void Form_Input_Password_RepPB_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Form_Input_Password_PB_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
