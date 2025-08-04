
namespace WinFormsApp7
{
    partial class PlayForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblQuestion;
        private RadioButton radOpt1;
        private RadioButton radOpt2;
        private RadioButton radOpt3;
        private RadioButton radOpt4;
        private TextBox txtUserAnswer;
        private RadioButton radTFTrue;
        private RadioButton radTFFalse;
        private Button btnNext;
        private Label lblScore;
        private Label lblTimer;
        private System.Windows.Forms.Timer quizTimer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblQuestion = new Label();
            radOpt1 = new RadioButton();
            radOpt2 = new RadioButton();
            radOpt3 = new RadioButton();
            radOpt4 = new RadioButton();
            txtUserAnswer = new TextBox();
            radTFTrue = new RadioButton();
            radTFFalse = new RadioButton();
            btnNext = new Button();
            lblScore = new Label();
            lblTimer = new Label();
            quizTimer = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            bindingSource1 = new BindingSource(components);
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(333, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(76, 31);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "label1";
            // 
            // radOpt1
            // 
            radOpt1.AutoSize = true;
            radOpt1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radOpt1.Location = new Point(337, 146);
            radOpt1.Name = "radOpt1";
            radOpt1.Size = new Size(168, 35);
            radOpt1.TabIndex = 1;
            radOpt1.TabStop = true;
            radOpt1.Text = "radioButton1";
            radOpt1.UseVisualStyleBackColor = true;
            // 
            // radOpt2
            // 
            radOpt2.AutoSize = true;
            radOpt2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radOpt2.Location = new Point(607, 146);
            radOpt2.Name = "radOpt2";
            radOpt2.Size = new Size(168, 35);
            radOpt2.TabIndex = 2;
            radOpt2.TabStop = true;
            radOpt2.Text = "radioButton2";
            radOpt2.UseVisualStyleBackColor = true;
            // 
            // radOpt3
            // 
            radOpt3.AutoSize = true;
            radOpt3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radOpt3.Location = new Point(337, 239);
            radOpt3.Name = "radOpt3";
            radOpt3.Size = new Size(168, 35);
            radOpt3.TabIndex = 3;
            radOpt3.TabStop = true;
            radOpt3.Text = "radioButton3";
            radOpt3.UseVisualStyleBackColor = true;
            // 
            // radOpt4
            // 
            radOpt4.AutoSize = true;
            radOpt4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radOpt4.Location = new Point(607, 239);
            radOpt4.Name = "radOpt4";
            radOpt4.Size = new Size(168, 35);
            radOpt4.TabIndex = 4;
            radOpt4.TabStop = true;
            radOpt4.Text = "radioButton4";
            radOpt4.UseVisualStyleBackColor = true;
            // 
            // txtUserAnswer
            // 
            txtUserAnswer.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserAnswer.Location = new Point(421, 187);
            txtUserAnswer.Name = "txtUserAnswer";
            txtUserAnswer.Size = new Size(236, 38);
            txtUserAnswer.TabIndex = 5;
            // 
            // radTFTrue
            // 
            radTFTrue.AutoSize = true;
            radTFTrue.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radTFTrue.Location = new Point(337, 146);
            radTFTrue.Name = "radTFTrue";
            radTFTrue.Size = new Size(78, 35);
            radTFTrue.TabIndex = 6;
            radTFTrue.TabStop = true;
            radTFTrue.Text = "True";
            radTFTrue.UseVisualStyleBackColor = true;
            // 
            // radTFFalse
            // 
            radTFFalse.AutoSize = true;
            radTFFalse.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radTFFalse.Location = new Point(607, 146);
            radTFFalse.Name = "radTFFalse";
            radTFFalse.Size = new Size(85, 35);
            radTFFalse.TabIndex = 7;
            radTFFalse.TabStop = true;
            radTFFalse.Text = "False";
            radTFFalse.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.IndianRed;
            btnNext.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(837, 239);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(99, 40);
            btnNext.TabIndex = 8;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScore.Location = new Point(460, 40);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(141, 38);
            lblScore.TabIndex = 9;
            lblScore.Text = "Score: 0/0";
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimer.Location = new Point(607, 40);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(166, 38);
            lblTimer.TabIndex = 10;
            lblTimer.Text = "Time: 0m 0s";
            // 
            // quizTimer
            // 
            quizTimer.Interval = 1000;
            quizTimer.Tick += quizTimer_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Location = new Point(-68, -11);
            panel1.Name = "panel1";
            panel1.Size = new Size(1529, 101);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(lblQuestion);
            panel2.Location = new Point(-6, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(1464, 52);
            panel2.TabIndex = 12;
            // 
            // PlayForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 450);
            Controls.Add(lblScore);
            Controls.Add(lblTimer);
            Controls.Add(btnNext);
            Controls.Add(radTFFalse);
            Controls.Add(radTFTrue);
            Controls.Add(txtUserAnswer);
            Controls.Add(radOpt4);
            Controls.Add(radOpt3);
            Controls.Add(radOpt2);
            Controls.Add(radOpt1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "PlayForm";
            Text = "PlayForm";
            Load += PlayForm_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private Panel panel1;
        private BindingSource bindingSource1;
        private Panel panel2;
    }
}