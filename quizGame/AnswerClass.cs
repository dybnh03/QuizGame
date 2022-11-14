using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizGame
{
    public class AnswerClass
    {
        public int idAnswer;
        public int idQuestion;
        public string contentAnswer;
        public bool result;
        public AnswerClass() { }
        public AnswerClass(int idAnswer, int idQuestion, string contentAnswer, bool result)
        {
            this.idAnswer = idAnswer;
            this.idQuestion = idQuestion;
            this.contentAnswer = contentAnswer;
            this.result = result;
        }
    }



}
