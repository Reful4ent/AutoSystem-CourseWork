using AutoSystem_CourseWork_.Data.CoursesSerialization;
using AutoSystem_CourseWork_.Data.UserSerialization;
using AutoSystem_CourseWork_.Model;
using AutoSystem_CourseWork_.Model.Сourse;
using AutoSystem_CourseWork_.ViewModel.DataManager;
using AutoSystem_CourseWork_.ViewModel.Services.AddCourseUserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.ViewModel.Services.RegistrationService
{
    public class RegistrationServices : IRegistrationServices
    {
        public static RegistrationServices Instance() => new();
        public bool TryRegistration(string name,string login,string password, string passwordRepeat, IDataManager dataManager)
        {
            if (password != passwordRepeat) return false;
            var tryFind = (from x in dataManager.UserRepository.GetUsers()
                           where x.Login == login
                           select x).FirstOrDefault();
            if (tryFind != null) return false;
            List<ICourse> courses = new ();
            User userRegistration;
            try
            {
                userRegistration = new(Guid.NewGuid(), name, login, Convert.ToBase64String(MD5.HashData(Encoding.UTF8.GetBytes(password))), 0, courses);
            }
            catch (Exception ex)
            {
                return false;
            }
            if (!dataManager.UserRepository.Add(userRegistration)) return false;
            dataManager.UserRepository.Save();
            return true;
        }
    }
}
