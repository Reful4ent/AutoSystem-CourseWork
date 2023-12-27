using AutoSystem_CourseWork_.Model.Сourse.Test;
using AutoSystem_CourseWork_.ViewModel.DataManager;
using AutoSystem_CourseWork_.ViewModel.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.ViewModel
{
    public class TestsListVM : BasicVM
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        public ObservableCollection<ITest> tests;
        public TestsListVM(IDataManager dataManager, IServiceManager serviceManager)
        {
            this.dataManager = dataManager;
            this.serviceManager = serviceManager;
            TestsList = new ObservableCollection<ITest>(this.dataManager.ParticularCurse.Tests);
        }

        public ObservableCollection<ITest> TestsList
        {
            get => tests;
            set => tests = value;
        }
    }
}
