using AutoSystem_CourseWork_.Model.Сourse;
using AutoSystem_CourseWork_.Model.Сourse.Test.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.Model.Сourse.Test.Questions
{
    public class FileQuestion : IQuestion
    {
        public Guid Id { get; }
        public string Text { get; }
        public string Path { get; }
        public CourseTypeEnum CourseType { get; }
        public FileQuestion(Guid id, string text, string path, CourseTypeEnum courseType)
        {
            Id = id;
            Text = text;
            Path = path;
            CourseType = courseType;
        }
    }
}
