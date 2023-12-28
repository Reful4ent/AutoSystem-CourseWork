using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutoSystem_CourseWork_.Model.Сourse.Test.Questions
{
    public class TextQuestion : IQuestion
    {
        public Guid Id { get; }
        public string Text { get; }
        public CourseTypeEnum CourseType{ get; }
        public TextQuestion(Guid id, string text, CourseTypeEnum courseType)
        {
            if (Id == null)
                throw new ArgumentException("Айди не может быть пустым");
            Id = id;
            if (String.IsNullOrEmpty(text) || String.IsNullOrWhiteSpace(text))
                throw new ArgumentException("Пустое поле вопроса");
            Text = text;
            CourseType = courseType;
        }
    }
}
