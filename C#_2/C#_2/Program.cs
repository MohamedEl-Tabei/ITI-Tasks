namespace C__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////0//1//2//3//4//5//6//7//8//9///10//11//12//13
            int[] arr ;
            Console.Write("Array Size: ");
            int size=int.Parse(Console.ReadLine());
            arr = new int[size];
            for(int i = 0; i < size; i++)
            {
                Console.Write($"index {i} = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int d = 0;
            int maxD = 0;
            for (int i = 0; i < arr.Length; i++) {
                d = 0;
                for (int j = i+1; j < arr.Length; j++) {
                    if (arr[j] == arr[i]) d=j-i-1; 
                }
                if(d > maxD) maxD = d;
            }
            Console.WriteLine(maxD);
        }
    }
}
