using AutoSystem_CourseWork_.Model.Basic;
using AutoSystem_CourseWork_.Model.Сourse.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.Model.Сourse
{
    public interface ICourse : IEntity
    {
        public Guid Id { get; }
        public string Name { get; }
        public string AuthorName { get; }
        public CourseTypeEnum CourseType { get; }
        public List<ITest> Tests { get; }
        public bool AddTest(ITest test);
        public bool DeleteTest(int number);
    }
}
