using AutoSystem_CourseWork_.Model.Сourse.Test.Answers;
using AutoSystem_CourseWork_.Model.Сourse.Test.Questions;
using AutoSystem_CourseWork_.ViewModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.Model.CounterPoints
{
    public class PointCounter : IPointCounter
    {
        private int points = 0;
        private User user;
        public PointCounter(User user)
        {
            this.user = user;
        }
        public static PointCounter Instance(User user) => new(user);
        public int Points
        {
            get => points;
            set => points = value;
        }
        public bool AnswerQuestionPoint(IAnswer answer, IQuestion question, string myAnswer)
        {
            if (user.AnswerQuestion(answer, question, myAnswer))
                points += 1;
            else
                points += 0;
            return true;
        }
    }
}
