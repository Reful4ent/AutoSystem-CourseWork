using AutoSystem_CourseWork_.ViewModel.DataManager;
using AutoSystem_CourseWork_.ViewModel.Services;
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
    /// Логика взаимодействия для ResultsWindow.xaml
    /// </summary>
    public partial class ResultsWindow : Window
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        public ResultsWindow(int results, int count, IDataManager dataManager, IServiceManager serviceManager)
        {
            InitializeComponent();
            this.dataManager = dataManager;
            this.serviceManager = serviceManager;
            Results_Textblock.Text = "Вы ответили верно на: " + results + " из " + count + "Вопросов"; 
        }

        private void End_Test_Button_Click(object sender, RoutedEventArgs e)
        {
            TestsListWindow testsListWindow = new TestsListWindow(dataManager, serviceManager);
            testsListWindow.Show();
            this.Close();
        }
    }
}
