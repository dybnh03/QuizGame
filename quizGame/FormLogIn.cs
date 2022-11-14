using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace quizGame
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=D-BINH;Initial Catalog=LogIn;Integrated Security=True");


            con.Open();
            string user = textUserName.Text;
            string pass = textPassWord.Text;





            if (checkTeacher.Checked == true)
            {
                string sqlT = "SELECT * FROM [Teacher]  where UserName = '" + user + "' and Pass = '" + pass + "'";
                SqlCommand cmdT = new SqlCommand(sqlT, con); // tao doi tuong de thi hanh cac cau lenh sql tuong tac voi sql server nhu insert, select, ....
                SqlDataReader drT = cmdT.ExecuteReader(); // chay cau lenh select tren
                if (drT.Read() == true)
                {
                    FormOption frmOption = new FormOption();
                    textUserName.Clear();
                    textPassWord.Clear();
                    checkTeacher.Checked = false;
                    frmOption.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập, mật khẩu hoặc đối tượng sai");
                }

            }









            if (checkStudent.Checked == true)
            {
                string sqlS = "SELECT * FROM [Student]  where UserName = '" + user + "' and Pass = '" + pass + "'";
                SqlCommand cmdS = new SqlCommand(sqlS, con);
                SqlDataReader drS = cmdS.ExecuteReader(); // chay cau lenh select tren
                if (drS.Read() == true)
                {
                    FormStart frmStart = new FormStart();
                    textUserName.Clear();
                    textPassWord.Clear();
                    checkStudent.Checked = false;
                    frmStart.ShowDialog();
                    

                }
                else
                {
                    MessageBox.Show("Tên đăng nhập, mật khẩu hoặc đối tượng sai");
                }




            }


            




        }








        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
