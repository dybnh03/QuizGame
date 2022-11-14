using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizGame
{
    public class QuestionClass
    {
        public int iDQuestion;
        public string contentQuestion;
        public double point;
        public byte[] image;

        public QuestionClass()
        {
        }

        public QuestionClass(int iDQuestion, string contentQuestion, double point)
        {
            this.iDQuestion = iDQuestion;
            this.contentQuestion = contentQuestion;
            this.point = point;
        }

        



    }
}
