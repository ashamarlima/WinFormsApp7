namespace WinFormsApp7
{
    partial class CreateForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            cmbType = new ComboBox();
            txtQuestion = new TextBox();
            panelMCQ = new Panel();
            txtOpt1 = new TextBox();
            txtOpt2 = new TextBox();
            txtOpt3 = new TextBox();
            txtOpt4 = new TextBox();
            cmbCorrect = new ComboBox();
            panelOpen = new Panel();
            txtAcceptable = new TextBox();
            panelTF = new Panel();
            radTrue = new RadioButton();
            radFalse = new RadioButton();
            btnAdd = new Button();
            btnCancelEdit = new Button();
            lstQuestions = new ListBox();
            btnDelete = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panelMCQ.SuspendLayout();
            panelOpen.SuspendLayout();
            panelTF.SuspendLayout();
            SuspendLayout();
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Location = new Point(535, 19);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(200, 28);
            cmbType.TabIndex = 0;
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(535, 59);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(300, 27);
            txtQuestion.TabIndex = 1;
            // 
            // panelMCQ
            // 
            panelMCQ.Controls.Add(txtOpt1);
            panelMCQ.Controls.Add(txtOpt2);
            panelMCQ.Controls.Add(txtOpt3);
            panelMCQ.Controls.Add(txtOpt4);
            panelMCQ.Controls.Add(cmbCorrect);
            panelMCQ.Location = new Point(535, 99);
            panelMCQ.Name = "panelMCQ";
            panelMCQ.Size = new Size(300, 140);
            panelMCQ.TabIndex = 2;
            panelMCQ.Visible = false;
            // 
            // txtOpt1
            // 
            txtOpt1.Location = new Point(0, 0);
            txtOpt1.Name = "txtOpt1";
            txtOpt1.Size = new Size(140, 27);
            txtOpt1.TabIndex = 0;
            txtOpt1.Text = "Option1";
            // 
            // txtOpt2
            // 
            txtOpt2.Location = new Point(150, 0);
            txtOpt2.Name = "txtOpt2";
            txtOpt2.Size = new Size(140, 27);
            txtOpt2.TabIndex = 1;
            txtOpt2.Text = "Option2";
            // 
            // txtOpt3
            // 
            txtOpt3.Location = new Point(0, 35);
            txtOpt3.Name = "txtOpt3";
            txtOpt3.Size = new Size(140, 27);
            txtOpt3.TabIndex = 2;
            txtOpt3.Text = "Option3";
            // 
            // txtOpt4
            // 
            txtOpt4.Location = new Point(150, 35);
            txtOpt4.Name = "txtOpt4";
            txtOpt4.Size = new Size(140, 27);
            txtOpt4.TabIndex = 3;
            txtOpt4.Text = "Option4";
            // 
            // cmbCorrect
            // 
            cmbCorrect.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCorrect.Location = new Point(0, 70);
            cmbCorrect.Name = "cmbCorrect";
            cmbCorrect.Size = new Size(290, 28);
            cmbCorrect.TabIndex = 4;
            // 
            // panelOpen
            // 
            panelOpen.Controls.Add(txtAcceptable);
            panelOpen.Location = new Point(535, 99);
            panelOpen.Name = "panelOpen";
            panelOpen.Size = new Size(300, 40);
            panelOpen.TabIndex = 3;
            panelOpen.Visible = false;
            // 
            // txtAcceptable
            // 
            txtAcceptable.Location = new Point(0, 0);
            txtAcceptable.Name = "txtAcceptable";
            txtAcceptable.Size = new Size(300, 27);
            txtAcceptable.TabIndex = 0;
            // 
            // panelTF
            // 
            panelTF.Controls.Add(radTrue);
            panelTF.Controls.Add(radFalse);
            panelTF.Location = new Point(535, 99);
            panelTF.Name = "panelTF";
            panelTF.Size = new Size(300, 40);
            panelTF.TabIndex = 4;
            panelTF.Visible = false;
            // 
            // radTrue
            // 
            radTrue.Location = new Point(0, 0);
            radTrue.Name = "radTrue";
            radTrue.Size = new Size(104, 24);
            radTrue.TabIndex = 0;
            radTrue.Text = "True";
            // 
            // radFalse
            // 
            radFalse.Location = new Point(100, 0);
            radFalse.Name = "radFalse";
            radFalse.Size = new Size(104, 24);
            radFalse.TabIndex = 1;
            radFalse.Text = "False";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(535, 249);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 30);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add Question";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.Location = new Point(675, 249);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(120, 30);
            btnCancelEdit.TabIndex = 6;
            btnCancelEdit.Text = "Cancel Edit";
            btnCancelEdit.Click += btnCancelEdit_Click;
            // 
            // lstQuestions
            // 
            lstQuestions.Location = new Point(20, 20);
            lstQuestions.Name = "lstQuestions";
            lstQuestions.Size = new Size(488, 244);
            lstQuestions.TabIndex = 7;
            lstQuestions.DoubleClick += lstQuestions_DoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(258, 270);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(250, 30);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete Selected";
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(535, -4);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 9;
            label1.Text = "Quiz type";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(12, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 411);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Location = new Point(518, -5);
            panel2.Name = "panel2";
            panel2.Size = new Size(549, 421);
            panel2.TabIndex = 11;
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1377, 419);
            Controls.Add(label1);
            Controls.Add(cmbType);
            Controls.Add(txtQuestion);
            Controls.Add(panelMCQ);
            Controls.Add(panelOpen);
            Controls.Add(panelTF);
            Controls.Add(btnAdd);
            Controls.Add(btnCancelEdit);
            Controls.Add(lstQuestions);
            Controls.Add(btnDelete);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "CreateForm";
            Text = "Create Questions";
            Load += CreateForm_Load;
            panelMCQ.ResumeLayout(false);
            panelMCQ.PerformLayout();
            panelOpen.ResumeLayout(false);
            panelOpen.PerformLayout();
            panelTF.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbType;
        private TextBox txtQuestion;
        private Panel panelMCQ;
        private TextBox txtOpt1;
        private TextBox txtOpt2;
        private TextBox txtOpt3;
        private TextBox txtOpt4;
        private ComboBox cmbCorrect;
        private Panel panelOpen;
        private TextBox txtAcceptable;
        private Panel panelTF;
        private RadioButton radTrue;
        private RadioButton radFalse;
        private Button btnAdd;
        private Button btnCancelEdit;
        private ListBox lstQuestions;
        private Button btnDelete;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
    }
}
