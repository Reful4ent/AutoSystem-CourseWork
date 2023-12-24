using AutoSystem_CourseWork_.Model;
using AutoSystem_CourseWork_.Model.Basic;
using AutoSystem_CourseWork_.Model.Сourse;
using AutoSystem_CourseWork_.ViewModel.DataManager;
using AutoSystem_CourseWork_.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AutoSystem_CourseWork_.ViewModel.Services;

namespace AutoSystem_CourseWork_.ViewModel
{
    public class ChangeUserRepositoryVM : BasicVM
    {
        IDataManager dataManager;
        IServiceManager serviceManager;

        private ObservableCollection<User> userList;
        private int index;
        private int role_Id;

        public event Action? DeleteSucces;
        public event Action<string>? DeleteFailed;

        public event Action? ChangeRoleSucces;
        public event Action<string>? ChangeRoleFailed;

        public ChangeUserRepositoryVM(IDataManager dataManager, IServiceManager serviceManager)
        {
            this.dataManager = dataManager;
            this.serviceManager = serviceManager;
            UserList = new ObservableCollection<User>(this.dataManager.UserRepository.GetUsers());
        }

        public ObservableCollection<User> UserList
        {
            get => userList;
            set => Set(ref userList, value);
        }
        public int Index
        {
            get => index;
            set => Set(ref index, value);
        }

        public int Role_Id
        {
            get => role_Id;
            set => Set(ref role_Id, value);
        }

        public void RefreshCourses()
        {
            UserList = new ObservableCollection<User>(this.dataManager.UserRepository.GetUsers());
        }

        private void DeleteUser()
        {
            if (serviceManager.TryDeleteUser(Index))
            {
                DeleteSucces?.Invoke();
            }
            else
            {
                DeleteFailed?.Invoke("Пользователя нет или отсутствуют права доступа!");
            }
        }

        private void ChangeUserRole()
        {
            if (serviceManager.TryChangeUserRole(Index, Role_Id))
            {
                ChangeRoleSucces?.Invoke();
            }
            else
            {
                ChangeRoleFailed?.Invoke("Неверно введена роль или отсутствую права доступа!");
            }
        }

        public ICommand DeleteUserCommand
        {
            get
            {
                return new Command(() =>
                {
                    DeleteUser();
                });
            }
        }

        public ICommand ChangeUserRoleCommand
        {
            get
            {
                return new Command(() =>
                {
                    ChangeUserRole();
                });
            }
        }
    }
}
