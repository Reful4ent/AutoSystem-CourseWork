using AutoSystem_CourseWork_.ViewModel.Commands;
using AutoSystem_CourseWork_.ViewModel.DataManager;
using AutoSystem_CourseWork_.ViewModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AutoSystem_CourseWork_.ViewModel
{
    public class RegistrationVM : BasicVM
    {
        IDataManager dataManager;
        IServiceManager serviceManager;

        string name = string.Empty;
        string login = string.Empty;
        string password = string.Empty;
        string passwordRepeat = string.Empty;

        public event Action? RegistrationSucces;
        public event Action<string>? RegistrationFailed;

        public RegistrationVM(IDataManager dataManager,IServiceManager serviceManager)
        {
            this.dataManager = dataManager;
            this.serviceManager = serviceManager;
        }

        public string Name
        {
            get => name;
            set => Set(ref name, value);
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

        public string PasswordRepeat
        {
            get => passwordRepeat;
            set => Set(ref passwordRepeat, value);
        }

        private void StartRegistr()
        {
            if (serviceManager.TryRegistration(Name,Login,Password,PasswordRepeat))
            {
                serviceManager.TryLogIn(Login, Password);
                RegistrationSucces?.Invoke();
            }
            else
            {
                RegistrationFailed?.Invoke("Неверно введенные данные или такой пользователь уже есть!");
            }
        }

        public ICommand StartRegistrCommand
        {
            get
            {
                return new Command(() =>
                {
                    StartRegistr();
                });
            }
        }
    }
}
