using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizGame
{
    public partial class FormQuiz : Form
    {

        // variables list for this quiz game
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        //Khởi tạo list các class để sử dụng
        List<QuestionClass> quesList = new List<QuestionClass>();
        List<AnswerClass> ansList = new List<AnswerClass>();
        List<AnswerClass> innerAnsList = new List<AnswerClass>(); //Dùng để lọc


        public FormQuiz()
        {
            InitializeComponent();
            //gán dữ liệu vào các list đã khởi tạo
            innitializeForm();
            //gen giao diện bao gồm các button câu trả lời  và label câu hỏi (khởi tạo ban đầu)
            generateQuestion(questionNumber);
        }


        /// Sự kiện click của button câu trả lời
        private void ClickAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);



            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage here
                percentage = ((100 * score) / totalQuestions);


                MessageBox.Show("Kết thúc trắc nghiệm" + Environment.NewLine +
                                "Bạn trả lời đúng " + score + " câu hỏi" + Environment.NewLine +
                                "Tỷ lệ hoàn thành đúng là  " + percentage + " %" );

                DialogResult result = MessageBox.Show("Bạn muốn chơi lại hay đăng xuất", "Chơi lại chọn Yes, Đăng xuất chọn No",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    score = 0;
                    questionNumber = 0;
                }
                else 
                {
                    score = 0;
                    questionNumber = 0;
                    this.Close();
                    

                }
               

                
            }
            questionNumber++;
            generateQuestion(questionNumber);
        }







        


        /// Khởi chạy lúc đầu để gán các giá trị cho tham số
        private void innitializeForm()
        {
            //Lấy dữ liệu lên từ database
            var database = new QuestionAndAnswerDataContext();
            //Đẩy dữ liệu vào 2 danh sách
            quesList = (from q in database.Questions.ToList()
                        select new QuestionClass
                        {
                            iDQuestion = q.IDQuestion,
                            contentQuestion = q.ContentQuestion,
                            point = q.Point,
                            image = q.Image.ToArray()
                        }).ToList();
            //set tổng số câu hỏi
            totalQuestions = quesList.Count;

            ansList = (from a in database.Answers
                       select new AnswerClass
                       {
                           idAnswer = a.IDAnswer,
                           idQuestion = a.IDQuestion,
                           contentAnswer = a.ContentAnswer,
                           result = a.Result
                       }).ToList();





        }


        /// gán dữ liệu và hiển thị lên form
        private void generateQuestion(int questionNo)
        {
            //Câu hỏi
            lblQuestion.Text = quesList[questionNo - 1].contentQuestion;




            pictureBox1.Image = ByteToImage(quesList[questionNo - 1].image);





            //lọc danh sách câu trả lời theo câu hỏi
            innerAnsList = ansList.Where(a => a.idQuestion == quesList[questionNo - 1].iDQuestion).ToList();

            //Xóa các button đã được gán vào trong panel
            panelAnswer.Controls.Clear();

            for (int k = 0; k < innerAnsList.Count; k++)
            {
                //Tạo button để gán vào trong panel
                Button mybutton = new Button();
                mybutton.Text = innerAnsList[k].contentAnswer;
                mybutton.Width = 200;
                //Gắn sự kiện click cho button
                mybutton.Click += new EventHandler(ClickAnswerEvent);

                if (innerAnsList[k].result)
                {
                    correctAnswer = k;
                    mybutton.Tag = correctAnswer;
                }
                panelAnswer.Controls.Add(mybutton);
            }









        }


        /// Chuyển byte[] sang file ảnh để hiển thị trong picturebox (Copy)
        public static Bitmap ByteToImage(byte[] blob)  
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

    }
}

