using AutoSystem_CourseWork_.Model.Сourse.Test.Questions;
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
    public class SolveTestVM : BasicVM
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        private string theory = string.Empty;

        public SolveTestVM(IDataManager dataManager, IServiceManager serviceManager)
        {
            this.dataManager = dataManager;
            this.serviceManager = serviceManager;
            Theory = dataManager.ParticularTest.Theory;
        }

        public string Theory
        {
            get => theory;
            set => Set(ref theory, value);
        }
    }
}
