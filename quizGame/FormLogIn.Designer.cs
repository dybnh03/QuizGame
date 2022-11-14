namespace quizGame
{
    partial class FormLogIn
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.textPassWord = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.checkTeacher = new System.Windows.Forms.RadioButton();
            this.checkStudent = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "LOG IN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "USERNAME";
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(275, 115);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(274, 22);
            this.textUserName.TabIndex = 4;
            // 
            // textPassWord
            // 
            this.textPassWord.Location = new System.Drawing.Point(275, 208);
            this.textPassWord.Name = "textPassWord";
            this.textPassWord.Size = new System.Drawing.Size(274, 22);
            this.textPassWord.TabIndex = 5;
            this.textPassWord.UseSystemPasswordChar = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(425, 299);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 45);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(275, 299);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(125, 45);
            this.btnLogIn.TabIndex = 7;
            this.btnLogIn.Text = "LOG IN";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // checkTeacher
            // 
            this.checkTeacher.AutoSize = true;
            this.checkTeacher.Location = new System.Drawing.Point(275, 260);
            this.checkTeacher.Name = "checkTeacher";
            this.checkTeacher.Size = new System.Drawing.Size(79, 20);
            this.checkTeacher.TabIndex = 8;
            this.checkTeacher.TabStop = true;
            this.checkTeacher.Text = "Teacher";
            this.checkTeacher.UseVisualStyleBackColor = true;
            // 
            // checkStudent
            // 
            this.checkStudent.AutoSize = true;
            this.checkStudent.Location = new System.Drawing.Point(425, 260);
            this.checkStudent.Name = "checkStudent";
            this.checkStudent.Size = new System.Drawing.Size(73, 20);
            this.checkStudent.TabIndex = 9;
            this.checkStudent.TabStop = true;
            this.checkStudent.Text = "Student";
            this.checkStudent.UseVisualStyleBackColor = true;
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkStudent);
            this.Controls.Add(this.checkTeacher);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.textPassWord);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormLogIn";
            this.Text = "FormDangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.TextBox textPassWord;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.RadioButton checkTeacher;
        private System.Windows.Forms.RadioButton checkStudent;
    }
}