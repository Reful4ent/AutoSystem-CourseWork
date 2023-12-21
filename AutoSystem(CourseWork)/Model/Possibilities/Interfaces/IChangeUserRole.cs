using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.Model.Possibilities.Interfaces
{
    public interface IChangeUserRole
    {
        public List<User> ChangeUserRole(List<User> users, int number, int Role_Id);
    }
}
