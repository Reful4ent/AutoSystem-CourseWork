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
    }
}
