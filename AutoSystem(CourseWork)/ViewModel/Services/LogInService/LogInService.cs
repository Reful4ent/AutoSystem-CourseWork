using AutoSystem_CourseWork_.ViewModel.DataManager;
using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSystem_CourseWork_.Data.UserSerialization;
using AutoSystem_CourseWork_.Model.Basic;
using AutoSystem_CourseWork_.Model;

namespace AutoSystem_CourseWork_.ViewModel.Services.LogInService
{
    internal class LogInService : ILogIn
    {
        private UserRepository UserRepository;
        public LogInService(UserRepository UserRepository)
        {
            this.UserRepository = UserRepository;
        }

        public bool TryLogIn(string login, string password,ref User ParticularUser)
        {
            password = Convert.ToBase64String(MD5.HashData(Encoding.UTF8.GetBytes(password)));
            var tryFind = (from x in UserRepository.GetUsers()
                           where x.Login == login && x.Password == password
                           select x).FirstOrDefault();
            if (tryFind != null)
            {
                ParticularUser = tryFind;
                return true;
            }
            return false;
        }
    }
}
