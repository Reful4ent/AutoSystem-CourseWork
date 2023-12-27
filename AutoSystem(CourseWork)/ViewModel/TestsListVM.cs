using AutoSystem_CourseWork_.Model.Сourse.Test;
using AutoSystem_CourseWork_.ViewModel.DataManager;
using AutoSystem_CourseWork_.ViewModel.Services;
using AutoSystem_CourseWork_.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AutoSystem_CourseWork_.ViewModel
{
    public class TestsListVM : BasicVM
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        private ObservableCollection<ITest> tests;
        private int index;

        public event Action? SetTestSucces;
        public TestsListVM(IDataManager dataManager, IServiceManager serviceManager)
        {
            this.dataManager = dataManager;
            this.serviceManager = serviceManager;
            TestsList = new ObservableCollection<ITest>(this.dataManager.ParticularCurse.Tests);
        }

        public ObservableCollection<ITest> TestsList
        {
            get => tests;
            set => Set(ref tests, value);
        }

        public int Index
        {
            get => index;
            set => Set(ref index, value);
        }

        public void SetTest()
        {
            if(serviceManager.TrySetTest(Index))
            {
                SetTestSucces?.Invoke();
            }
        }

        public ICommand SetTestCommand
        {
            get
            {
                return new Command(() =>
                {
                    SetTest();
                });
            }
        }
    }
}
