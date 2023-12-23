using AutoSystem_CourseWork_.Model.Сourse;
using AutoSystem_CourseWork_.ViewModel.DataManager;
using AutoSystem_CourseWork_.Model.Сourse.Test;
using AutoSystem_CourseWork_.Model.Сourse.Test.Questions;
using AutoSystem_CourseWork_.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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

        public event Action? DeleteCourseSucces;
        public event Action<string>? DeleteCourseFailed;
        public event Action? DeleteTestSucces;
        public event Action<string>? DeleteTestFailed;
        public event Action? DeleteQuestionSucces;
        public event Action<string>? DeleteQuestionFailed;

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
                TestsList = new ObservableCollection<ITest>(dataManager.GetTests(0));
                QuestionsList = new ObservableCollection<IQuestion>(dataManager.GetQuestions(0, 0));
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

        public void RefreshCourses()
        {
            CoursesList = new ObservableCollection<ICourse>(this.dataManager.CoursesRepository.GetCourses());
        }

        private void DeleteCourse()
        {
            if(dataManager.TryDeleteCourse(IndexCourse))
            {
                DeleteCourseSucces?.Invoke();
            }
            else
            {
                DeleteCourseFailed?.Invoke("Ошибка при удалении!");
            }
        }

        public ICommand DeleteCourseCommand
        {
            get
            {
                return new Command(() =>
                {
                    DeleteCourse();
                });
            }
        }

    }
}
