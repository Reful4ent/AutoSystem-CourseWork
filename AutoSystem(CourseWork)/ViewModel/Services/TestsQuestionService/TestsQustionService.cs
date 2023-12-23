using AutoSystem_CourseWork_.Data.CoursesSerialization;
using AutoSystem_CourseWork_.Model.Сourse.Test;
using AutoSystem_CourseWork_.Model.Сourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSystem_CourseWork_.Model.Сourse.Test.Questions;

namespace AutoSystem_CourseWork_.ViewModel.Services.TestsService
{
    internal class TestsQustionService : ITestQuestionService
    {
        public List<ITest> GetTests(int number,ref CoursesRepository coursesRepository)
        {
            List<Course> courses = coursesRepository.GetCourses();
            List<ITest> tests = new List<ITest>();
            for (int i = 0; i < courses[number].Tests.Count; i++) 
            {
                tests.Add(courses[number].Tests[i]);
            }
            return tests;
        }
        public List<IQuestion> GetQuestions(int numberCourse, int numberTest, ref CoursesRepository coursesRepository)
        {
            List<Course> courses = coursesRepository.GetCourses();
            List<ITest> tests = courses[numberCourse].Tests;
            List<IQuestion> questions = new List<IQuestion>();
            for(int i = 0;i < tests[numberTest].questions.Count;i++) 
            {
                questions.Add(tests[numberTest].questions[i]);
            }
            return questions;
        }
    }
}
