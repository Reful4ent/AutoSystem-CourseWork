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
using AutoSystem_CourseWork_.ViewModel.DataManager;
using AutoSystem_CourseWork_.ViewModel;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using AutoSystem_CourseWork_.ViewModel.Services;

namespace AutoSystem_CourseWork_.View
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        public RegistrationWindow(IDataManager dataManager, IServiceManager serviceManager)
        {
            InitializeComponent();
            DataContext = new RegistrationVM(this.dataManager = dataManager, this.serviceManager = serviceManager);
            MouseLeftButtonDown += Navbar_MouseLeftButtonDown;
            if(DataContext is RegistrationVM registrationVM)
            {
                registrationVM.RegistrationSucces += OpenMainWindow;
                registrationVM.RegistrationFailed += OpenErrorWindow;
            }
        }

        private void Exit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            LogInWindow logInWindow = new LogInWindow(dataManager,serviceManager);
            logInWindow.Show();
            this.Close();
        }
        public void OpenMainWindow()
        {
            MainWindow mainWindow = new MainWindow(dataManager,serviceManager);
            mainWindow.Show();
            this.Close();
        }
        public void OpenErrorWindow(string text)
        {
            ErrorWindow errorWindow = new ErrorWindow(text);
            errorWindow.ShowDialog();
        }

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
        private void Form_Input_Password_PB_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if(DataContext is RegistrationVM registrationVM)
            {
                registrationVM.Password = Form_Input_Password_PB.Password;
            }
        }
        private void Form_Input_Password_RepPB_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is RegistrationVM registrationVM)
            {
                registrationVM.PasswordRepeat = Form_Input_Password_RepPB.Password;
            }
        }
    }
}
