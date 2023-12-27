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
using AutoSystem_CourseWork_.ViewModel;

namespace AutoSystem_CourseWork_.View
{
    public partial class SolveTestWindow : Window
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        public SolveTestWindow(IDataManager dataManager, IServiceManager serviceManager)
        {
            InitializeComponent();
            DataContext = new SolveTestVM(this.dataManager = dataManager, this.serviceManager = serviceManager);
        }
    }
}
