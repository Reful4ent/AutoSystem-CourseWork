using AutoSystem_CourseWork_.ViewModel.DataManager;
using AutoSystem_CourseWork_.ViewModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.ViewModel
{
    public class AnswerQuestionVM : BasicVM
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        private string questionText = string.Empty;
        private string answerText = string.Empty;
        private int questionIndex;
        private int questionNumber;
        private int questionCount;

        public AnswerQuestionVM(IDataManager dataManager, IServiceManager serviceManager)
        {
            this.dataManager = dataManager;
            this.serviceManager = serviceManager;
            QuestionCount = dataManager.ParticularTest.questions.Count;
            QuestionText = dataManager.ParticularTest.questions[0].Text;
            QuestionIndex = 0;
            QuestionNumber = QuestionIndex + 1; 

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
    }
}
