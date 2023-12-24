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
using static System.Net.Mime.MediaTypeNames;
using AutoSystem_CourseWork_.ViewModel.Services;

namespace AutoSystem_CourseWork_.View
{
    /// <summary>
    /// Логика взаимодействия для CoursesAddList.xaml
    /// </summary>
    public partial class CoursesAddList : Window
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        public CoursesAddList(IDataManager dataManager,IServiceManager serviceManager)
        {
            InitializeComponent();
            MouseLeftButtonDown += Navbar_MouseLeftButtonDown;
            DataContext = new CoursesAddListVM(this.dataManager = dataManager,this.serviceManager = serviceManager);
            if (DataContext is CoursesAddListVM coursesAddListVM)
            {
                coursesAddListVM.AddCourseFailed += OpenErrorWindow;
            }
        }


        public void OpenErrorWindow(string text)
        {
            ErrorWindow errorWindow = new ErrorWindow(text);
            errorWindow.ShowDialog();
        }

        private void Navbar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => this.DragMove();

        private void Minimize_MouseDown(object sender, MouseButtonEventArgs e) => this.WindowState = WindowState.Minimized;

        private void Exit_MouseDown(object sender, MouseButtonEventArgs e) => this.Close();
    }
}
