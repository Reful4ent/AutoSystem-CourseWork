using AutoSystem_CourseWork_.Model.Сourse.Test.Answers;
using AutoSystem_CourseWork_.Model.Сourse.Test.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.Model.CounterPoints
{
    public interface IPointCounter
    {
        public bool AnswerQuestionPoint(IAnswer answer, IQuestion question, string myAnswer);
    }
}
