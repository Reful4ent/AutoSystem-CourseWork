using AutoSystem_CourseWork_.Model.Possibilities.Interfaces;
using AutoSystem_CourseWork_.Model.Сourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.Model.Possibilities.Classes
{
    public class CanChangeCourse : IChangeCourse
    {
        public bool AddCourse(List<ICourse> courses, ICourse course)
        {
            if(courses == null || courses.Contains(course)) return false;
            courses.Add(course);
            return true;
        }

        public bool DeleteCourse(List<ICourse> courses, int number)
        {
            if (number >= courses.Count || number < 0) return false;
            courses.RemoveAt(number); return true;
        }
    }
}
