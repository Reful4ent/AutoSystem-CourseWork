using AutoSystem_CourseWork_.Data.UserSerialization;
using AutoSystem_CourseWork_.Model;
using AutoSystem_CourseWork_.Model.Сourse;
using AutoSystem_CourseWork_.ViewModel.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.ViewModel.Services.AddCourseUserService
{
    internal class ChangeUserCourseServices : IChangeUserCourse
    {
        public bool TryAddUserCourse(ICourse course, IDataManager dataManager)
        {
            if (!(dataManager.ParticularUser.AddMeCourse(course))) return false; 
            if(!(dataManager.UserRepository.Update(dataManager.ParticularUser))) return false;
            if(!(dataManager.UserRepository.Save())) return false;
            return true;
        }

        public bool TryRemoveUserCourse(int number, IDataManager dataManager)
        {
            if(!(dataManager.ParticularUser.RemoveMeCourse(number))) return false;
            if(!(dataManager.UserRepository.Update(dataManager.ParticularUser))) return false;
            if (!(dataManager.UserRepository.Save())) return false;
            return true;
        }
    }
}
