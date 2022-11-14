using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizGame
{
    public partial class FormListQuestion : Form
    {
        public FormListQuestion()
        {
            InitializeComponent();
            FormListQuestion_Load();


        }


        private void FormListQuestion_Load()
        {
            var db = new QuestionAndAnswerDataContext();
            var sqlData = from b in db.Questions
                          select new
                          {
                              b.IDQuestion,
                              b.ContentQuestion,
                              b.Point,
                              SumOfAnswer = b.Answers.Count()
                          };
            dataGridView1.DataSource = sqlData;


        }



    }


    


}
