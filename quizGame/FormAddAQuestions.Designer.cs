namespace quizGame
{
    partial class FormAddAQuestions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contentText = new System.Windows.Forms.TextBox();
            this.ListAnswer = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textAnswer = new System.Windows.Forms.TextBox();
            this.checkIsTrue = new System.Windows.Forms.CheckBox();
            this.cmdAddAnswer = new System.Windows.Forms.Button();
            this.cmdAddQuestion = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Content";
            // 
            // contentText
            // 
            this.contentText.Location = new System.Drawing.Point(116, 183);
            this.contentText.Multiline = true;
            this.contentText.Name = "contentText";
            this.contentText.Size = new System.Drawing.Size(1074, 78);
            this.contentText.TabIndex = 3;
            // 
            // ListAnswer
            // 
            this.ListAnswer.FormattingEnabled = true;
            this.ListAnswer.ItemHeight = 16;
            this.ListAnswer.Location = new System.Drawing.Point(116, 291);
            this.ListAnswer.Name = "ListAnswer";
            this.ListAnswer.Size = new System.Drawing.Size(1074, 84);
            this.ListAnswer.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input Answer";
            // 
            // textAnswer
            // 
            this.textAnswer.Location = new System.Drawing.Point(116, 426);
            this.textAnswer.Multiline = true;
            this.textAnswer.Name = "textAnswer";
            this.textAnswer.Size = new System.Drawing.Size(391, 34);
            this.textAnswer.TabIndex = 6;
            // 
            // checkIsTrue
            // 
            this.checkIsTrue.AutoSize = true;
            this.checkIsTrue.Location = new System.Drawing.Point(536, 440);
            this.checkIsTrue.Name = "checkIsTrue";
            this.checkIsTrue.Size = new System.Drawing.Size(117, 20);
            this.checkIsTrue.TabIndex = 7;
            this.checkIsTrue.Text = "Is True Answer";
            this.checkIsTrue.UseVisualStyleBackColor = true;
            // 
            // cmdAddAnswer
            // 
            this.cmdAddAnswer.Location = new System.Drawing.Point(116, 480);
            this.cmdAddAnswer.Name = "cmdAddAnswer";
            this.cmdAddAnswer.Size = new System.Drawing.Size(224, 43);
            this.cmdAddAnswer.TabIndex = 8;
            this.cmdAddAnswer.Text = "Add to Answer";
            this.cmdAddAnswer.UseVisualStyleBackColor = true;
            this.cmdAddAnswer.Click += new System.EventHandler(this.cmdAddAnswer_Click);
            // 
            // cmdAddQuestion
            // 
            this.cmdAddQuestion.Location = new System.Drawing.Point(783, 440);
            this.cmdAddQuestion.Name = "cmdAddQuestion";
            this.cmdAddQuestion.Size = new System.Drawing.Size(224, 83);
            this.cmdAddQuestion.TabIndex = 9;
            this.cmdAddQuestion.Text = "Add Question";
            this.cmdAddQuestion.UseVisualStyleBackColor = true;
            this.cmdAddQuestion.Click += new System.EventHandler(this.cmdAddQuestion_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(596, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(594, 141);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormAddAQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 535);
            this.Controls.Add(this.cmdAddQuestion);
            this.Controls.Add(this.cmdAddAnswer);
            this.Controls.Add(this.checkIsTrue);
            this.Controls.Add(this.textAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListAnswer);
            this.Controls.Add(this.contentText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "FormAddAQuestions";
            this.Text = "FormAddAQuestions";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contentText;
        private System.Windows.Forms.ListBox ListAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAnswer;
        private System.Windows.Forms.CheckBox checkIsTrue;
        private System.Windows.Forms.Button cmdAddAnswer;
        private System.Windows.Forms.Button cmdAddQuestion;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}