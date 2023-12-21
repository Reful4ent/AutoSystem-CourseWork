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
            Id = id;
            Text = text;
            CourseType = courseType;
        }

        public override string ToString()
        {
            return $"Question:\nID: {Id}\nText: {Text}\nType of Course: {CourseType}";
        }
    }
}
