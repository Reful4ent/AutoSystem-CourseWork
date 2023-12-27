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
        private IDataManager dataManager;
        private ILogInServices logInServices;
        private IChangeUserRepServices changeUserRepServices;
        private IChangeUserCourseServices changeUserCourseServices;
        private IRegistrationServices registrationServices;
        private ITestQuestionServices testQuestionServices;

        public ServiceManager(IDataManager dataManager, ILogInServices logInServices, IChangeUserRepServices changeUserRepServices, IChangeUserCourseServices changeUserCourseServices, IRegistrationServices registrationServices, ITestQuestionServices testQuestionServices)
        {
            this.logInServices = logInServices;
            this.changeUserRepServices = changeUserRepServices;
            this.changeUserCourseServices = changeUserCourseServices;
            this.registrationServices = registrationServices;
            this.testQuestionServices = testQuestionServices;
            this.dataManager = dataManager;
        }
        public static ServiceManager Instance(IDataManager dataManager,ILogInServices logInServices, IChangeUserRepServices changeUserRepServices, IChangeUserCourseServices changeUserCourseServices, IRegistrationServices registrationServices, ITestQuestionServices testQuestionServices) => new ServiceManager(dataManager, logInServices, changeUserRepServices, changeUserCourseServices, registrationServices, testQuestionServices);

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
            return changeUserRepServices.TryDeleteUser(number, dataManager);
        }

        public bool TryChangeUserRole(int number, int Role_Id)
        {
            return changeUserRepServices.TryChangeUserRole(number, Role_Id, dataManager);
        }
        public bool TryRegistration(string name, string login, string password, string passwordRepeat)
        {
            return registrationServices.TryRegistration(name, login, password, passwordRepeat, dataManager);
        }

        public List<ITest> GetTests(int number)
        {
            return testQuestionServices.GetTests(number, dataManager);
        }

        public List<IQuestion> GetQuestions(int numberCourse, int numberTest)
        {
            return testQuestionServices.GetQuestions(numberCourse, numberTest, dataManager);
        }
        public bool TryDeleteCourse(int number)
        {
            return testQuestionServices.DeleteCourse(number, dataManager);
        }

        public bool TryDeleteTest(ICourse course, int number)
        {
            return testQuestionServices.DeleteTest(course, number, dataManager);
        }

        public bool TryDeleteQuestion(ICourse course, ITest test, int number)
        {
            return testQuestionServices.DeleteQuestion(course, test, number, dataManager);
        }

        public bool TryAddCourse(string name, CourseTypeEnum courseTypeEnum)
        {
            return testQuestionServices.AddCourse(name, courseTypeEnum, dataManager);
        }
        public bool TryAddTest(int number, string name,string theory, CourseTypeEnum courseTypeEnum)
        {
            return testQuestionServices.AddTest(number, name, theory, courseTypeEnum, dataManager);
        }

        public bool TryAddAnswerQuestion(int numberCourse, int numberTest, string questionText, string answerText, CourseTypeEnum courseTypeEnum)
        {
            return testQuestionServices.AddQuestionAnswer(numberCourse, numberTest, questionText, answerText, courseTypeEnum, dataManager);
        }
        public bool TrySetCourse(int index)
        {
            return testQuestionServices.SetCourse(index, dataManager);
        }
    }
}
