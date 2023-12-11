using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using AutoSystem_CourseWork_.Model.Possibilities.Interfaces;

namespace AutoSystem_CourseWork_.Model.Possibilities.Classes
{
    public class CantChangeUserRole : IChangeUserRole
    {
        public bool ChangeUserRole(int Role_Id) => false;
    }
}
