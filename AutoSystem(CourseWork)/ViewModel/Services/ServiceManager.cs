using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSystem_CourseWork_.Model;
using AutoSystem_CourseWork_.ViewModel.Services.AddCourseUserService;
using AutoSystem_CourseWork_.ViewModel.Services.ChangeUserRepService;
using AutoSystem_CourseWork_.ViewModel.Services.LogInService;
using AutoSystem_CourseWork_.ViewModel.Services.RegistrationService;
using AutoSystem_CourseWork_.ViewModel.Services.TestsService;
using AutoSystem_CourseWork_.Data.UserSerialization;
using AutoSystem_CourseWork_.Model.Сourse;
using AutoSystem_CourseWork_.Data.CoursesSerialization;
using AutoSystem_CourseWork_.Model.Сourse.Test.Questions;
using AutoSystem_CourseWork_.Model.Сourse.Test;
using AutoSystem_CourseWork_.ViewModel.DataManager;

namespace AutoSystem_CourseWork_.ViewModel.Services
{
    class ServiceManager : IServiceManager
    {
        IDataManager dataManager;
        private LogInServices logInServices;
        private ChangeUserRepServices changeUserRepService;
        private ChangeUserCourseServices changeUserCourseServices;
        private RegistrationServices registrationServices;
        private TestsQustionServices testsQustionServices;

        public ServiceManager(IDataManager dataManager)
        {
            logInServices = new LogInServices();
            changeUserRepService = new ChangeUserRepServices();
            changeUserCourseServices = new ChangeUserCourseServices();
            registrationServices = new RegistrationServices();
            testsQustionServices = new TestsQustionServices();
            this.dataManager = dataManager;
        }
        public static ServiceManager Instance(IDataManager dataManager) => new ServiceManager(dataManager);

        public bool TryLogIn(string login, string password)
        {
            return logInServices.TryLogIn(login, password, dataManager);
        }

        public bool TryAddUserCourse(ICourse course)
        {
            return changeUserCourseServices.TryAddUserCourse(course, dataManager);
        }

        public bool TryRemoveUserCourse(int number)
        {
            return changeUserCourseServices.TryRemoveUserCourse(number, dataManager);
        }

        public bool TryDeleteUser(int number)
        {
            return changeUserRepService.TryDeleteUser(number, dataManager);
        }

        public bool TryChangeUserRole(int number, int Role_Id)
        {
            return changeUserRepService.TryChangeUserRole(number, Role_Id, dataManager);
        }
        public bool TryRegistration(string name, string login, string password, string passwordRepeat)
        {
            return registrationServices.TryRegistration(name, login, password, passwordRepeat, dataManager);
        }

        public List<ITest> GetTests(int number)
        {
            return testsQustionServices.GetTests(number, dataManager);
        }

        public List<IQuestion> GetQuestions(int numberCourse, int numberTest)
        {
            return testsQustionServices.GetQuestions(numberCourse, numberTest, dataManager);
        }
        public bool TryDeleteCourse(int number)
        {
            return testsQustionServices.DeleteCourse(number, dataManager);
        }

        public bool TryDeleteTest(ICourse course, int number)
        {
            return testsQustionServices.DeleteTest(course, number, dataManager);
        }

        public bool TryDeleteQuestion(ICourse course, ITest test, int number)
        {
            return testsQustionServices.DeleteQuestion(course, test, number, dataManager);
        }

        public bool TryAddCourse(string name, CourseTypeEnum courseTypeEnum)
        {
            return testsQustionServices.AddCourse(name, courseTypeEnum, dataManager);
        }
        public bool TryAddTest(int number, string name, CourseTypeEnum courseTypeEnum)
        {
            return testsQustionServices.AddTest(number, name, courseTypeEnum, dataManager);
        }

        public bool TryAddAnswerQuestion(int numberCourse, int numberTest, string questionText, string answerText, CourseTypeEnum courseTypeEnum)
        {
            return testsQustionServices.AddQuestionAnswer(numberCourse, numberTest, questionText, answerText, courseTypeEnum, dataManager);
        }
    }
}
