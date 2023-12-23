using AutoSystem_CourseWork_.Model.Сourse;
using AutoSystem_CourseWork_.ViewModel.DataManager;
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
    public class CoursesAddListVM : BasicVM
    {
        IDataManager dataManager;
        private ObservableCollection<ICourse> coursesList;
        private int index;
        public event Action? AddCourseSucces;
        public event Action<string>? AddCourseFailed;

        public CoursesAddListVM(IDataManager dataManager)
        {
            this.dataManager = dataManager;
            CoursesList = new ObservableCollection<ICourse>(this.dataManager.CoursesRepository.GetCourses());
        }

        public ObservableCollection<ICourse> CoursesList
        {
            get => coursesList;
            set => Set(ref coursesList, value);
        }
        public int Index
        {
            get => index;
            set => Set(ref index, value);
        }

        public void AddUserCourse()
        {
            if (dataManager.TryAddUserCourse(CoursesList[index]))
            {
                AddCourseSucces?.Invoke();
            }
            else
            {
                AddCourseFailed?.Invoke("У вас уже есть данный курс или курс пустой!");
            }
        }

        public ICommand AddUserCourseCommand
        {
            get
            {
                return new Command(() =>
                {
                    AddUserCourse();
                });
            }
        }

    }
}
