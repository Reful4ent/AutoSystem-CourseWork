using AutoSystem_CourseWork_.Model.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.Model.Сourse.Test.Answers
{
    public interface IAnswer : IEntity
    {
        public string Text { get; }
        public CourseTypeEnum CourseType { get; }
    }
}
