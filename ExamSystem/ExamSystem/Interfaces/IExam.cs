using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Interfaces
{
    internal interface IExam
    {
        public static IExam Instance { get; set; }
        public string Name { get; set; }
        public static string Type {  get; set; }
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public int Degree {  get; set; }
        public int TotalDegree {  get; set; }
        public Dictionary<IQuestion, Answer> Questions { get;  }
        public string getExamDetails();
        public void test(); //dev
        public void start();
        public void end();
        public void readDataFromFile();
    }
}
