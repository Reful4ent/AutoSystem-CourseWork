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
    /// Логика взаимодействия для AnswerQuestionWindow.xaml
    /// </summary>
    public partial class AnswerQuestionWindow : Window
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        public AnswerQuestionWindow(IDataManager dataManager, IServiceManager serviceManager)
        {
            InitializeComponent();
            DataContext = new AnswerQuestionVM (this.dataManager = dataManager,this.serviceManager = serviceManager);
        }

        private void Minimize_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Navbar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Exit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TestsListWindow testsListWindow = new TestsListWindow(dataManager,serviceManager);
            testsListWindow.Show();
            this.Close();
        }
    }
}
