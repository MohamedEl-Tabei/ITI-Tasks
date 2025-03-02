using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Interfaces;

namespace ExamSystem.Exams
{
    internal class PracticalExam : Exam
    {
        private PracticalExam(string name, DateTime date, int duration) : base(name, date, duration,  "Practical"){}

        public static IExam create(string name, DateTime date, int duration)
        {
            if (Instance == null||Type=="Final")
                Instance = new PracticalExam(name,date,duration);
            return Instance;
        }
        public override void test()
        {
            Console.WriteLine("Practical");
        }
    }
}
