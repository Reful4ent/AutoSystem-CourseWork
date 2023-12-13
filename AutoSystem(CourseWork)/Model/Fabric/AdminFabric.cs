using AutoSystem_CourseWork_.Model.ForFabric_Roles_;
using AutoSystem_CourseWork_.Model.Possibilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.Model.Fabric
{
    internal class AdminFabric : MyRoleFabric
    {
        private readonly IAnswerQuestion _answerQuestion;
        private readonly IChangeUserCourse _changeUserCourse;
        private readonly IChangeCourse _changeCourse;
        private readonly IChangeTest _changeTest;
        private readonly IChangeQuestion _changeQuestion;
        private readonly IChangeAnswer _changeAnswer;
        private readonly IChangeUserRole _changeUserRole;
        private readonly IDeleteUser _deleteUser;

        public AdminFabric(IAnswerQuestion answerQuestion, IChangeUserCourse changeUserCourse, IChangeCourse changeCourse, IChangeTest changeTest, IChangeQuestion changeQuestion, IChangeAnswer changeAnswer, IChangeUserRole changeUserRole, IDeleteUser deleteUser)
        {
            _answerQuestion = answerQuestion;
            _changeUserCourse = changeUserCourse;
            _changeCourse = changeCourse;
            _changeTest = changeTest;
            _changeQuestion = changeQuestion;
            _changeAnswer = changeAnswer;
            _changeUserRole = changeUserRole;
            _deleteUser = deleteUser;
        }

        public override IChooseRole GetRole()
        {
            Admin member = new(_answerQuestion, _changeUserCourse, _changeCourse, _changeTest, _changeQuestion, _changeAnswer, _changeUserRole, _deleteUser);
            return member;
        }
    }
}
