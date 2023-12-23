﻿using AutoSystem_CourseWork_.Data.CoursesSerialization;
using AutoSystem_CourseWork_.Data.UserSerialization;
using AutoSystem_CourseWork_.Model;
using AutoSystem_CourseWork_.Model.Сourse;
using AutoSystem_CourseWork_.ViewModel.Services.AddCourseUserService;
using AutoSystem_CourseWork_.ViewModel.Services.ChangeUserRepService;
using AutoSystem_CourseWork_.ViewModel.Services.LogInService;
using AutoSystem_CourseWork_.ViewModel.Services.RegistrationService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.ViewModel.DataManager
{
     class DataManager : IDataManager
    {
        //Сервисы
        private LogInService logInService;
        private RegistrationService registrationService;
        private ChangeUserCourseService changeUserCourseService;
        private ChangeUserRepService changeUserRepService;

        private UserRepository userRepository;
        private CoursesRepository coursesRepository;
        private User particulalUser = null;

        public User ParticularUser => particulalUser;
        public UserRepository UserRepository => userRepository;
        public CoursesRepository CoursesRepository => coursesRepository;

        public DataManager(UserRepository userRepository, CoursesRepository coursesRepository)
        {
            this.userRepository = userRepository;
            this.coursesRepository = coursesRepository;
            this.logInService = new(this.userRepository);
            this.registrationService = new();
            this.changeUserCourseService = new();
            this.changeUserRepService = new();
        }
        public static DataManager Instance(UserRepository userRepository, CoursesRepository courseRepository) => new(userRepository, courseRepository);

        public async Task SaveAllUserAsync()
        {
            await userRepository.SaveAsync();
        }

        public async Task LoadAllUserAsync()
        {
            await userRepository.LoadAsync();
        }

        public async Task SaveAllCoursesAsync()
        {
            await coursesRepository.SaveAsync();
        }

        public async Task LoadAllCoursesAsync()
        {
            await coursesRepository.LoadAsync();
        }

        public bool TryLogIn(string login, string password)
        {
            return logInService.TryLogIn(login, password, ref particulalUser);
        }

        public bool TryRegistration(string name, string login, string password, string passwordRepeat)
        {
            return registrationService.TryRegistration(name, login, password, passwordRepeat,ref userRepository);
        }

        public bool TryAddUserCourse(ICourse course)
        {
            return changeUserCourseService.TryAddUserCourse(course, ref userRepository, ref particulalUser);
        }

        public bool TryRemoveUserCourse(int number)
        {
            return changeUserCourseService.TryRemoveUserCourse(number, ref userRepository, ref particulalUser);
        }

        public bool TryDeleteUser(int number)
        {
            return changeUserRepService.TryDeleteUser(number, ref userRepository, ref particulalUser);
        }

        public bool TryChangeUserRole(int number, int Role_Id)
        {
            return changeUserRepService.TryChangeUserRole(number,Role_Id, ref userRepository, ref particulalUser);
        }
    }
}
