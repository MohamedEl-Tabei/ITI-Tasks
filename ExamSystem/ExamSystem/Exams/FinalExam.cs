using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Interfaces;
using Microsoft.VisualBasic;

namespace ExamSystem.Exams
{
    internal class FinalExam : Exam
    {
        private FinalExam(string name, DateTime date, int duration) : base(name, date, duration,"Final"){}

        public static IExam creat(string name, DateTime date, int duration)
        {
            if (Instance == null||Type == "Practical") Instance = new FinalExam(name,date,duration);
            return Instance;
        }
        public override void test()
        {
            Console.WriteLine("Final");
        }
        public override void end()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"Your Degree: {Degree} From {TotalDegree}");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("\nPress Any Key: ");
            Console.ReadKey();

        }
    }
}
