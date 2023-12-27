using AutoSystem_CourseWork_.Data.CoursesSerialization;
using AutoSystem_CourseWork_.Data.UserSerialization;
using AutoSystem_CourseWork_.View;
using AutoSystem_CourseWork_.ViewModel.DataManager;
using AutoSystem_CourseWork_.ViewModel.Services;
using AutoSystem_CourseWork_.ViewModel.Services.AddCourseUserService;
using AutoSystem_CourseWork_.ViewModel.Services.ChangeUserRepService;
using AutoSystem_CourseWork_.ViewModel.Services.LogInService;
using AutoSystem_CourseWork_.ViewModel.Services.RegistrationService;
using AutoSystem_CourseWork_.ViewModel.Services.TestsService;
using System.Configuration;
using System.Data;
using System.Windows;

namespace AutoSystem_CourseWork_
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IDataManager _dataManager;
        private IServiceManager _serviceManager;
        private ILogInServices logInServices;
        private IChangeUserRepServices changeUserRepServices;
        private IChangeUserCourseServices changeUserCourseServices;
        private IRegistrationServices registrationServices;
        private ITestQuestionServices testQuestionServices;

        private UserRepository userRepository;
        private CoursesRepository coursesRepository;
        
        public App() : base()
        {
            string pathUsers = ConfigurationManager.AppSettings["Userpath"] ?? string.Empty;
            string pathCourses = ConfigurationManager.AppSettings["Coursespath"] ?? string.Empty;
            userRepository = new UserRepository(pathUsers);
            coursesRepository = new CoursesRepository(pathCourses);

            _dataManager = DataManager.Instance(userRepository, coursesRepository);
            logInServices = LogInServices.Instance();
            changeUserRepServices = ChangeUserRepServices.Instance();
            changeUserCourseServices = ChangeUserCourseServices.Instance();
            registrationServices = RegistrationServices.Instance();
            testQuestionServices = TestsQustionServices.Instance();
            _serviceManager = ServiceManager.Instance(_dataManager,logInServices,changeUserRepServices,changeUserCourseServices,registrationServices,testQuestionServices);
        }
        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            await _dataManager.LoadAllUserAsync();
            await _dataManager.LoadAllCoursesAsync();

            LogInWindow logInWindow = new LogInWindow(_dataManager,_serviceManager);
            logInWindow.Show();
        }
    }

}
