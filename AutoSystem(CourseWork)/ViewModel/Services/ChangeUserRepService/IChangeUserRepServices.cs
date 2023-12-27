using AutoSystem_CourseWork_.ViewModel.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.ViewModel.Services.ChangeUserRepService
{
    public interface IChangeUserRepServices
    {
        public bool TryDeleteUser(int number, IDataManager dataManager);
        public bool TryChangeUserRole(int number, int Role_Id, IDataManager dataManager);
    }
}
