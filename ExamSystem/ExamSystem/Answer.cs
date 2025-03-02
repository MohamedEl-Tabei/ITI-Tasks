using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class Answer
    {
        public string Content { get; }
        public Answer(string content)
        {
            Content = content;
        }
        public override string ToString()
        {
            return Content;
        }

        static public bool operator ==(Answer modelAnswer, Answer userAnswer)
        {
            return modelAnswer.Content==userAnswer.Content;
        }
        static public bool operator !=(Answer modelAnswer, Answer userAnswer)
        {
            return modelAnswer.Content != userAnswer.Content;
        }
    }
    
}
