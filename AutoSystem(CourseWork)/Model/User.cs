using AutoSystem_CourseWork_.Model.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSystem_CourseWork_.Model.ForFabric_Roles_;
using AutoSystem_CourseWork_.Model.Fabric;
using AutoSystem_CourseWork_.Model.Сourse;

namespace AutoSystem_CourseWork_.Model
{
    public class User : IEntity
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Login { get; }
        public string Password { get; }
        public int Role_Id { get; set; }
        private IChooseRole Role { get; set; }
        public List<ICourse> Courses { get; set; }

        public User(Guid Id, string Name, string Login, string Password, int Role_Id, List<ICourse> Courses)
        {
            this.Id = Id;
            this.Name = Name;
            this.Login = Login;
            this.Password = Password;
            this.Role_Id = Role_Id;
            this.Role = ReturnRole.chooseRole(this.Role_Id);
            this.Courses = Courses;
        }
    }
}
