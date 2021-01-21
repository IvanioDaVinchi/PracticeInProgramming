using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3App
{
    public class SecondTask
    {
        int countPoints = 0;
        List<Point> plane = new List<Point>();
        List<Triangle> triangles = new List<Triangle>();
        public SecondTask()
        {
            RandomCountpoints();
        }
        public void RandomCountpoints()
        {
            Random rnd = new Random();
            countPoints = rnd.Next(30,31); // в сумме должно выйти около 4 тысяч треугольников если будет около 30 точек
            FillPlane();
        }
        public void FillPlane()
        {
            Random rnd = new Random();
            for (int i = 0; i < countPoints; i++)
            {
                Point point = new Point();
                point.X = rnd.Next(-10, 10);
                point.Y = rnd.Next(-10, 10);
                plane.Add(point);
            }
            FillTriangle();
        }
        public void FillTriangle() // создаем все возможные треугольники по точкам
        {
            for (int i = 0; i < plane.Count - 2; i++)
            {
                for (int j = i + 1; j < plane.Count - 1; j++)
                {
                    for (int k = j + 1; k < plane.Count; k++)
                    {
                        Triangle triangle = new Triangle();
                        triangle.Ax = plane[i].X;
                        triangle.Ay = plane[i].Y;
                        triangle.Bx = plane[j].X;
                        triangle.By = plane[j].Y;
                        triangle.Cx = plane[k].X;
                        triangle.Cy = plane[k].Y;
                        triangles.Add(triangle);
                    }
                }
            }
        }
        public void FindEqualTriangle() // ищим равные треугольники, но при этом у одного труегольника координаты у должны быть отрицательными. а у второго положительные - тогда треугольники будет по разные стороны оси Ох
        {
            for(int i = 0; i < triangles.Count; i++)
            {
                for (int j = i + 1; j < triangles.Count; j++)
                {
                    if (triangles[i].Ay < 0 && triangles[j].Ay > 0 && triangles[i].By < 0 && triangles[j].By > 0 && triangles[i].Cy < 0 && triangles[j].Cy > 0 || triangles[i].Ay > 0 && triangles[j].Ay < 0 && triangles[i].By > 0 && triangles[j].By < 0 && triangles[i].Cy > 0 && triangles[j].Cy < 0)
                    {// смотрим если два тругольника по разные стороны оси Ох, тогда идем смотреть равны ли они.
                        if (triangles[i].AB() == triangles[j].AB() && triangles[i].BC() == triangles[j].BC() && triangles[i].CA() == triangles[j].CA())
                        {
                            Console.WriteLine($"Треугольники подходят по условию!! - Fisrt Triangle {triangles[i]}  - SecondTriangle - {triangles[j]}");
                        }
                    }
                }
            }
        }

    }
}
