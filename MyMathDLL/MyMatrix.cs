using System;
using System.Linq;

namespace MyMathDLL
{
    /// <summary>
    /// This Class complate Task From Practice number 2, it working with matrix and array
    /// </summary>
    public class MyMatrix
    {
        /// <summary>
        /// This function complate first task
        /// </summary>
        /// <param name="m"> input value </param>
        /// <param name="n"> input value </param>
        /// <param name="arr"> input value </param>
        /// <returns> return chenged array </returns>
        public int[,] FirstTask(int m, int n, int[] arr)
        {
            int[,] resultArray = new int[m, n];
            if (n == arr.Length)
            {
                for (int i = 0; i < resultArray.GetLength(0); i++)
                {
                    for (int j = 0; j < resultArray.GetLength(1); j++)
                    {
                        resultArray[i, j] = arr[j];
                    }
                }
                return resultArray;
            }
            else
            {
                throw new Exception("Размерность набора чисел больше или меньше, чем число n");
            }
        }
        /// <summary>
        /// This function return avg on array
        /// </summary>
        /// <param name="array">input value </param>
        /// <returns> avg </returns>
        public int AvgArr(int[,] array)
        {
            int avg = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    avg += array[i, j];
                }
            }
            return avg / array.Length;
        }
        /// <summary>
        /// This function complate second task
        /// </summary>
        /// <param name="array"> input value </param>
        /// <returns> array which contains count elements > avg </returns>
        public int[] SecondTask(int[,] array)
        {
            int[] resultArray = new int[array.GetLength(0)];
            int count = 0, avg = AvgArr(array);
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    if (array[i, j] > avg)
                    {
                        count++;
                    }
                }
                resultArray[j] = count;
                count = 0;
            }
            return resultArray;
        }
        /// <summary>
        /// This function Check On Odd Digit On Array
        /// </summary>
        /// <param name="array"> input value </param>
        /// <returns> true or false  </returns>
        public bool CheckOnOddDigitOnArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// This function return last odd digit on array
        /// </summary>
        /// <param name="array"> input value </param>
        /// <returns> last odd digit </returns>
        public int GetLastOddDigitOnArray(int[] array)
        {
            int lastOddDigit = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    lastOddDigit = array[i];
                }
            }
            return lastOddDigit;
        }
        /// <summary>
        /// This function complate therd task
        /// </summary>
        /// <param name="array"> input value </param>
        /// <returns> return array </returns>
        public int[] TherdTask(int[] array)
        {
            if (CheckOnOddDigitOnArray(array))
            {
                int lastOdd = GetLastOddDigitOnArray(array);
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0 && array[i] != lastOdd) // Увеличиваю все нечетные кроме последнего нечетного
                    {
                        array[i] += lastOdd;
                    }
                }
            }
            return array;
        }
        /// <summary>
        /// this function for search ma element in array
        /// </summary>
        /// <param name="array"> input value(array) </param>
        /// <returns> return max element </returns>
        public int MaxElementOnArray(int[] array) => array.Max();
        /// <summary>
        /// This function check digit on differs by ten precent from the maximum element
        /// </summary>
        /// <param name="max"> input value </param>
        /// <param name="digit"> input value </param>
        /// <returns> true or false </returns>
        public bool DiffersByTenPercentFromTheMaximum(int max, int digit)
        {
            if (digit * 100 / max <= 10)
                return true;
            else
                return false;
        }
        /// <summary>
        /// This function complate Fourth task
        /// </summary>
        /// <param name="array"> input value </param>
        /// <returns> count </returns>
        public int FourthTask(int[] array)
        {
            int count = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(DiffersByTenPercentFromTheMaximum(MaxElementOnArray(array), array[i]))
                    count++;
            }
            return count;
        }
        /// <summary>
        /// This function complate five task
        /// </summary>
        /// <param name="n"> input value </param>
        /// <param name="matrix"> input value </param>
    }
}
