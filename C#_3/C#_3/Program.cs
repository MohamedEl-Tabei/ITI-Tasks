namespace C__3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1
            var p3ds = new Point3D[3];

            for (int i = 0; i < p3ds.Length; i++)
            {
                p3ds[i] = new Point3D();
                //int.TryParse(Console.ReadLine(),out p3ds[i].X);
                int x;
                Console.Write("X: ");
                p3ds[i].X = int.TryParse(Console.ReadLine(), out x) ? x : p3ds[i].X;

                Console.Write("Y: ");
                p3ds[i].Y = int.Parse(Console.ReadLine());

                Console.Write("Z: ");
                p3ds[i].Z = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("---------------------");
            }
            for (int i = 0; i < p3ds.Length; i++)
            {
                Console.WriteLine(p3ds[i]);
            }
            #endregion

            #region 2
            var M = new Math_();
            int res = 0;
            M.Add(5, 6, out res);
            Console.WriteLine($"5+6={res}");

            res = M.Subtract(50, 60);
            Console.WriteLine($"50-60={res}");

            M.Multiply(5, 6, ref res);
            Console.WriteLine($"5*6={res}");

            double res_= M.Divide(500, 100);
            Console.WriteLine($"500/100={res_}");

            #endregion

        }
    }
}
