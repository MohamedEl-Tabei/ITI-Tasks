using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Questions
{
    internal class MCQ : Question
    {
        public MCQ(string head, int mark, List<Answer> choices) : base(head, mark, choices) { }
        public override string ToString()
        {
            return $"\n{Head}:{Mark}\n1.{Choices[0]}\n2.{Choices[1]}\n3.{Choices[2]}\n4.{Choices[3]}";
        }
    }
}
