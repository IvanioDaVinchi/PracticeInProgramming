using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMathDLL;

namespace UnitTestProgramm
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodFunctionFirstTask()
        {
            int m = 3;
            int n = 3;
            int[] array = new int[3] { 1,2,3};
            MyMatrix myMatrix = new MyMatrix();
            int[,] resultMatrix = myMatrix.FirstTask(m, n, array);
            bool check = true;
            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    if(resultMatrix[i,j] != array[j])
                        check = false;
                }
            }
            Assert.IsTrue(check);
        }
        [TestMethod]
        public void TestMethodFunctionSecondTask()
        {
            int m = 3;
            int n = 3;
            bool check = false;
            int[,] array = new int[3, 3] { { 1, 2, 3 },{ 4, 5, 6 },{ 7, 8, 9 } };
            MyMatrix myMatrix = new MyMatrix();
            int[] arr = myMatrix.SecondTask(array);
            if (arr[0] == 1 && arr[2] == 1 && arr[2] == 2)
                check = true;
            Assert.IsTrue(check);
        }
        [TestMethod]
        public void TestMethodAvgFunction()
        {
            bool check = false;
            MyMatrix myMatrix = new MyMatrix();
            int[,] matrix = new int[3, 3] { { 1,2,3},{4,5,6 },{7,8,9} };
            if (myMatrix.AvgArr(matrix) == 5)
                check = true;
            Assert.IsTrue(check);
        }
        [TestMethod]
        public void TestMethodCheckOnOddDigitOnArray()
        {
            int[] array = new int[4] { 2,2,3,2};
            MyMatrix myMatrix = new MyMatrix();
            bool check = myMatrix.CheckOnOddDigitOnArray(array);
            Assert.IsTrue(check);
        }
        [TestMethod]
        public void TestMethodTherdTask()
        {
            bool check = false;
            int[] array = new int[5] { 1,2,3,4,6};
            MyMatrix myMatrix = new MyMatrix();
            int[] resArr = myMatrix.TherdTask(array);
            if (resArr[0] == 4 && resArr[2] == 3)
                check = true;
            Assert.IsTrue(check);
        }
        [TestMethod]
        public void TestMethodOnFindLastOddElement()
        {
            bool check = false;
            int[] array = new int[5] { 1, 2, 3, 4, 6 };
            MyMatrix myMatrix = new MyMatrix();
            if (myMatrix.GetLastOddDigitOnArray(array) == 3)
                check = true;
            Assert.IsTrue(check);
        }
        [TestMethod]
        public void TestMethodFourthTask()
        {
            bool check = false;
            int[] array = new int[5] { 1,1,2,-5,1};
            MyMatrix myMatrix = new MyMatrix();
            if (myMatrix.FourthTask(array) == 3)
                check = true;
            Assert.IsTrue(check);
        }
    }
}
