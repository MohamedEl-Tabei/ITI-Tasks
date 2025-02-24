
namespace reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Welcome to ITI";
            var strArr=str.Split(' ');
            //strArr = strArr.Reverse().ToArray();
            //Array.Reverse(strArr);
            string newStr = string.Join(' ',strArr);
            
            Console.WriteLine(newStr);
        }
    }
}
