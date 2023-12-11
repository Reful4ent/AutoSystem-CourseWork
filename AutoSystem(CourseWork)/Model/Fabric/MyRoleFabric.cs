using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSystem_CourseWork_.Model.ForFabric_Roles_;

namespace AutoSystem_CourseWork_.Model.Fabric
{
    internal abstract class MyRoleFabric
    {
        public abstract IChooseRole GetRole();
    }
}
