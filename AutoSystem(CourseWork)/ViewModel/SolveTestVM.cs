using AutoSystem_CourseWork_.Model.Сourse.Test.Questions;
using AutoSystem_CourseWork_.ViewModel.DataManager;
using AutoSystem_CourseWork_.ViewModel.Services;
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
    public class SolveTestVM : BasicVM
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        private string theory = string.Empty;

        public event Action? CheckQuestionSucces;
        public event Action<string>? CheckQuestionFailed;

        public SolveTestVM(IDataManager dataManager, IServiceManager serviceManager)
        {
            this.dataManager = dataManager;
            this.serviceManager = serviceManager;
            Theory = dataManager.ParticularTest.Theory;
        }

        public string Theory
        {
            get => theory;
            set => Set(ref theory, value);
        }

        private void CheckQuestions()
        {
            if (dataManager.ParticularTest.questions.Count == 0 || dataManager.ParticularTest.questions == null) 
            {
                CheckQuestionFailed?.Invoke("Вопросов нет!");
            }
            else
            {
                CheckQuestionSucces?.Invoke();
            }
        }

        public ICommand CheckQuestionCommand
        {
            get
            {
                return new Command(() =>
                {
                    CheckQuestions();
                });
            }
        }
    }
}
