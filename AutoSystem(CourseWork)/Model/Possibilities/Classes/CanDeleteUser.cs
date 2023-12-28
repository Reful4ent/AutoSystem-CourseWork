using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSystem_CourseWork_.Model.Possibilities.Interfaces;

namespace AutoSystem_CourseWork_.Model.Possibilities.Classes
{
    public class CanDeleteUser : IDeleteUser
    {
        public List<User> DeleteUser(List<User> users, int number)
        {
            if (users == null) return null;
            if (number >= users.Count || number < 0)
                return users;
            users.RemoveAt(number);
            return users;
        }
    }
}
