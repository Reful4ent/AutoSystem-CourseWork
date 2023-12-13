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
        public static MyRoleFabric GetMyRole(int Role_Id) => Role_Id switch
        {
            0 => new StudentFabric(new AnswerQuestion(), new ChangeUserCourse(), new CantChangeCourse(), new CantChangeTest(), new CantChangeQuestion(), new CantChangeAnswer(), new CantChangeUserRole(), new CantDeleteUser()),
            1 => new TutorFabric(new AnswerQuestion(), new ChangeUserCourse(), new CanChangeCourse(), new CanChangeTest(), new CanChangeQuestion(), new CanChangeAnswer(), new CantChangeUserRole(), new CantDeleteUser()),
            2 => new AdminFabric(new AnswerQuestion(), new ChangeUserCourse(), new CanChangeCourse(), new CanChangeTest(), new CanChangeQuestion(), new CanChangeAnswer(), new CanChangeUserRole(), new CanDeleteUser()),
            _ => null
        };
    }
}
