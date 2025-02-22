using System.Diagnostics;

namespace numberOf1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 999999999;
            Stopwatch s1 = new Stopwatch();
            Console.WriteLine("-------------- 1 ------------");
            s1.Start();
            Console.WriteLine(fun1(num));
            s1.Stop();
            Console.WriteLine(s1.Elapsed);
            Stopwatch s2 = new Stopwatch();
            Console.WriteLine("-------------- 2 ------------");
            s2.Start();
            Console.WriteLine(fun2(num));
            s2.Stop();
            Console.WriteLine(s2.Elapsed);
            Stopwatch s3 = new Stopwatch();
            Console.WriteLine("-------------- 3 ------------");
            s3.Start();
            Console.WriteLine(fun3(num));
            s3.Stop();
            Console.WriteLine(s3.Elapsed);
            #region 1
            int fun1(int num)
            {
                int count = 0;
                string str = "";
                while (num > 0)
                {
                    str = $"{num}";
                    if (str.Contains('1'))
                    {
                        for (int i = 0; i < str.Length; i++)
                        {
                            if(str[i] == '1') count++;
                        }
                    };
                    num--;
                }
                return count;
            }
            #endregion
            #region 2
            int fun2(int num) {
                int res=0;
                int x;
                int y;
                while (num > 0) {
                    x = num % 10;
                    y = num / 10;
                    while (y >0) {
                        if (x == 1) res++;
                        x= y % 10;
                        y= y / 10;
                    }
                    if (x == 1) res++;
                    num--;
                }
                return res;
            }
            #endregion
            #region 3
            double fun3(int num)
            {
                int n=num.ToString().Length;
                return n*Math.Pow(10,n-1);
            }
            #endregion
        }
    }
}



/////0->9   1
/////0->99  20
/////0->999 300
/////0->9999 4000