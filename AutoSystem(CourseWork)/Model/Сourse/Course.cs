using AutoSystem_CourseWork_.Model.Basic;
using AutoSystem_CourseWork_.Model.Сourse.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.Model.Сourse
{
    public class Course : ICourse
    {
        public Guid Id { get; }
        public string Name { get; }
        public CourseTypeEnum CourseType { get; }
        public List<ITest> Tests { get; }

        public Course(Guid Id, string Name, CourseTypeEnum CourseType, List<ITest> Tests)
        {
            this.Id = Id;
            this.Name = Name;
            this.CourseType = CourseType;
            this.Tests = Tests;
        }
    }
}
