using AutoSystem_CourseWork_.ViewModel.DataManager;
using AutoSystem_CourseWork_.ViewModel.Services;
using AutoSystem_CourseWork_.Model.CounterPoints;
using AutoSystem_CourseWork_.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AutoSystem_CourseWork_.ViewModel
{
    public class AnswerQuestionVM : BasicVM
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        IPointCounter pointCounter;
        private string questionText = string.Empty;
        private string answerText = string.Empty;
        private int questionIndex;
        private int questionNumber;
        private int questionCount;

        public event Action<int, int>? AnswerQuestionCompleted;

        public AnswerQuestionVM(IDataManager dataManager, IServiceManager serviceManager)
        {
            this.dataManager = dataManager;
            this.serviceManager = serviceManager;
            QuestionCount = dataManager.ParticularTest.questions.Count;
            QuestionIndex = 0;
            QuestionText = dataManager.ParticularTest.questions[QuestionIndex].Text;
            QuestionNumber = QuestionIndex + 1;
            pointCounter = PointCounter.Instance(this.dataManager.ParticularUser);
        }

        public string QuestionText
        {
            get => questionText;
            set => Set(ref questionText, value);
        }
        public string AnswerText
        {
            get => answerText;
            set => Set(ref answerText, value);
        }
        public int QuestionIndex
        {
            get => questionIndex; 
            set => Set(ref questionIndex, value);
        }
        public int QuestionNumber
        {
            get => questionNumber;
            set => Set(ref questionNumber, value);
        }
        public int QuestionCount
        {
            get => questionCount; 
            set => Set(ref questionCount, value);
        }

        private void StartAnswering()
        {
            if(QuestionIndex == QuestionCount)
            {
                AnswerQuestionCompleted?.Invoke(pointCounter.Points, questionCount);
            }
            else
            {
                pointCounter.AnswerQuestionPoint(dataManager.ParticularTest.answers[QuestionIndex], dataManager.ParticularTest.questions[questionIndex], AnswerText);
                Refresh();
            }
        }

        private void Refresh()
        {
            QuestionIndex += 1;
            if (QuestionIndex == QuestionCount) return;
            QuestionText = dataManager.ParticularTest.questions[QuestionIndex].Text;
            QuestionNumber = QuestionIndex + 1;
            AnswerText = string.Empty;
        }

        public ICommand AnswerCommand
        {
            get
            {
                return new Command(() =>
                {
                    StartAnswering();
                });
            }
        }
    }
}
