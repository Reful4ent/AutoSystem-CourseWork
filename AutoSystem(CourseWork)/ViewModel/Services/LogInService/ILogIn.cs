using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.ViewModel.Services.LogInService
{
    internal interface ILogIn
    {
        public bool TryLogIn(string login, string password);
    }
}
