using AutoSystem_CourseWork_.Data.UserSerialization;
using AutoSystem_CourseWork_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.ViewModel.Services.ChangeUserRepService
{
    internal class ChangeUserRepService : IChangeUserRep
    {
        public bool TryDeleteUser(int number, ref UserRepository userRepository, ref User ParticularUser)
        {
            if (number == userRepository.GetUsers().IndexOf(ParticularUser)) return false;
            if (ParticularUser.DeleteUser(userRepository.GetUsers(), number) == null) return false;
            userRepository.Save();
            return true;
        }

        public bool TryChangeUserRole(int number, int Role_Id, ref UserRepository userRepository, ref User ParticularUser)
        {
            if (number == userRepository.GetUsers().IndexOf(ParticularUser)) return false;
            if (ParticularUser.ChangeUserRole(userRepository.GetUsers(), number, Role_Id) == null) return false;
            userRepository.Save();
            return true;
        }
    }
}
