using AutoSystem_CourseWork_.Model.Basic;
using AutoSystem_CourseWork_.Model.Сourse.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.Model.Сourse
{
    public class Course : ICourse
    {
        public Guid Id { get; }
        public string Name { get; }
        public string AuthorName {  get; }
        public CourseTypeEnum CourseType { get; }
        public List<ITest> Tests { get; set; }

        public Course(Guid Id, string Name, string AuthorName, CourseTypeEnum CourseType, List<ITest> Tests)
        {
            if(Id == null)
                throw new ArgumentNullException("Айди не может быть пустым");
            this.Id = Id;
            if (String.IsNullOrEmpty(Name))
                throw new ArgumentException("Пустое поле имени");
            if (Name.StartsWith(" "))
                throw new ArgumentException("Имя не может начинаться с пробела");
            this.Name = Name;
            if (String.IsNullOrEmpty(AuthorName))
                throw new ArgumentException("Пустое поле имени");
            if (AuthorName.StartsWith(" "))
                throw new ArgumentException("Имя не может начинаться с пробела");
            this.AuthorName = AuthorName;
            this.CourseType = CourseType;
            if (Tests == null)
                throw new ArgumentException("Тесты имеют нулевую ссылку");
            this.Tests = Tests;
        }

        public bool AddTest(ITest test)
        {
            if (test == null || Tests.Contains(test)) return false;
            if (test.CourseType != CourseType) return false;
            var CheckSimilary = from selectTest in Tests
                                where (test.Id == selectTest.Id || test.Name == selectTest.Name)
                                select test;
            if (CheckSimilary.Count() != 0) return false;
            Tests.Add(test);
            return true;
        }
        public bool DeleteTest(int number)
        {
            if (number >= Tests.Count || number < 0) return false;
            Tests.RemoveAt(number); return true;
        }
    }
}
