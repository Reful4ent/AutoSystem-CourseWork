using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSystem_CourseWork_.Model.Possibilities.Interfaces;

namespace AutoSystem_CourseWork_.Model.Possibilities.Classes
{
    public class CanChangeUserRole : IChangeUserRole
    {
        public List<User> ChangeUserRole(List<User> users, int number, int Role_Id)
        {
            if (users == null) return null;
            if (number >= users.Count || number < 0)
                return null;
            if (Role_Id > 2) return null;
            users[number].Role_Id = Role_Id;
            return users;
        }
    }
}
