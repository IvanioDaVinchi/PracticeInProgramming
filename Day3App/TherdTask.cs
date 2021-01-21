using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3App
{
    public class TherdTask
    {
        Rectangle rectangle = new Rectangle();
        Straight straight = new Straight();
        public TherdTask()
        {
            EnterPointRectangleAndStreght();
        }
        public void EnterPointRectangleAndStreght()
        {
            rectangle.A.X = 2;
            rectangle.A.Y = 2;
            rectangle.B.X = 2;
            rectangle.B.Y = 6;
            rectangle.C.X = 10;
            rectangle.C.Y = 6;
            rectangle.D.X = 10;
            rectangle.D.Y = 2;
            straight.A.X = 2;
            straight.A.Y = 4;
            straight.B.X = 10;
            straight.B.Y = 5;
            CheckOnRectangle();
        }
        public void CheckOnRectangle() // я смотрю в первую очередь на координаты прямой, если хНачала = хКонца или тоже самое с у - тогда 
        {                                 // я начинаю смотреть пересикает ли прямая полностью прямоугольник, если да - то фигуры, которые мы получили путем пересечения прямой и прямоугольника.
            if(straight.A.X == straight.B.X || straight.A.Y == straight.B.Y)
            {
                if(straight.A.Y >= rectangle.B.Y && straight.B.Y <= rectangle.A.Y || straight.A.X <= rectangle.A.X && straight.B.X >= rectangle.C.X)
                {
                    Console.WriteLine("полученные фигуры прямоугольники!");
                }
                else
                {
                    Console.WriteLine("полученные фигуры НЕ прямоугольники!");
                }
            }
            else
            {
                Console.WriteLine("полученные фигуры НЕ прямоугольники!");
            }
        }
    }
}
