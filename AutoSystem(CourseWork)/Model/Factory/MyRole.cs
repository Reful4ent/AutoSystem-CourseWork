using AutoSystem_CourseWork_.Model.Possibilities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.Model.Fabric
{
    internal static class MyRole
    {
        public static MyRoleFactory GetMyRole(int Role_Id) => Role_Id switch
        {
            0 => new StudentFactory(new CantChangeCourse(), new CantChangeTest(), new CantChangeQuestion(), new CantChangeUserRole(), new CantDeleteUser()),
            1 => new TutorFactory(new CanChangeCourse(), new CanChangeTest(), new CanChangeQuestion(), new CantChangeUserRole(), new CantDeleteUser()),
            2 => new AdminFactory(new CanChangeCourse(), new CanChangeTest(), new CanChangeQuestion(), new CanChangeUserRole(), new CanDeleteUser()),
            _ => null
        };
    }
}
