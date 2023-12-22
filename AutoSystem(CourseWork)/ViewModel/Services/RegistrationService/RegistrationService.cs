using AutoSystem_CourseWork_.Data.CoursesSerialization;
using AutoSystem_CourseWork_.Data.UserSerialization;
using AutoSystem_CourseWork_.Model;
using AutoSystem_CourseWork_.Model.Сourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.ViewModel.Services.RegistrationService
{
    internal class RegistrationService : IRegistration
    {
        //private UserRepository UserRepository;
        //public RegistrationService(UserRepository UserRepository)
        //{
        //    this.UserRepository = UserRepository;
        //}

        public bool TryRegistration(string name,string login,string password, string passwordRepeat, ref UserRepository userRepository)
        {
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(passwordRepeat) == null) return false;
            if (login.Contains(" ") || password.Contains(" ") || passwordRepeat.Contains(" ")) return false;
            if (password != passwordRepeat) return false;
            var tryFind = (from x in userRepository.GetUsers()
                           where x.Login == login
                           select x).FirstOrDefault();
            if (tryFind != null) return false;
            List<ICourse> courses = new ();
            User userRegistration = new(Guid.NewGuid(), name, login, Convert.ToBase64String(MD5.HashData(Encoding.UTF8.GetBytes(password))), 0, courses);
            userRepository.Add(userRegistration);
            userRepository.Save();
            return true;
        }
    }
}
