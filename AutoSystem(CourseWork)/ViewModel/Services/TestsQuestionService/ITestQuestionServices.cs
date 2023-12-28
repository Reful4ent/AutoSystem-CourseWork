using AutoSystem_CourseWork_.Model.Сourse;
using AutoSystem_CourseWork_.Model.Сourse.Test;
using AutoSystem_CourseWork_.Model.Сourse.Test.Questions;
using AutoSystem_CourseWork_.ViewModel.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.ViewModel.Services.TestsService
{
    public interface ITestQuestionServices
    {
        public List<ITest> GetTests(int number, IDataManager dataManager);
        public List<IQuestion> GetQuestions(int numberCourse, int numberTest, IDataManager dataManager);
        public bool DeleteCourse(int number, IDataManager dataManager);
        public bool DeleteTest(ICourse course, int number, IDataManager dataManager);
        public bool DeleteQuestion(ICourse course, ITest test, int number, IDataManager dataManager);
        public bool AddCourse(string name, CourseTypeEnum courseTypeEnum, IDataManager dataManager);
        public bool AddTest(int number, string name, string theory, CourseTypeEnum courseTypeEnum, IDataManager dataManager);
        public bool AddQuestionAnswer(int numberCourse, int numberTest, string questionText, string answerText, CourseTypeEnum courseTypeEnum, IDataManager dataManager);
        public bool SetCourse(int index, IDataManager dataManager);
        public bool SetTest(int indexTest, IDataManager dataManager);
        public List<ICourse> CheckUpdates(IDataManager dataManager);
    }
}
