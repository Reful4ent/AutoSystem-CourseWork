using AutoSystem_CourseWork_.Model.Possibilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.Model.ForFabric_Roles_
{
    public class Student : IChooseRole
    {
        private IAnswerQuestion _answerQuestion;
        private IChangeUserCourse _changeUserCourse;
        private IChangeCourse _changeCourse;
        private IChangeTest _changeTest;
        private IChangeQuestion _changeQuestion;
        private IChangeAnswer _changeAnswer;
        private IChangeUserRole _changeUserRole;
        private IDeleteUser _deleteUser;

        public Student(IAnswerQuestion answerQuestion, IChangeUserCourse changeUserCourse, IChangeCourse changeCourse, IChangeTest changeTest, IChangeQuestion changeQuestion, IChangeAnswer changeAnswer, IChangeUserRole changeUserRole, IDeleteUser deleteUser)
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
        //public bool ChangeUserRole(int Role_Id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
