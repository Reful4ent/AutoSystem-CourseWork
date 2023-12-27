using AutoSystem_CourseWork_.Data.UserSerialization;
using AutoSystem_CourseWork_.Model;
using AutoSystem_CourseWork_.ViewModel.DataManager;
using AutoSystem_CourseWork_.ViewModel.Services.AddCourseUserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.ViewModel.Services.ChangeUserRepService
{
    public class ChangeUserRepServices : IChangeUserRepServices
    {
        public static ChangeUserRepServices Instance() => new();
        public bool TryDeleteUser(int number, IDataManager dataManager)
        {
            if (number == dataManager.UserRepository.GetUsers().IndexOf(dataManager.ParticularUser)) return false;
            if (dataManager.ParticularUser.DeleteUser(dataManager.UserRepository.GetUsers(), number) == null) return false;
            dataManager.UserRepository.Save();
            return true;
        }

        public bool TryChangeUserRole(int number, int Role_Id, IDataManager dataManager)
        {
            if (number == dataManager.UserRepository.GetUsers().IndexOf(dataManager.ParticularUser)) return false;
            if (dataManager.ParticularUser.ChangeUserRole(dataManager.UserRepository.GetUsers(), number, Role_Id) == null) return false;
            dataManager.UserRepository.Save();
            return true;
        }
    }
}
