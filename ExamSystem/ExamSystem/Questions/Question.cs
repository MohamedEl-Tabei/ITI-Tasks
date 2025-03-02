using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Interfaces;

namespace ExamSystem.Questions
{
    internal abstract class Question : IQuestion
    {
        public string Head { get; }

        public int Mark { get; }

        public List<Answer> Choices { get; }

        private Question(List<Answer> choices)
        {
            Choices = new List<Answer>();
            for (int i = 0; i < choices.Count; i++)
                Choices.Add(choices[i]);
            choices.Clear();
        }

        public Question(string head, int mark, List<Answer> choices) : this(choices)
        {
            Head = head;
            Mark = mark;
        }
    }
}
