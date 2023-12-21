using AutoSystem_CourseWork_.Model.Сourse.Test;
using AutoSystem_CourseWork_.Model.Сourse.Test.Answers;
using AutoSystem_CourseWork_.Model.Сourse.Test.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.Model.Possibilities.Interfaces
{
    public interface IChangeQuestion
    {
        public bool AddQuestionAndAnswer(ITest test, IQuestion question, IAnswer answer);

        public bool DeleteQuestionAndAnswer(ITest test, int number);
    }
}
