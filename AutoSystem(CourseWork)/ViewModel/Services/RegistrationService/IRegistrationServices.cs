using AutoSystem_CourseWork_.ViewModel.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.ViewModel.Services.RegistrationService
{
    public interface IRegistrationServices
    {
        public bool TryRegistration(string name, string login, string password, string passwordRepeat, IDataManager dataManager);
    }
}
