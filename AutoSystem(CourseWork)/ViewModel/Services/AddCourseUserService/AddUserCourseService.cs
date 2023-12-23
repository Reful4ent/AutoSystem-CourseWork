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
    internal class AddUserCourseService : IAddUserCourse
    {
        public bool TryAddUserCourse(ICourse course,ref UserRepository userRepository, ref User ParticularUser)
        {
            if (!(ParticularUser.AddMeCourse(course))) return false; 
            if(!(userRepository.Update(ParticularUser))) return false;
            if(!(userRepository.Save())) return false;
            return true;
        }
    }
}
