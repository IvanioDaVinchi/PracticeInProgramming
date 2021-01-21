using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3App
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("1) Fisrt task");
                Console.WriteLine("2) Second task");
                Console.WriteLine("3) Therd task");
                Console.WriteLine("4) Exit");
                int sw = int.Parse(Console.ReadLine());
                switch (sw)
                {
                    case 1:
                        {
                            Console.WriteLine("First Task");
                            FirstTask obj = new FirstTask();
                            Console.WriteLine($"Кол-во точек в окружности - {obj.GetCountPointsInCircle()}");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("SecondTask");
                            SecondTask secondTask = new SecondTask();
                            secondTask.FindEqualTriangle();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("SecondTask");
                            TherdTask therdTask = new TherdTask();
                            break;
                        }
                    case 4:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}
