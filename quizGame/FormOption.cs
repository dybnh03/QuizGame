using System;
using System.Windows.Forms;

namespace quizGame
{
    public partial class FormOption : Form
    {
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionToolStripMenuItem;
        private ToolStripMenuItem listQuestionBTN;
        private ToolStripMenuItem addNewQuestionBTN;
        private Button SignOutBTN;
        private System.ComponentModel.IContainer components;

        public FormOption()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }


        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listQuestionBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewQuestionBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.SignOutBTN = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listQuestionBTN,
            this.addNewQuestionBTN});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(69, 26);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // listQuestionBTN
            // 
            this.listQuestionBTN.Name = "listQuestionBTN";
            this.listQuestionBTN.Size = new System.Drawing.Size(197, 26);
            this.listQuestionBTN.Text = "List Question";
            this.listQuestionBTN.Click += new System.EventHandler(this.listQuestionBTN_Click_1);
            // 
            // addNewQuestionBTN
            // 
            this.addNewQuestionBTN.Name = "addNewQuestionBTN";
            this.addNewQuestionBTN.Size = new System.Drawing.Size(197, 26);
            this.addNewQuestionBTN.Text = "Add A Question";
            this.addNewQuestionBTN.Click += new System.EventHandler(this.addNewQuestionBTN_Click_1);
            // 
            // SignOutBTN
            // 
            this.SignOutBTN.Location = new System.Drawing.Point(423, 189);
            this.SignOutBTN.Name = "SignOutBTN";
            this.SignOutBTN.Size = new System.Drawing.Size(110, 49);
            this.SignOutBTN.TabIndex = 1;
            this.SignOutBTN.Text = "Đăng xuất";
            this.SignOutBTN.UseVisualStyleBackColor = true;
            this.SignOutBTN.Click += new System.EventHandler(this.SignOutBTN_Click);
            // 
            // FormOption
            // 
            this.ClientSize = new System.Drawing.Size(964, 433);
            this.Controls.Add(this.SignOutBTN);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormOption";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void listQuestionBTN_Click_1(object sender, EventArgs e)
        {
            FormListQuestion f = new FormListQuestion();
            f.ShowDialog();
        }

        private void addNewQuestionBTN_Click_1(object sender, EventArgs e)
        {
            
            FormAddAQuestions f = new FormAddAQuestions();
            f.ShowDialog();
        }

        private void SignOutBTN_Click(object sender, EventArgs e)
        {
            
            FormOption.ActiveForm.Close();
            
        }
    }
}
