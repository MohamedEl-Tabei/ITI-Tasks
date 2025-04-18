﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__3
{
    internal class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point3D()
        {
            X = 0;Y = 0;Z = 0;
        }
        public Point3D(int x, int y)
        {
            X = x;
            Y = y;
        }


        public Point3D(int x,int y,int z):this(x,y)
        {
            //X = x;
            //Y = y;
            Z = z;

        }
        public override string ToString()
        {
            return $"Point Coordinates: ({X},{Y},{Z})";
        }
    }
}
