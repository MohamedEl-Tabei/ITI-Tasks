namespace _3DPoint
{
    internal class Program
    {
        static void printPoints(Point3D[] arr) {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            #region Point3D
            int x;
            int y;
            int z;
            var Points = new Point3D[3];
            for (int i = 0; i < Points.Length; i++)
            {
                Console.Write("X: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Y: ");
                y = int.Parse(Console.ReadLine());
                Console.Write("Z: ");
                z = int.Parse(Console.ReadLine());
                Console.Write("--------------------------------------------\n");
                Points[i] = new Point3D(x, y, z);
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Equals");
            Console.WriteLine(Points[0].Equals(Points[1]));
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Before Sort");
            printPoints(Points);
            Console.WriteLine("------------");
            Console.WriteLine("After Sort");
            Array.Sort(Points);
            printPoints(Points);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("new point");
            var point = Points[0].Clone();
            Console.WriteLine(point);
            Console.WriteLine($"Points[0]: {Points[0].GetHashCode()}");
            Console.WriteLine($"point: {point.GetHashCode()}");
            #endregion
            #region Math
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"1+2={Math_.Add(1,2)}");
            Console.WriteLine($"1-2={Math_.Subtract(1,2)}");
            Console.WriteLine($"1/2={Math_.Divide(1,2)}");
            Console.WriteLine($"1*2={Math_.Multiply(1,2)}");
            #endregion

        }
    }
}
