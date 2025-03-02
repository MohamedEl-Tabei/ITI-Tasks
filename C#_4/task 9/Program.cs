namespace task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NIC nic1 = NIC.GetInstance("Intel", "00", NICType.Ethernet);
            NIC nic2 = NIC.GetInstance("Intel", "11", NICType.TokenRing);

            Console.WriteLine(nic1.GetHashCode());
            Console.WriteLine(nic2.GetHashCode());

            Console.WriteLine("=================================");

            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1);
            Console.WriteLine("=================================");

            Duration D2 = new Duration(7800);
            Console.WriteLine(D2);
            Console.WriteLine("=================================");

            Duration D3 = D1 + D2;
            Console.WriteLine(D3);
            Console.WriteLine("=================================");

            D3 = D1 + 7800;
            Console.WriteLine(D3);
            Console.WriteLine("=================================");

            D3 = 666 + D3;
            Console.WriteLine(D3);
            Console.WriteLine("=================================");

            D3 = D1++;
            Console.WriteLine(D3);
            Console.WriteLine("=================================");

            D3 = --D2;
            Console.WriteLine(D3);
            Console.WriteLine("=================================");

            Console.WriteLine(D1 > D2);
            Console.WriteLine("=================================");
            Console.WriteLine(D1 <= D2);
            Console.WriteLine("=================================");

            if (D1)
            {
                DateTime dt = (DateTime)D1;
                Console.WriteLine($"Converted DateTime: {dt}");
            }
        }
    }
}

