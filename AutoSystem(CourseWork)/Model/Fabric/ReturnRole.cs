using AutoSystem_CourseWork_.Model.ForFabric_Roles_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.Model.Fabric
{
    public static class ReturnRole
    {
        public static IChooseRole chooseRole(int Role_Id)
        {
            MyRoleFabric fabric = MyRole.GetMyRole(Role_Id);
            return fabric.GetRole();
        }
    }
}
