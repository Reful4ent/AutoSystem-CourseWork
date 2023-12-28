using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSystem_CourseWork_.Model.Possibilities.Interfaces;
using AutoSystem_CourseWork_.Model.Сourse;
using AutoSystem_CourseWork_.Model.Сourse.Test;
using AutoSystem_CourseWork_.Model.Сourse.Test.Answers;
using AutoSystem_CourseWork_.Model.Сourse.Test.Questions;

namespace AutoSystem_CourseWork_.Model.Possibilities.Classes
{
    public class CanChangeTest : IChangeTest
    {
        public bool AddTest(ICourse course, ITest test)
        {
            if (course == null || test == null) return false;
            if(course.AddTest(test))  return true;
            return false;
        }

        public bool DeleteTest(ICourse course, int number)
        {
            if (course == null) return false;
            if(course.DeleteTest(number)) return true;
            return false;
        }
    }
}
