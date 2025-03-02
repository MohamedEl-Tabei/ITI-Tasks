using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Interfaces
{
    internal interface IQuestion
    {
        public string Head { get; }
        public int Mark { get; }
        public List<Answer> Choices { get; }
    }
}
