using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.Model.Сourse.Test.Answers
{
    public class TextAnswer : IAnswer
    {
        public Guid Id { get; }
        public string Text { get; }
        public CourseTypeEnum CourseType { get; }
        public TextAnswer(Guid id, string text, CourseTypeEnum courseType)
        {
            if (Id == null)
                throw new ArgumentNullException("Айди не может быть пустым");
            Id = id;
            if (String.IsNullOrEmpty(text) || String.IsNullOrWhiteSpace(text))
                throw new ArgumentException("Пустое поле ответа");
            Text = text;
            CourseType = courseType;
        }
    }
}
