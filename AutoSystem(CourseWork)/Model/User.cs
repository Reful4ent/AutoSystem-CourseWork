using AutoSystem_CourseWork_.Model.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSystem_CourseWork_.Model.ForFabric_Roles_;
using AutoSystem_CourseWork_.Model.Fabric;
using AutoSystem_CourseWork_.Model.Сourse;
using AutoSystem_CourseWork_.Model.Possibilities.Interfaces;
using AutoSystem_CourseWork_.Model.Сourse.Test.Answers;
using AutoSystem_CourseWork_.Model.Сourse.Test.Questions;
using AutoSystem_CourseWork_.Model.Сourse.Test;

namespace AutoSystem_CourseWork_.Model
{
    public class User : IEntity
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Login { get; }
        public string Password { get; }
        public int Role_Id { get; set; }
        private IChooseRole Role { get; set; }
        public List<ICourse> Courses { get; set; }

        public User(Guid Id, string Name, string Login, string Password, int Role_Id, List<ICourse> Courses)
        {
            this.Id = Id;
            this.Name = Name;
            this.Login = Login;
            this.Password = Password;
            this.Role_Id = Role_Id;
            this.Role = ReturnRole.chooseRole(this.Role_Id);
            this.Courses = Courses;
        }
        public bool AnswerQuestion(IAnswer answer, IQuestion question, string myAnswer)
        {
            if (answer == null || question == null) return false;
            if (!(answer.Id == question.Id)) return false;
            if (answer.Text != myAnswer) return false;
            return true;
        }
        public bool AddMeCourse(ICourse course)
        {
            if (course == null) return false;
            var CheckSimilary = from selectCourse in Courses
                                where (course.Id == selectCourse.Id || (course.Name == selectCourse.Name && course.AuthorName == selectCourse.AuthorName))
                                select course;
            if (CheckSimilary.Count() != 0) return false;
            Courses.Add(course);
            return true;
        }

        public bool RemoveMeCourse(int number)
        {
            if (number >= Courses.Count || number < 0) return false;
            Courses.RemoveAt(number); return true;
        }

        public bool AddQuestionAndAnswer(ITest test, IQuestion question, IAnswer answer)
        {
            return Role.AddQuestionAndAnswer(test, question, answer);
        }

        public bool DeleteQuestionAndAnswer(ITest test, int number)
        {
            return Role.DeleteQuestionAndAnswer(test, number);
        }

        public List<User> DeleteUser(List<User> users, int number)
        {
            return Role.DeleteUser(users, number);
        }
        public List<User> ChangeUserRole(List<User> users, int number, int Role_Id)
        {
            return Role.ChangeUserRole(users, number, Role_Id);
        }

        public bool AddCourse(List<ICourse> courses, ICourse course)
        {
            return Role.AddCourse(courses, course);
        }

        public bool DeleteCourse(List<ICourse> courses, int number)
        {
            return Role.DeleteCourse(courses, number);
        }

        public bool AddTest(ICourse course, ITest test)
        {
            return Role.AddTest(course, test);
        }

        public bool DeleteTest(ICourse course, int num)
        {
            return Role.DeleteTest(course, num);
        }
    }
}
