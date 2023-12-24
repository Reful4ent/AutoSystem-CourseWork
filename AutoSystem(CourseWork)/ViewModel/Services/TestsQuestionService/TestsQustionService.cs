using AutoSystem_CourseWork_.Data.CoursesSerialization;
using AutoSystem_CourseWork_.Model.Сourse.Test;
using AutoSystem_CourseWork_.Model.Сourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSystem_CourseWork_.Model.Сourse.Test.Questions;
using AutoSystem_CourseWork_.Model;
using AutoSystem_CourseWork_.Model.Сourse.Test.Answers;
using static System.Net.Mime.MediaTypeNames;

namespace AutoSystem_CourseWork_.ViewModel.Services.TestsService
{
    internal class TestsQustionService : ITestQuestionService
    {
        public List<ITest> GetTests(int number,ref CoursesRepository coursesRepository)
        {
            List<ICourse> courses = coursesRepository.GetCourses();
            List<ITest> tests = new List<ITest>();
            if (courses.Count == 0 || number >= courses.Count || number < 0) return tests;
            for (int i = 0; i < courses[number].Tests.Count; i++) 
            {
                tests.Add(courses[number].Tests[i]);
            }
            return tests;
        }
        public List<IQuestion> GetQuestions(int numberCourse, int numberTest, ref CoursesRepository coursesRepository)
        {
            List<IQuestion> questions = new List<IQuestion>();
            List<ICourse> courses = coursesRepository.GetCourses();
            if (courses.Count == 0 || numberCourse >= courses.Count || numberCourse < 0) return questions;
            List<ITest> tests = courses[numberCourse].Tests;
            if (tests.Count == 0 || numberTest >= tests.Count || numberTest<0) return questions;
            for (int i = 0;i < tests[numberTest].questions.Count;i++) 
            {
                questions.Add(tests[numberTest].questions[i]);
            }
            return questions;
        }

        public bool DeleteCourse(int number, ref CoursesRepository coursesRepository, ref User ParticularUser)
        {
            if (!ParticularUser.DeleteCourse(coursesRepository.GetCourses(),number)) return false;
            coursesRepository.Save();
            return true;
        }

        public bool DeleteTest(ICourse course, int number, ref CoursesRepository coursesRepository, ref User ParticularUser)
        {
            if(!ParticularUser.DeleteTest(course,number)) return false;
            if(!coursesRepository.Update(course)) return false;
            coursesRepository.Save();
            return true;
        }

        public bool DeleteQuestion(ICourse course, ITest test, int number, ref CoursesRepository coursesRepository, ref User ParticularUser)
        {
            if (!ParticularUser.DeleteQuestionAndAnswer(course.Tests[course.Tests.IndexOf(test)],number)) return false;
            if (!coursesRepository.Update(course)) return false;
            coursesRepository.Save();
            return true;
        }

        public bool AddCourse(string name, CourseTypeEnum courseTypeEnum, ref CoursesRepository coursesRepository, ref User ParticularUser)
        {
            if (String.IsNullOrEmpty(name)) return false;
            List<ITest> tests = new List<ITest>();
            Course course = new(Guid.NewGuid(),name,ParticularUser.Name,courseTypeEnum,tests);
            if (!coursesRepository.Add(course)) return false;
            coursesRepository.Save();
            return true;
        }
        public bool AddTest(int number, string name,CourseTypeEnum courseTypeEnum, ref CoursesRepository coursesRepository, ref User ParticularUser)
        {
            if (String.IsNullOrEmpty(name)) return false;
            List<ICourse> courses = coursesRepository.GetCourses();
            List<IQuestion> questions = new List<IQuestion>();
            List<IAnswer> answers = new List<IAnswer>();
            if (courses.Count == 0 || number >= courses.Count || number < 0) return false;
            TestOfCourse test = new(Guid.NewGuid(), name, courseTypeEnum, answers, questions);
            if (!ParticularUser.AddTest(courses[number], test)) return false;
            if (!coursesRepository.Update(courses[number])) return false;
            coursesRepository.Save();
            return true;

        }
    }
}
