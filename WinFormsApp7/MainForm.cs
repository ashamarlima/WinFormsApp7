using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class MainForm : Form
    {
        private QuizManager quizManager = new QuizManager();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (quizManager.Questions.Count == 0)
            {
                LoadSampleQuestions();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (quizManager.Questions.Count == 0)
            {
                MessageBox.Show("There are no questions to play. Please add some first.");
                return;
            }

            PlayForm playForm = new PlayForm(quizManager);
            playForm.ShowDialog();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm(quizManager);
            createForm.ShowDialog();
        }

        private void LoadSampleQuestions()
        {
   
            quizManager.AddQuestion(new MultipleChoiceQuestion
            {
                QuestionText = "What is the capital of France?",
                Options = new List<string> { "London", "Paris", "Rome", "Berlin" },
                CorrectOptionIndex = 1
            });

            quizManager.AddQuestion(new OpenEndedQuestion
            {
                QuestionText = "Which country is also known as the Land of the Rising Sun?",
                AcceptableAnswers = new List<string> { "Japan", "Nippon" }
            });

            quizManager.AddQuestion(new TrueFalseQuestion
            {
                QuestionText = "The Nile is the longest river in the world.",
                IsTrue = true
            });

     
            quizManager.AddQuestion(new MultipleChoiceQuestion
            {
                QuestionText = "Which continent is the Sahara Desert located in?",
                Options = new List<string> { "Asia", "Africa", "Australia", "South America" },
                CorrectOptionIndex = 1
            });

            
            quizManager.AddQuestion(new OpenEndedQuestion
            {
                QuestionText = "What is the smallest country in the world?",
                AcceptableAnswers = new List<string> { "Vatican", "Vatican City" }
            });
        }
    }
}
