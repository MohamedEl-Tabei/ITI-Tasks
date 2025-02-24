using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__3
{
    internal class Math_
    {
        public void Add(int x, int y, out int result)
        {
            result = x + y;
        }
        public int Subtract(int x, int y)
        {
            return x - y;
        }
        public void Multiply(int x, int y,ref int result) {
            result = x * y;
        }
        public double Divide(int x, int y)
        {
            return x / y;
        }
    }
}
