using AutoSystem_CourseWork_.Data.CoursesSerialization;
using AutoSystem_CourseWork_.Data.UserSerialization;
using AutoSystem_CourseWork_.Model;
using AutoSystem_CourseWork_.Model.Сourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.ViewModel.DataManager
{
    public interface IDataManager
    {
        public User ParticularUser { get; }
        public UserRepository UserRepository { get; }
        public CoursesRepository CoursesRepository { get; }

        public Task SaveAllUserAsync();
        public Task LoadAllUserAsync();

        public Task SaveAllCoursesAsync();
        public Task LoadAllCoursesAsync();
        public bool TryLogIn(string login, string password);
        public bool TryRegistration(string name, string login, string password, string passwordRepeat);
        public bool TryAddUserCourse(ICourse course);
        public bool TryRemoveUserCourse(int number);
        public bool TryDeleteUser(int number);
        public bool TryChangeUserRole(int number, int Role_Id);
    }
}
