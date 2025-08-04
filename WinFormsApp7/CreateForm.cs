using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class CreateForm : Form
    {
        private QuizManager quizManager;
        private int editingIndex = -1; // -1 means not editing

        public CreateForm(QuizManager manager)
        {
            InitializeComponent();
            quizManager = manager;
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
            cmbType.Items.AddRange(new string[] { "Multiple Choice", "Open Ended", "True/False" });
            cmbCorrect.Items.AddRange(new string[] { "Option 1", "Option 2", "Option 3", "Option 4" });
            cmbType.SelectedIndex = 0;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            btnCancelEdit.Visible = false;

            panelMCQ.Visible = false;
            panelOpen.Visible = false;
            panelTF.Visible = false;

            RefreshQuestionList();
            UpdateVisibleFields();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateVisibleFields();
        }

        private void UpdateVisibleFields()
        {
            string selectedType = cmbType.SelectedItem?.ToString() ?? "";

            panelMCQ.Visible = selectedType == "Multiple Choice";
            panelOpen.Visible = selectedType == "Open Ended";
            panelTF.Visible = selectedType == "True/False";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string selectedType = cmbType.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(txtQuestion.Text))
            {
                MessageBox.Show("Enter the question text.");
                return;
            }

            Question newQuestion = null;

            if (selectedType == "Multiple Choice")
            {
                if (cmbCorrect.SelectedIndex == -1)
                {
                    MessageBox.Show("Select the correct option.");
                    return;
                }

                newQuestion = new MultipleChoiceQuestion
                {
                    QuestionText = txtQuestion.Text,
                    Options = new List<string>
                    {
                        txtOpt1.Text,
                        txtOpt2.Text,
                        txtOpt3.Text,
                        txtOpt4.Text
                    },
                    CorrectOptionIndex = cmbCorrect.SelectedIndex
                };
            }
            else if (selectedType == "Open Ended")
            {
                if (string.IsNullOrWhiteSpace(txtAcceptable.Text))
                {
                    MessageBox.Show("Enter acceptable answers separated by commas.");
                    return;
                }

                newQuestion = new OpenEndedQuestion
                {
                    QuestionText = txtQuestion.Text,
                    AcceptableAnswers = new List<string>(txtAcceptable.Text.Split(','))
                };
            }
            else if (selectedType == "True/False")
            {
                newQuestion = new TrueFalseQuestion
                {
                    QuestionText = txtQuestion.Text,
                    IsTrue = radTrue.Checked
                };
            }

            if (newQuestion == null) return;

            if (editingIndex >= 0)
            {
                quizManager.Questions[editingIndex] = newQuestion;
                MessageBox.Show("✅ Question updated successfully.");
                editingIndex = -1;
                btnAdd.Text = "Add Question";
                btnCancelEdit.Visible = false;
            }
            else
            {
                quizManager.AddQuestion(newQuestion);
                MessageBox.Show("✅ Question added successfully.");
            }

            ClearInputs();
            RefreshQuestionList();
        }

        private void lstQuestions_DoubleClick(object sender, EventArgs e)
        {
            if (lstQuestions.SelectedIndex == -1) return;

            editingIndex = lstQuestions.SelectedIndex;
            Question q = quizManager.Questions[editingIndex];
            txtQuestion.Text = q.QuestionText;

            if (q is MultipleChoiceQuestion mcq)
            {
                cmbType.SelectedItem = "Multiple Choice";
                txtOpt1.Text = mcq.Options[0];
                txtOpt2.Text = mcq.Options[1];
                txtOpt3.Text = mcq.Options[2];
                txtOpt4.Text = mcq.Options[3];
                cmbCorrect.SelectedIndex = mcq.CorrectOptionIndex;
            }
            else if (q is OpenEndedQuestion oq)
            {
                cmbType.SelectedItem = "Open Ended";
                txtAcceptable.Text = string.Join(",", oq.AcceptableAnswers);
            }
            else if (q is TrueFalseQuestion tfq)
            {
                cmbType.SelectedItem = "True/False";
                radTrue.Checked = tfq.IsTrue;
                radFalse.Checked = !tfq.IsTrue;
            }

            UpdateVisibleFields();
            btnAdd.Text = "Save Changes";
            btnCancelEdit.Visible = true;
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            ClearInputs();
            editingIndex = -1;
            btnAdd.Text = "Add Question";
            btnCancelEdit.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstQuestions.SelectedIndex == -1)
            {
                MessageBox.Show("Select a question to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this question?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                quizManager.Questions.RemoveAt(lstQuestions.SelectedIndex);
                ClearInputs();
                editingIndex = -1;
                btnAdd.Text = "Add Question";
                btnCancelEdit.Visible = false;
                RefreshQuestionList();
            }
        }

        private void RefreshQuestionList()
        {
            lstQuestions.Items.Clear();
            for (int i = 0; i < quizManager.Questions.Count; i++)
            {
                string prefix = (i == editingIndex) ? "[Editing] " : "";
                lstQuestions.Items.Add($"{prefix}Q{i + 1}: {quizManager.Questions[i].QuestionText}");
            }
        }

        private void ClearInputs()
        {
            txtQuestion.Clear();
            txtOpt1.Clear();
            txtOpt2.Clear();
            txtOpt3.Clear();
            txtOpt4.Clear();
            cmbCorrect.SelectedIndex = -1;
            txtAcceptable.Clear();
            radTrue.Checked = false;
            radFalse.Checked = false;
        }
    }
}
