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
using AutoSystem_CourseWork_.ViewModel.DataManager;
using AutoSystem_CourseWork_.ViewModel.Services.RegistrationService;

namespace AutoSystem_CourseWork_.ViewModel.Services.TestsService
{
    public class TestsQustionServices : ITestQuestionServices
    {
        public static TestsQustionServices Instance() => new();
        public List<ITest> GetTests(int number,IDataManager dataManager)
        {
            List<ICourse> courses = dataManager.CoursesRepository.GetCourses();
            List<ITest> tests = new List<ITest>();
            if (courses.Count == 0 || number >= courses.Count || number < 0) return tests;
            for (int i = 0; i < courses[number].Tests.Count; i++) 
            {
                tests.Add(courses[number].Tests[i]);
            }
            return tests;
        }
        public List<IQuestion> GetQuestions(int numberCourse, int numberTest, IDataManager dataManager)
        {
            List<IQuestion> questions = new List<IQuestion>();
            List<ICourse> courses = dataManager.CoursesRepository.GetCourses();
            if (courses.Count == 0 || numberCourse >= courses.Count || numberCourse < 0) return questions;
            List<ITest> tests = courses[numberCourse].Tests;
            if (tests.Count == 0 || numberTest >= tests.Count || numberTest<0) return questions;
            for (int i = 0;i < tests[numberTest].questions.Count;i++) 
            {
                questions.Add(tests[numberTest].questions[i]);
            }
            return questions;
        }

        public bool DeleteCourse(int number, IDataManager dataManager)
        {
            if (!dataManager.ParticularUser.DeleteCourse(dataManager.CoursesRepository.GetCourses(),number)) return false;
            dataManager.CoursesRepository.Save();
            return true;
        }

        public bool DeleteTest(ICourse course, int number, IDataManager dataManager)
        {
            if(!dataManager.ParticularUser.DeleteTest(course,number)) return false;
            if(!dataManager.CoursesRepository.Update(course)) return false;
            dataManager.CoursesRepository.Save();
            return true;
        }

        public bool DeleteQuestion(ICourse course, ITest test, int number, IDataManager dataManager)
        {
            if (!dataManager.ParticularUser.DeleteQuestionAndAnswer(course.Tests[course.Tests.IndexOf(test)],number)) return false;
            if (!dataManager.CoursesRepository.Update(course)) return false;
            dataManager.CoursesRepository.Save();
            return true;
        }

        public bool AddCourse(string name, CourseTypeEnum courseTypeEnum, IDataManager dataManager)
        {
            List<ITest> tests = new List<ITest>();
            Course course;
            try
            {
                course = new(Guid.NewGuid(), name, dataManager.ParticularUser.Name, courseTypeEnum, tests);
            }
            catch (Exception ex)
            {
                return false;
            }
            if (!dataManager.CoursesRepository.Add(course)) return false;
            dataManager.CoursesRepository.Save();
            return true;
        }
        public bool AddTest(int number, string name,string theory,CourseTypeEnum courseTypeEnum, IDataManager dataManager)
        {
            List<ICourse> courses = dataManager.CoursesRepository.GetCourses();
            List<IQuestion> questions = new List<IQuestion>();
            List<IAnswer> answers = new List<IAnswer>();
            if (courses.Count == 0 || number >= courses.Count || number < 0) return false;
            TestOfCourse test;
            try
            {
                test = new(Guid.NewGuid(), name, theory, courseTypeEnum, answers, questions);
            }
            catch (Exception ex)
            {
                return false;
            }
            if (!dataManager.ParticularUser.AddTest(courses[number], test)) return false;
            if (!dataManager.CoursesRepository.Update(courses[number])) return false;
            dataManager.CoursesRepository.Save();
            return true;
        }

        public bool AddQuestionAnswer(int numberCourse, int numberTest,string questionText,string answerText, CourseTypeEnum courseTypeEnum, IDataManager dataManager)
        {
            List<ICourse> courses = dataManager.CoursesRepository.GetCourses();
            if (courses.Count == 0 || numberCourse >= courses.Count || numberCourse < 0) return false;
            List<ITest> tests = courses[numberCourse].Tests;
            if (tests.Count == 0 || numberTest >= tests.Count || numberTest < 0) return false;
            Guid AnswerQuestionId = Guid.NewGuid();
            TextAnswer textAnswer;
            try
            {
                textAnswer = new(AnswerQuestionId, answerText, courseTypeEnum);
            }
            catch (Exception ex)
            {
                return false;
            }
            TextQuestion textQuestion;
            try
            {
                textQuestion = new(AnswerQuestionId, questionText, courseTypeEnum);
            }
            catch (Exception ex)
            {
                return false;
            }
            if (!dataManager.ParticularUser.AddQuestionAndAnswer(tests[numberTest], textQuestion, textAnswer)) return false;
            if (!dataManager.CoursesRepository.Update(courses[numberCourse])) return false;
            dataManager.CoursesRepository.Save();
            return true;
        }

        public bool SetCourse(int index, IDataManager dataManager)
        {
            dataManager.ParticularCurse = dataManager.ParticularUser.Courses[index];
            if (dataManager.ParticularCurse == null) return false;
            return true;
        }

        public bool SetTest(int indexTest, IDataManager dataManager)
        {
            if (dataManager.ParticularCurse.Tests.Count == 0 || dataManager.ParticularCurse.Tests == null) return false; 
            dataManager.ParticularTest = dataManager.ParticularCurse.Tests[indexTest];
            if(dataManager.ParticularTest == null) return false;
            return true;
        }
    }
}
