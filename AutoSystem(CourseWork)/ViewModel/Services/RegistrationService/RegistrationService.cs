using AutoSystem_CourseWork_.Data.UserSerialization;
using AutoSystem_CourseWork_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.ViewModel.Services.RegistrationService
{
    internal class RegistrationService : IRegistration
    {
        private UserRepository UserRepository;
        public RegistrationService(UserRepository UserRepository)
        {
            this.UserRepository = UserRepository;
        }

        public bool TryRegistration(string name,string login,string password, string passwordRepeat, ref User ParticularUser)
        {

        }
    }
}
