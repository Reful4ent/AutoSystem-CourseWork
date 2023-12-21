using AutoSystem_CourseWork_.Model.Possibilities.Interfaces;
using AutoSystem_CourseWork_.Model.Сourse;
using AutoSystem_CourseWork_.Model.Сourse.Test.Answers;
using AutoSystem_CourseWork_.Model.Сourse.Test.Questions;
using AutoSystem_CourseWork_.Model.Сourse.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.Model.ForFabric_Roles_
{
    public class Admin : IChooseRole
    {
        private IChangeCourse _changeCourse;
        private IChangeTest _changeTest;
        private IChangeQuestion _changeQuestion;
        private IChangeUserRole _changeUserRole;
        private IDeleteUser _deleteUser;

        public Admin(IChangeCourse changeCourse, IChangeTest changeTest, IChangeQuestion changeQuestion, IChangeUserRole changeUserRole, IDeleteUser deleteUser)
        {
            _changeCourse = changeCourse;
            _changeTest = changeTest;
            _changeQuestion = changeQuestion;
            _changeUserRole = changeUserRole;
            _deleteUser = deleteUser;
        }

        public bool AddTest(ICourse course, ITest test)
        {
            return _changeTest.AddTest(course, test);
        }

        public bool DeleteTest(ICourse course, int num)
        {
            return _changeTest.DeleteTest(course, num);
        }

        public bool AddQuestionAndAnswer(ITest test, IQuestion question, IAnswer answer)
        {
            return _changeQuestion.AddQuestionAndAnswer(test, question, answer);
        }

        public bool DeleteQuestionAndAnswer(ITest test, int number)
        {
            return _changeQuestion.DeleteQuestionAndAnswer(test, number);
        }
        public List<User> ChangeUserRole(List<User> users, int number, int Role_Id)
        {
            return _changeUserRole.ChangeUserRole(users, number, Role_Id);
        }

        public List<User> DeleteUser(List<User> users, int number)
        {
            return _deleteUser.DeleteUser(users, number);
        }

        public bool AddCourse(List<ICourse> courses, ICourse course)
        {
            return _changeCourse.AddCourse(courses, course);
        }

        public bool DeleteCourse(List<ICourse> courses, int number)
        {
            return _changeCourse.DeleteCourse(courses, number);
        }
    }
}
