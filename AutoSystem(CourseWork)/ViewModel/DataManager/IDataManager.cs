﻿using AutoSystem_CourseWork_.Data.CoursesSerialization;
using AutoSystem_CourseWork_.Data.UserSerialization;
using AutoSystem_CourseWork_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.ViewModel.DataManager
{
    internal interface IDataManager
    {
        public User ParticularUser { get; }
        public UserRepository UserRepository { get; }
        public CoursesRepository CoursesRepository { get; }

        public Task SaveAllUserAsync();
        public Task LoadAllUserAsync();

        public Task SaveAllCoursesAsync();
        public Task LoadAllCoursesAsync();

    }
}
