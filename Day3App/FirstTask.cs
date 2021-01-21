using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3App
{
    public class FirstTask
    {
        int countPoints = 0;
        double R = 0;
        int XCenterPointInCercle = 0;
        int YCenterPointInCercle = 0;
        List<Point> plane = new List<Point>();
        public FirstTask()
        {
            RandomCountpoints();
        }
        public void RandomCountpoints()
        {
            Random rnd = new Random();
            countPoints = rnd.Next(4,8);
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
        }
        public int GetCountPointsInCircle()
        {
            XCenterPointInCercle = plane.Last().X;
            YCenterPointInCercle = plane.Last().Y;
            R = Math.Sqrt(Math.Pow(plane[1].X - plane[0].X, 2) + Math.Pow(plane[1].Y - plane[0].Y, 2));
            int count = 0;
            for(int i = 0; i < plane.Count; i++)
            {
                if(Math.Sqrt(Math.Pow(plane[i].X - XCenterPointInCercle, 2) + Math.Pow(plane[i].Y - YCenterPointInCercle, 2)) <= R)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
