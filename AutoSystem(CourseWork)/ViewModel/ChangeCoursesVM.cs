using AutoSystem_CourseWork_.Model.Сourse;
using AutoSystem_CourseWork_.ViewModel.DataManager;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.ViewModel
{
    public class ChangeCoursesVM : BasicVM
    {
        IDataManager dataManager;
        private ObservableCollection<ICourse> coursesList;
        private int index;

        public ChangeCoursesVM(IDataManager dataManager)
        {
            this.dataManager = dataManager;
            CoursesList = new ObservableCollection<ICourse>(this.dataManager.CoursesRepository.GetCourses());
        }

        public ObservableCollection<ICourse> CoursesList
        {
            get => coursesList;
            set => Set(ref coursesList, value);
        }
        public int Index
        {
            get => index;
            set => Set(ref index, value);
        }
    }
}
