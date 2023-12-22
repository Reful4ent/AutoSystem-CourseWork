﻿using AutoSystem_CourseWork_.Data.CoursesSerialization;
using AutoSystem_CourseWork_.Data.UserSerialization;
using AutoSystem_CourseWork_.View;
using AutoSystem_CourseWork_.ViewModel.DataManager;
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
        private UserRepository userRepository;
        private CoursesRepository coursesRepository;
        public App() : base()
        {
            string pathUsers = ConfigurationManager.AppSettings["Userpath"] ?? string.Empty;
            string pathCourses = ConfigurationManager.AppSettings["Coursespath"] ?? string.Empty;
            userRepository = new UserRepository(pathUsers);
            coursesRepository = new CoursesRepository(pathCourses);
            _dataManager = DataManager.Instance(userRepository, coursesRepository);
        }
        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            await _dataManager.LoadAllUserAsync();
            await _dataManager.LoadAllCoursesAsync();

            LogInWindow logInWindow = new LogInWindow(_dataManager);
            logInWindow.Show();
        }
    }

}
