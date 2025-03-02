using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Interfaces;
using ExamSystem.Questions;

namespace ExamSystem.Exams
{
    internal abstract class Exam : IExam
    {
        protected static IExam Instance { get; set; } = null;
        public string Name { get; set; } 
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public Dictionary<IQuestion, Answer> Questions { get; set; }
        public static string Type { get; set; }
        public int Degree { get; set; } = 0;
        public int TotalDegree { get; set; } = 0;

        protected Exam(string name, DateTime date, int duration,  string type) 
        {
            Name = name;
            Date = date;
            Duration = duration;
            Type = type;
            readDataFromFile();
        }

        public string getExamDetails()
        {
            return $"{Type} Exam\nExam \t: {Name}\nDate\t: {Date}\nTotal\t: {TotalDegree}\nDuration: {Duration} minutes\n--------------------------";
        }

        public virtual void test()
        {
            Console.WriteLine("Parent");
        }

        public void start()
        {
            foreach (var question in Questions.Keys) {
                var answer = Questions[question];
                string userAnswer;
                int userAnswerNum;
                #region Get Answer From User
                do {
                    Console.Clear() ;
                    Console.WriteLine(getExamDetails());
                    Console.WriteLine(question);
                    Console.Write("\n--------------------------\nEnter Your Answer: ");
                    userAnswer=Console.ReadLine();
                    

                } while (!int.TryParse(userAnswer, out userAnswerNum) || userAnswerNum < 0 || userAnswerNum > question.Choices.Count);
                Degree = answer == question.Choices[userAnswerNum-1] ? Degree + question.Mark : Degree;
                if (Type == "Practical")
                {
                    Console.WriteLine($"--------------------------\nAnswer: {answer}");
                    Console.WriteLine($"--------------------------\nDegree: {Degree}/{TotalDegree}");
                    Console.WriteLine("Press any key");
                    Console.ReadKey();
                }

                #endregion
            }
        }
        public virtual void end()
        {
        }

        public void readDataFromFile()
        {
            Questions = new Dictionary<IQuestion, Answer>();
            TotalDegree = 0;
            var file = new StreamReader("../../../data.txt");
            var data = file.ReadToEnd();
            string[] questions = data.Split("`");
            string[] qElements;
            foreach (var question in questions)
            {
                qElements = question.Split("*");
                var choicesArr = qElements[2].Split(",");
                var choices = new List<Answer>();
                foreach (var choice in choicesArr) choices.Add(new Answer(choice));
                if (choices.Count == 2)
                    Questions.Add(new TFQ(qElements[0], int.Parse(qElements[1])), new Answer(qElements[3]));
                else
                    Questions.Add(new MCQ(qElements[0], int.Parse(qElements[1]), choices), new Answer(qElements[3]));
                TotalDegree += int.Parse(qElements[1]);
            }
            file.Close();
        }
    }
}
