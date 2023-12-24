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
        public string AuthorName {  get; }
        public CourseTypeEnum CourseType { get; }
        public List<ITest> Tests { get; set; }

        public Course(Guid Id, string Name, string AuthorName, CourseTypeEnum CourseType, List<ITest> Tests)
        {
            this.Id = Id;
            this.Name = Name;
            this.AuthorName = AuthorName;
            this.CourseType = CourseType;
            this.Tests = Tests;
        }

        public bool AddTest(ITest test)
        {
            if (test == null || Tests.Contains(test)) return false;
            if (test.CourseType != CourseType) return false;
            var CheckSimilary = from selectTest in Tests
                                where (test.Id == selectTest.Id)
                                select test;
            if (CheckSimilary.Count() != 0) return false;
            Tests.Add(test);
            return true;
        }
        public bool DeleteTest(int number)
        {
            if (number >= Tests.Count || number < 0) return false;
            Tests.RemoveAt(number); return true;
        }
    }
}
