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
using System.Xml.Serialization;
using System.Windows.Controls;

namespace AutoSystem_CourseWork_.ViewModel
{
    public class ChangeCoursesVM : BasicVM
    {
        IDataManager dataManager;
        private ObservableCollection<ICourse> coursesList;
        private int indexCourse = 0;
        private ObservableCollection<ITest> testsList;
        private int indexTest = 0;
        private ObservableCollection<IQuestion> questionsList;
        private int indexQuestion = 0;
        private int courseType;
        private int testType;
        private string name_Of_Course = string.Empty;
        private string name_Of_Test = string.Empty;

        public event Action? DeleteCourseSucces;
        public event Action<string>? DeleteCourseFailed;
        public event Action? DeleteTestSucces;
        public event Action<string>? DeleteTestFailed;
        public event Action? DeleteQuestionSucces;
        public event Action<string>? DeleteQuestionFailed;
        public event Action? AddCourseSucces;
        public event Action<string>? AddCourseFailed;
        public event Action? AddTestSucces;
        public event Action<string>? AddTestFailed;
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
                IndexTest = 0;
                TestsList = new ObservableCollection<ITest>(dataManager.GetTests(IndexCourse));
                QuestionsList = new ObservableCollection<IQuestion>(dataManager.GetQuestions(IndexCourse, IndexTest));
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

        public int CourseType
        {
            get => courseType;
            set => Set(ref courseType, value);
        }

        public int TestType
        {
            get => testType;
            set => Set(ref testType, value);
        }
        public string Name_Of_Course
        {
            get => name_Of_Course;
            set => Set(ref name_Of_Course, value);
        }

        public string Name_Of_Test
        {
            get => name_Of_Test;
            set => Set(ref name_Of_Test, value);
        }
        public Array CourseTypeArray => Enum.GetValues(typeof(CourseTypeEnum));

        public void RefreshCourses()
        {
            CoursesList = new ObservableCollection<ICourse>(this.dataManager.CoursesRepository.GetCourses());
            TestsList = new ObservableCollection<ITest>(dataManager.GetTests(IndexCourse));
            QuestionsList = new ObservableCollection<IQuestion>(dataManager.GetQuestions(IndexCourse, IndexTest));
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

        private void DeleteTest()
        {
            if (dataManager.TryDeleteTest(CoursesList[IndexCourse],IndexTest))
            {
                DeleteTestSucces?.Invoke();
            }
            else
            {
                DeleteTestFailed?.Invoke("Ошибка при удалении!");
            }
        }

        private void DeleteQuestion()
        {
            if (dataManager.TryDeleteQuestion(CoursesList[indexCourse], TestsList[IndexTest], IndexQuestion))
            {
                DeleteQuestionSucces?.Invoke();
            }
            else
            {
                DeleteQuestionFailed?.Invoke("Ошибка при удалении");
            }
        }

        private void AddCourse()
        {
            if (dataManager.TryAddCourse(Name_Of_Course, (CourseTypeEnum)(CourseType)))
            {
                AddCourseSucces?.Invoke();
            }
            else
            {
                AddCourseFailed?.Invoke("Не удалось добавить курс!");
            }
        }

        private void AddTest()
        {
            if(dataManager.TryAddTest(IndexCourse, Name_Of_Test, (CourseTypeEnum)(TestType)))
            {
                AddTestSucces?.Invoke();
            }
            else
            {
                AddTestFailed?.Invoke("Не удалось добавить тест!");
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

        public ICommand AddCourseCommand
        {
            get
            {
                return new Command(() =>
                {
                    AddCourse();
                });
            }
        }

        public ICommand DeleteTestCommand
        {
            get
            {
                return new Command(() =>
                {
                    DeleteTest();
                });
            }
        }

        public ICommand AddTestCommand
        {
            get
            {
                return new Command(() =>
                {
                    AddTest();
                });
            }
        }

        public ICommand DeleteQuestionCommand
        {
            get
            {
                return new Command(() =>
                {
                    DeleteQuestion();
                });
            }
        }
    }
}
