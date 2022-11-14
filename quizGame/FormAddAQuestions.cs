using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace quizGame
{
    public partial class FormAddAQuestions : Form
    {
        public FormAddAQuestions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void cmdAddAnswer_Click(object sender, EventArgs e)
        {
            string answer = " (" + (checkIsTrue.Checked ? "1" : "0") + ")";
            ListAnswer.Items.Add(textAnswer.Text + answer);
            textAnswer.Text = "";
            checkIsTrue.Checked = false;
        }

        private void cmdAddQuestion_Click(object sender, EventArgs e)
        {
            QuestionAndAnswerDataContext db = new QuestionAndAnswerDataContext();
            Question q = new Question();
            q.ContentQuestion = contentText.Text;
            q.Point = 1;
            byte[] imageSelected = File.ReadAllBytes(openFileDialog1.FileName);  //chuyen file da chon sang dang byte[] de luu vao csdl
            q.Image = imageSelected; // gan vao csdl////////
            db.Questions.InsertOnSubmit(q); // insert object vao bang questions o trang thai chen, cho xu ly
            db.SubmitChanges(); //dua du lieu vua insert vao csdl

            foreach (var i in ListAnswer.Items)
            {
                Answer ans = new Answer();
                ans.IDQuestion = q.IDQuestion;
                int p = i.ToString().LastIndexOf("(");
                bool rs = false;
                if (i.ToString()[p + 1] == '1')
                    rs = true;

                ans.ContentAnswer = i.ToString().Substring(0, i.ToString().Length - 3);
                ans.Result = rs;

                db.Answers.InsertOnSubmit(ans);
                db.SubmitChanges();

            }
            MessageBox.Show("Thêm câu hỏi thành công");
            this.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
        }

        //chuyen tu file sang anh de hien thi len form


    }
}
