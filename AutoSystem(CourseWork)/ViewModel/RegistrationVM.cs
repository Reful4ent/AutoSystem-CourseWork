using AutoSystem_CourseWork_.ViewModel.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.ViewModel
{
    public class RegistrationVM : BasicVM
    {
        IDataManager dataManager;

        string name = string.Empty;
        string login = string.Empty;
        string password = string.Empty;
        string passwordRepeat = string.Empty;

        public event Action? RegistrationSucces;
        public event Action<string>? RegistrationFailed;

        public RegistrationVM(IDataManager dataManager)
        {
            this.dataManager = dataManager;
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

    }
}
