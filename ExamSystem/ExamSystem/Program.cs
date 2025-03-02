using System.Runtime.Intrinsics.X86;
using ExamSystem.Exams;
using ExamSystem.Interfaces;
using ExamSystem.Questions;

namespace ExamSystem
{
    internal class Program
    {
        static void writeOnFile() {
            var file = new StreamWriter("../../../data.txt");
            //1
            file.Write("Which keyword is used to prevent a class from being inherited in C#?");
            file.Write("*");
            file.Write(5);
            file.Write("*");
            file.Write("sealed,");
            file.Write("static,");
            file.Write("final,");
            file.Write("private");
            file.Write("*");
            file.Write("sealed");
            file.Write("`");
            //2
            file.Write("What is the default value of a boolean variable in C#?");
            file.Write("*");
            file.Write(5);
            file.Write("*");
            file.Write("False,");
            file.Write("True");
            file.Write("*");
            file.Write("False");
            file.Write("`");
            //3
            file.Write("What is the main use of delegates in C#?");
            file.Write("*");
            file.Write(5);
            file.Write("*");
            file.Write("To handle exceptions,");
            file.Write("To allow methods to be passed as parameters,");
            file.Write("To define classes,");
            file.Write("To manage memory");
            file.Write("*");
            file.Write("To allow methods to be passed as parameters");
            file.Close();
        
        }
        static void Main(string[] args)
        {
            IExam exam ;
            string examType;
            string fromUser;
            #region Exam Data
            string examName="C#";
            int examDuration = 3;
            DateTime exameDate = DateTime.Now;
            
            writeOnFile();
            #endregion
            do
            {
                #region Home
                do
                {
                    Console.Clear();
                    Console.WriteLine("Home");
                    Console.WriteLine("----");
                    Console.WriteLine("Select the Exam type");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Enter 1 for practical exam");
                    Console.WriteLine("Enter 2 for final exam");
                    Console.WriteLine("--------------------");
                    examType = Console.ReadLine();
                } while (examType != "1" && examType != "2");
                examType = examType == "1" ? "p" : "f";
                #endregion
                exam = examType == "f" ? FinalExam.creat(examName, exameDate, examDuration) : PracticalExam.create(examName, exameDate, examDuration);
                exam.test();
                #region Exam

                exam.start();
                exam.end();
                #endregion
                Console.Clear();
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("Press Escape To close The Program Or any key to Home");
                Console.WriteLine("-------------------------------------------------------");
                fromUser = Console.ReadKey().ToString();
            } while (fromUser != "Escape");
        }
    }
}







