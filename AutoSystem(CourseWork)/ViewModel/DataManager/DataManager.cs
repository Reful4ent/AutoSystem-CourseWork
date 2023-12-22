using AutoSystem_CourseWork_.Data.CoursesSerialization;
using AutoSystem_CourseWork_.Data.UserSerialization;
using AutoSystem_CourseWork_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.ViewModel.DataManager
{
    internal class DataManager : IDataManager
    {
        private readonly UserRepository userRepository;
        private readonly CoursesRepository coursesRepository;
        private User particulalUser = null;

        public User ParticularUser => particulalUser;
        public UserRepository UserRepository => userRepository;
        public CoursesRepository CoursesRepository => coursesRepository;

        public DataManager(UserRepository userRepository, CoursesRepository coursesRepository)
        {
            this.userRepository = userRepository;
            this.coursesRepository = coursesRepository;
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
    }
}
