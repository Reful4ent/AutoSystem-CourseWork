using AutoSystem_CourseWork_.Model.Basic;
using AutoSystem_CourseWork_.Model.Сourse.Test.Answers;
using AutoSystem_CourseWork_.Model.Сourse.Test.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.Model.Сourse.Test
{
    public interface ITest : IEntity
    {
        public string Name { get; }
        public CourseTypeEnum CourseType { get; }
        public List<IAnswer> answers { get; set; }
        public List<IQuestion> questions { get; set; }
        public bool AddQuestionAndAnswer(IQuestion question, IAnswer answer);
        public bool DeleteQuestionAndAnswer(int number);
    }
}
