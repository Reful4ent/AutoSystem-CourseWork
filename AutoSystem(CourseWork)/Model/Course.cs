using AutoSystem_CourseWork_.Model.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.Model
{
    public class Course : ICourse
    {
        public Guid Id { get; }
        public string Name { get; }
        public CourseTypeEnum CourseType { get; }
        public Tests Tests { get; }

        public Course(Guid Id, string Name, CourseTypeEnum CourseType, Tests Tests)
        {
            this.Id = Id;
            this.Name = Name;
            this.CourseType = CourseType;
            this.Tests = Tests;
        }
    }
}
