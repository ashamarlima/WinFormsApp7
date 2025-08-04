namespace WinFormsApp7
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnPlay = new Button();
            btnCreate = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(640, 282);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(127, 55);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(640, 343);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(127, 55);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Edit";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(456, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(493, 268);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 539);
            Controls.Add(pictureBox1);
            Controls.Add(btnCreate);
            Controls.Add(btnPlay);
            Name = "MainForm";
            Text = "The Squiz Game";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPlay;
        private Button btnCreate;
        private PictureBox pictureBox1;
    }
}
