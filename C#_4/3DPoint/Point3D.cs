using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DPoint
{
    internal class Point3D:IComparable,ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        Point3D(int z)
        {
            Z = z;
        }
        public Point3D(int x, int y, int z) : this(z) {
            X = x;
            Y = y;
        }
        public override bool Equals(object? obj)
        {
            Point3D objR = obj as Point3D;
            return X == objR.X && Y == objR.Y && Z == objR.Z;
        }

        public int CompareTo(object? obj)
        {
            var objR= obj as Point3D;
            int res = X.CompareTo(objR.X);
            if (res == 0) res = Y.CompareTo(objR.Y);
            return res;
        }
        public override string ToString()
        {
            return $"({X},{Y},{Z})";
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }
    }
}
