using AutoSystem_CourseWork_.Model.Сourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.Model.Possibilities.Interfaces
{
    public interface IChangeUserCourse
    {
        public bool AddMyCourse(List<ICourse> courses);
        public bool DeleteMyCourse();
    }
}
