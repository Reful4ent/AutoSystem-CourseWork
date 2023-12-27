using AutoSystem_CourseWork_.Model.Сourse;
using AutoSystem_CourseWork_.ViewModel.DataManager;
using AutoSystem_CourseWork_.ViewModel.Roles;
using AutoSystem_CourseWork_.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AutoSystem_CourseWork_.ViewModel.Services;

namespace AutoSystem_CourseWork_.ViewModel
{
    public class MainVM : BasicVM
    {
        IDataManager dataManager;
        IServiceManager serviceManager;

        private string name = string.Empty;
        private string role = string.Empty;
        private int role_Id;
        private ObservableCollection<ICourse> courses;
        private int index;

        public event Action? DeleteSucces;
        public event Action<string>? DeleteFailed;
        public event Action? SetCourseSucces;

        public MainVM(IDataManager dataManager,IServiceManager serviceManager)
        {
            this.dataManager = dataManager;
            this.serviceManager = serviceManager;
            Name = this.dataManager.ParticularUser.Name;
            Role_Id = this.dataManager.ParticularUser.Role_Id;
            Role = UserRole.GetName(typeof(UserRole), (UserRole)(this.dataManager.ParticularUser.Role_Id));
            Courses = new ObservableCollection<ICourse>(this.dataManager.ParticularUser.Courses);
        }

        public string Name
        {
            get => name;
            set => Set(ref name, value);
        }

        public string Role
        {
            get => role;
            set => Set(ref role, value);
        }

        public int Role_Id
        {
            get=> role_Id;
            set=> Set(ref role_Id, value);
        }

        public ObservableCollection<ICourse> Courses
        {
            get => courses;
            set => Set(ref courses, value);
        }

        public int Index
        {
            get => index;
            set => Set(ref index, value);
        }

        public void RefreshCourses()
        {
            Courses = new ObservableCollection<ICourse>(this.dataManager.ParticularUser.Courses);
        }

        private void DeleteUserCourse()
        {
            if (serviceManager.TryRemoveUserCourse(Index))
            {
                DeleteSucces?.Invoke();
            }
            else
            {
                DeleteFailed?.Invoke("Не удалось удалить курс!");
            }
        }
        
        private void SetCourse()
        {
            if (serviceManager.TrySetCourse(Index))
            {
                SetCourseSucces?.Invoke();
            }
        }

        public ICommand SetCourseCommand
        {
            get
            {
                return new Command(() =>
                {
                    SetCourse();
                });
            }
        }
        public ICommand DeleteCourseCommand
        {
            get
            {
                return new Command(() =>
                {
                    DeleteUserCourse();
                });
            }
        }
    }
}
