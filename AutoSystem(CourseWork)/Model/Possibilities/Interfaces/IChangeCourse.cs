using AutoSystem_CourseWork_.Model.Сourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.Model.Possibilities.Interfaces
{
    public interface IChangeCourse
    {
        public bool AddCourse(List<ICourse> courses, ICourse course);
        public bool DeleteCourse(List<ICourse> courses,int number);
    }
}
