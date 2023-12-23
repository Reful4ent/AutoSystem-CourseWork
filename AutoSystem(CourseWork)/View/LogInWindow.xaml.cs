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
using AutoSystem_CourseWork_.ViewModel;
using AutoSystem_CourseWork_.ViewModel.DataManager;

namespace AutoSystem_CourseWork_.View
{
    /// <summary>
    /// Логика взаимодействия для LogInWindow.xaml
    /// </summary>
    public partial class LogInWindow : Window
    {
        private IDataManager dataManager;
        public LogInWindow(IDataManager dataManager)
        {
            InitializeComponent();
            MouseLeftButtonDown += Navbar_MouseLeftButtonDown;
            DataContext = new LogInVM(this.dataManager = dataManager);
            if (DataContext is LogInVM logInVM)
            {
                logInVM.LogInSucces += OpenMainWindow;
                logInVM.LogInFailed += OpenErrorWindow;
            }

        }

        private void OpenMainWindow()
        {
            MainWindow mainWindow = new MainWindow(dataManager);
            mainWindow.Show();
            this.Close();
        }

        private void OpenErrorWindow(string text)
        {
            ErrorWindow errorWindow = new ErrorWindow(text);
            errorWindow.ShowDialog();
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow(dataManager);
            registrationWindow.Show();
            this.Close();
        }

        private void Navbar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => this.DragMove();

        private void Minimize_MouseDown(object sender, MouseButtonEventArgs e) => this.WindowState = WindowState.Minimized;

        private void Exit_MouseDown(object sender, MouseButtonEventArgs e) => this.Close();

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

            }
            else
            {
                CountClick += 1;
                Form_Input_Password_PB.Password = Form_Input_Password_TB.Text;
                Form_Input_Password_PB.Visibility = Visibility.Visible;
                Form_Input_Password_TB.Visibility = Visibility.Hidden;
            }
        }
        private void Form_Input_Password_PB_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is LogInVM LogInViewModel)
                LogInViewModel.Password = Form_Input_Password_PB.Password;
        }
    }
}
