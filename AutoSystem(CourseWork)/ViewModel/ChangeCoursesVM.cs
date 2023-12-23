using AutoSystem_CourseWork_.Model.Сourse;
using AutoSystem_CourseWork_.ViewModel.DataManager;
using AutoSystem_CourseWork_.Model.Сourse.Test;
using AutoSystem_CourseWork_.Model.Сourse.Test.Questions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.ViewModel
{
    public class ChangeCoursesVM : BasicVM
    {
        IDataManager dataManager;
        private ObservableCollection<ICourse> coursesList;
        private int indexCourse;
        private ObservableCollection<ITest> testsList;
        private int indexTest;
        private ObservableCollection<IQuestion> questionsList;
        private int indexQuestion;

        public ChangeCoursesVM(IDataManager dataManager)
        {
            this.dataManager = dataManager;
            CoursesList = new ObservableCollection<ICourse>(this.dataManager.CoursesRepository.GetCourses());
            TestsList = new ObservableCollection<ITest>(this.dataManager.GetTests(IndexCourse));
            QuestionsList = new ObservableCollection<IQuestion>(this.dataManager.GetQuestions(IndexCourse, IndexTest));
        }

        public ObservableCollection<ICourse> CoursesList
        {
            get => coursesList;
            set => Set(ref coursesList, value);
        }
        public int IndexCourse
        {
            get => indexCourse;
            set
            {
                Set(ref indexCourse, value);
                TestsList = new ObservableCollection<ITest>(dataManager.GetTests(IndexCourse));
            }
        }

        public ObservableCollection<ITest> TestsList
        {
            get => testsList;
            set => Set(ref testsList, value);
        }
        public int IndexTest
        {
            get => indexTest;
            set
            {
                Set(ref indexTest, value);
                QuestionsList = new ObservableCollection<IQuestion>(dataManager.GetQuestions(IndexCourse,IndexTest));
            }
        }

        public ObservableCollection<IQuestion> QuestionsList
        {
            get => questionsList;
            set => Set(ref questionsList, value);
        }
        public int IndexQuestion
        {
            get => indexQuestion;
            set => Set(ref indexQuestion, value);
        }
    }
}
