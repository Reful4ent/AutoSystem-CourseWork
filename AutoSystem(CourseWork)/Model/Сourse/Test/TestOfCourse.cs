using AutoSystem_CourseWork_.Model.Сourse.Test.Answers;
using AutoSystem_CourseWork_.Model.Сourse.Test.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AutoSystem_CourseWork_.Model.Сourse.Test
{
    public class TestOfCourse : ITest
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Theory { get; set; }
        public CourseTypeEnum CourseType { get; }
        public List<IAnswer> answers { get; set; }
        public List<IQuestion> questions { get; set; }

        public TestOfCourse(Guid Id, string Name, string Theory, CourseTypeEnum CourseType, List<IAnswer> answers, List<IQuestion> questions)
        {
            this.Id = Id;
            this.Name = Name;
            this.Theory = Theory;
            this.CourseType = CourseType;
            this.answers = answers;
            this.questions = questions;
        }

        public bool AddQuestionAndAnswer(IQuestion question, IAnswer answer)
        {
            if (answer.Id != question.Id) return false;

            if (question == null || questions.Contains(question)) return false;
            var CheckSimilaryQues = from selectQuestion in questions
                                where (question.Id == selectQuestion.Id)
                                select question;
            if (CheckSimilaryQues.Count() != 0) return false;

            if (answer == null || answers.Contains(answer)) return false;
            var CheckSimilaryAns = from selectAnswer in questions
                                where (answer.Id == selectAnswer.Id)
                                select answer;
            if (CheckSimilaryAns.Count() != 0) return false;


            answers.Add(answer);
            questions.Add(question);
            return true;
        }

        public bool DeleteQuestionAndAnswer(int number)
        {
            if (number >= answers.Count || number < 0) return false;
            Guid anserId = questions[number].Id;
            questions.RemoveAt(number);
            for(int i=0; i<answers.Count; i++)
            {
                if (answers[i].Id == anserId)
                {
                    answers.Remove(answers[i]);
                    break;
                }
            }
            return true;
        }
       
    }
}
