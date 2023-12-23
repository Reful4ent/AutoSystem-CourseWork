using AutoSystem_CourseWork_.ViewModel.DataManager;
using AutoSystem_CourseWork_.ViewModel;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IDataManager dataManager;
        public MainWindow(IDataManager dataManager)
        {
            InitializeComponent();
            MouseLeftButtonDown += Navbar_MouseLeftButtonDown;
            DataContext = new MainVM(this.dataManager = dataManager);
            if (DataContext is MainVM mainVM)
            {
                ButtonHide(mainVM.Role_Id);
                mainVM.DeleteSucces += RefreshWindow;
                mainVM.DeleteFailed += OpenErrorWindow;
            }
        }

        private void ButtonHide(int Role_Id)
        {
            switch (Role_Id)
            {
                case 0:
                    AddPanel.Visibility = Visibility.Hidden;
                    AdminPanel.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    AdminPanel.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        private void Exit_MouseDown(object sender, MouseButtonEventArgs e) => this.Close();

        private void Minimize_MouseDown(object sender, MouseButtonEventArgs e) => this.WindowState = WindowState.Minimized;

        private void Navbar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => this.DragMove();

        private void Add_Course_Click(object sender, RoutedEventArgs e)
        {
            CoursesAddList coursesAddList = new CoursesAddList(dataManager);
            coursesAddList.ShowDialog();
            if(DataContext is MainVM mainVM)
            {
                mainVM.RefreshCourses();
            }
        }

        public void RefreshWindow()
        {
            if (DataContext is MainVM mainVM)
            {
                mainVM.RefreshCourses();
            }
        }
        public void OpenErrorWindow(string text)
        {
            ErrorWindow errorWindow = new ErrorWindow(text);
            errorWindow.ShowDialog();
        }
    }
}
