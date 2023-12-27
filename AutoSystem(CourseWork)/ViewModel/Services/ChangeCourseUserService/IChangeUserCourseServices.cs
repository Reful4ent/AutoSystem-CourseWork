using AutoSystem_CourseWork_.Model.Сourse;
using AutoSystem_CourseWork_.ViewModel.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.ViewModel.Services.AddCourseUserService
{
    public interface IChangeUserCourseServices
    {
        public bool TryAddUserCourse(ICourse course, IDataManager dataManager);
        public bool TryRemoveUserCourse(int number, IDataManager dataManager);
    }
}
