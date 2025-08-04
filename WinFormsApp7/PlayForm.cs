using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class PlayForm : Form
    {
        private QuizManager quizManager;
        private int currentQuestionIndex = 0;
        private int score = 0;
        private Stopwatch timer = new Stopwatch();
        private List<string> reviewAnswers = new List<string>();

        public PlayForm(QuizManager manager)
        {
            InitializeComponent();
            quizManager = manager;
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {
            timer.Restart();
            currentQuestionIndex = 0;
            score = 0;
            reviewAnswers.Clear();
            lblScore.Text = $"Score: 0/{quizManager.Questions.Count}";
            lblTimer.Text = "Time: 0m 0s";
            quizTimer.Start();
            ShowQuestion();
        }

        private void ShowQuestion()
        {
            if (currentQuestionIndex >= quizManager.Questions.Count)
            {
                FinishQuiz();
                return;
            }

            var q = quizManager.Questions[currentQuestionIndex];
            lblQuestion.Text = q.QuestionText;

            radOpt1.Visible = radOpt2.Visible = radOpt3.Visible = radOpt4.Visible = false;
            txtUserAnswer.Visible = false;
            radTFTrue.Visible = radTFFalse.Visible = false;

            if (q is MultipleChoiceQuestion mcq)
            {
                radOpt1.Visible = radOpt2.Visible = radOpt3.Visible = radOpt4.Visible = true;
                radOpt1.Text = mcq.Options[0];
                radOpt2.Text = mcq.Options[1];
                radOpt3.Text = mcq.Options[2];
                radOpt4.Text = mcq.Options[3];
                radOpt1.Checked = radOpt2.Checked = radOpt3.Checked = radOpt4.Checked = false;
            }
            else if (q is OpenEndedQuestion)
            {
                txtUserAnswer.Visible = true;
                txtUserAnswer.Text = "";
            }
            else if (q is TrueFalseQuestion)
            {
                radTFTrue.Visible = radTFFalse.Visible = true;
                radTFTrue.Checked = radTFFalse.Checked = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex >= quizManager.Questions.Count)
            {
                FinishQuiz();
                return;
            }

            var q = quizManager.Questions[currentQuestionIndex];
            string answer = "";
            string correct = "";

            if (q is MultipleChoiceQuestion mcq)
            {
                if (radOpt1.Checked) answer = radOpt1.Text;
                else if (radOpt2.Checked) answer = radOpt2.Text;
                else if (radOpt3.Checked) answer = radOpt3.Text;
                else if (radOpt4.Checked) answer = radOpt4.Text;
                correct = mcq.Options[mcq.CorrectOptionIndex];
            }
            else if (q is OpenEndedQuestion oq)
            {
                answer = txtUserAnswer.Text.Trim();
                correct = string.Join(", ", oq.AcceptableAnswers);
            }
            else if (q is TrueFalseQuestion tfq)
            {
                if (radTFTrue.Checked) answer = "true";
                else if (radTFFalse.Checked) answer = "false";
                correct = tfq.IsTrue ? "true" : "false";
            }

            bool isCorrect = q.CheckAnswer(answer);
            if (isCorrect) score++;

            reviewAnswers.Add($"Q{currentQuestionIndex + 1}: {(isCorrect ? "✔" : "✘")}\nYour Answer: {answer}\nCorrect: {correct}\n");

            currentQuestionIndex++;
            lblScore.Text = $"Score: {score}/{quizManager.Questions.Count}";
            ShowQuestion();
        }

        private void FinishQuiz()
        {
            timer.Stop();
            quizTimer.Stop();
            TimeSpan elapsed = timer.Elapsed;

            string review = string.Join("\n", reviewAnswers);
            DialogResult result = MessageBox.Show($"Quiz Over!\nScore: {score}/{quizManager.Questions.Count}\nTime: {elapsed.Minutes}m {elapsed.Seconds}s\n\nView answers?", "Result", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show(review, "Correct Answers");
            }

            DialogResult restart = MessageBox.Show("Do you want to restart the quiz?", "Restart", MessageBoxButtons.YesNo);
            if (restart == DialogResult.Yes)
            {
                PlayForm_Load(null, null);
            }
            else
            {
                this.Close();
            }
        }

        private void quizTimer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = $"Time: {timer.Elapsed.Minutes}m {timer.Elapsed.Seconds}s";
        }
    }
}