using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Questions
{
    internal class TFQ : Question
    {
        public TFQ(string head, int mark):base(head,mark, new List<Answer>() { new Answer("True"), new Answer("False") }){}
        public override string ToString()
        {
            return $"\n{Head}:{Mark}\n1.{Choices[0]}\n2.{Choices[1]}";
        }
    }
}
