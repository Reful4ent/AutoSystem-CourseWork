using AutoSystem_CourseWork_.ViewModel.DataManager;
using AutoSystem_CourseWork_.ViewModel.Services;
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
    /// Логика взаимодействия для TestsListWindow.xaml
    /// </summary>
    public partial class TestsListWindow : Window
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        public TestsListWindow(IDataManager dataManager, IServiceManager serviceManager)
        {
            InitializeComponent();
            MouseLeftButtonDown += Navbar_MouseLeftButtonDown;
            DataContext = new TestsListVM(this.dataManager = dataManager, this.serviceManager = serviceManager);
            if(DataContext is TestsListVM testsListVM)
            {
                testsListVM.SetTestSucces += OpenSolveTestWindow; 
            }
        }

        private void OpenSolveTestWindow()
        {
             SolveTestWindow solveTestWindow = new SolveTestWindow(dataManager,serviceManager);
             solveTestWindow.Show();
             this.Close();
        }
        private void Navbar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => this.DragMove();

        private void Minimize_MouseDown(object sender, MouseButtonEventArgs e) => this.WindowState = WindowState.Minimized;

        private void Exit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(dataManager,serviceManager);
            mainWindow.Show();
            this.Close();
        }
    }
}
