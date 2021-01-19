using System;
using MyMathDLL;

namespace Day2ConsoleApp
{
    class Program
    {
        static void PrintMatrix(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void FirstTask()
        {
            Console.WriteLine("Введите число M и число N");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите {i + 1} элемент массива:");
                array[i] = int.Parse(Console.ReadLine());
            }
            MyMatrix myMatrix = new MyMatrix();
            int[,] resultMatrix = myMatrix.FirstTask(m, n, array);
            PrintMatrix(resultMatrix);
        }
        static void SecondTask()
        {
            Console.WriteLine("Введите число M и число N");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[m,n];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"Введите {i + 1}, {j + 1} элемент массива:");
                    array[i,j] = int.Parse(Console.ReadLine());
                }
            }
            MyMatrix myMatrix = new MyMatrix();
            int[] arr = myMatrix.SecondTask(array);
            foreach(var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void TherdTask()
        {
            Console.WriteLine("Введите число N");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите {i + 1} элемент массива:");
                array[i] = int.Parse(Console.ReadLine());
            }
            MyMatrix myMatrix = new MyMatrix();
            int[] resArr = myMatrix.TherdTask(array);
            foreach (var item in resArr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void FourthTask()
        {
            Console.WriteLine("Введите число N");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите {i + 1} элемент массива:");
                array[i] = int.Parse(Console.ReadLine());
            }
            MyMatrix myMatrix = new MyMatrix();
            int count = myMatrix.FourthTask(array);
            Console.WriteLine(count);
        }
        static void Menu()
        {
            while(true)
            {
                Console.WriteLine("1) Первое задание ");
                Console.WriteLine("2) Второе задаие ");
                Console.WriteLine("3) Третие задание ");
                Console.WriteLine("4) Четвертое задание ");
                Console.WriteLine("5) Пятое задание");
                Console.WriteLine("6) exit");
                int sw = int.Parse(Console.ReadLine());
                switch (sw)
                {
                    case 1:
                        {
                            FirstTask();
                            break;
                        }
                    case 2:
                        {
                            SecondTask();
                            break;
                        }
                    case 3:
                        {
                            TherdTask();
                            break;
                        }
                    case 4:
                        {
                            FourthTask();
                            break;
                        }
                    case 5:
                        {

                            break;
                        }
                    case 6:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" 1)	Даны целые положительные числа M, N и набор из N чисел. Сформировать матрицу размера M × N, у которой в каждой строке содержатся все числа из исходного набора (в том же порядке).\n"+
            "2)  Дана матрица размера M × N.В каждом ее столбце найти количество элементов, больших среднего арифметического всех элементов этого столбца.\n" + 
            "3)	Дан целочисленный массив размера N.Увеличить все нечетные числа, содержащиеся в массиве, на исходное значение последнего нечетного числа.Если нечетные числа в массиве отсутствуют, то оставить массив без изменений.\n" + 
            "4)	Найдите количество элементов массива, которые отличны от наибольшего элемента не более чем на 10 %.\n" +
            "5)	Дан двумерный массив.Каждая ячейка имеет вес указанный в матрице, необходимо пройти наименьшее количество шагов имею сумму n. Начиная с правого верхнего.  Каждый шаг её уменьшает на значения в матрице.\n");
            Menu();
            Console.ReadLine();
        }
    }
}
