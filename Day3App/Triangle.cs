using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3App
{
    public class Triangle
    {
        public int Ax;
        public int Ay;
        public int Bx;
        public int By;
        public int Cx;
        public int Cy;
        public double AB() => Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2));
        public double BC() => Math.Sqrt(Math.Pow(Cx - Bx, 2) + Math.Pow(Cy - By, 2));
        public double CA() => Math.Sqrt(Math.Pow(Ax - Cx, 2) + Math.Pow(Ay - Cy, 2));
        public override string ToString() => $"Storoni - {AB()}, {BC()}, {CA()}";
    }
}
