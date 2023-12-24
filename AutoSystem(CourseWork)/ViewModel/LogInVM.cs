using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AutoSystem_CourseWork_.ViewModel.DataManager;
using AutoSystem_CourseWork_.ViewModel.Commands;
using AutoSystem_CourseWork_.ViewModel.Services.LogInService;
using AutoSystem_CourseWork_.ViewModel.Services;
using AutoSystem_CourseWork_.Data.UserSerialization;

namespace AutoSystem_CourseWork_.ViewModel
{
    public class LogInVM : BasicVM
    {
        string login = string.Empty;
        string password = string.Empty;
        private IDataManager dataManager;
        private IServiceManager serviceManager;

        public event Action? LogInSucces;
        public event Action<string>? LogInFailed;

        public LogInVM(IDataManager dataManager, IServiceManager serviceManager)
        {
            this.dataManager = dataManager;
            this.serviceManager = serviceManager;
        }
        public string Login
        {
            get => login;
            set => Set(ref login, value);
        }

        public string Password
        {
            get => password;
            set => Set(ref password, value);
        }

        private void StartLogIn()
        {
            if(serviceManager.TryLogIn(Login,Password))
            {
                LogInSucces?.Invoke();
            }
            else
            {
                LogInFailed?.Invoke("Неверный ввод или такого пользователя нет!");
            }
        }

        public ICommand StartLogInCommand
        {
            get
            {
                return new Command(() =>
                {
                    StartLogIn();
                });
            }
        }

    }
}
