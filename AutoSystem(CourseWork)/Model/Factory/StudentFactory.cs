using AutoSystem_CourseWork_.Model.ForFabric_Roles_;
using AutoSystem_CourseWork_.Model.Possibilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.Model.Fabric
{
    internal class StudentFactory : MyRoleFactory
    {
        private readonly IChangeCourse _changeCourse;
        private readonly IChangeTest _changeTest;
        private readonly IChangeQuestion _changeQuestion;
        private readonly IChangeUserRole _changeUserRole;
        private readonly IDeleteUser _deleteUser;

        public StudentFactory(IChangeCourse changeCourse, IChangeTest changeTest, IChangeQuestion changeQuestion, IChangeUserRole changeUserRole, IDeleteUser deleteUser)
        {
            _changeCourse = changeCourse;
            _changeTest = changeTest;
            _changeQuestion = changeQuestion;
            _changeUserRole = changeUserRole;
            _deleteUser = deleteUser;
        }

        public override IChooseRole GetRole()
        {
            Student member = new(_changeCourse, _changeTest, _changeQuestion, _changeUserRole, _deleteUser);
            return member;
        }
    }
}
