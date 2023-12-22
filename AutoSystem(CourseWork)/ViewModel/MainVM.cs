using AutoSystem_CourseWork_.ViewModel.DataManager;
using AutoSystem_CourseWork_.ViewModel.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.ViewModel
{
    public class MainVM : BasicVM
    {
        IDataManager dataManager;

        private string name = string.Empty;
        private string role = string.Empty;
        private int role_Id;
        public MainVM(IDataManager dataManager)
        {
            this.dataManager = dataManager;
            Name = this.dataManager.ParticularUser.Name;
            Role_Id = this.dataManager.ParticularUser.Role_Id;
            Role = UserRole.GetName(typeof(UserRole), (UserRole)(this.dataManager.ParticularUser.Role_Id));
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
    }
}
