namespace MatrixTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using DiagonalMatrix;

    [TestClass]
    public class DiagonalMatrixTests
    {
        public static bool CompareMatrices(int[,] matrixExpected, int[,] matrixActual)
        {
            int rowsCountMatrixExpected = matrixExpected.GetLength(0);
            int colsCountMatrixExpected = matrixExpected.GetLength(1);
            int rowsCountMatrixActual = matrixExpected.GetLength(0);
            int colsCountMatrixActual = matrixExpected.GetLength(1);

            if (rowsCountMatrixActual != rowsCountMatrixExpected || colsCountMatrixActual != colsCountMatrixExpected)
            {
                return false;
            }

            for (int rows = 0; rows < rowsCountMatrixActual; rows++)
            {
                for (int cols = 0; cols < colsCountMatrixActual; cols++)
                {
                    if (matrixActual[rows, cols] != matrixExpected[rows, cols])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        [TestMethod]
        [Timeout(1000)]
        public void FillMatrixSide1Test()
        {
            int n = 1;

            int[,] matrixExpected = new int[,]
            {
                { 1}
            };

            int[,] matrixActual = DiagonalMatrix.FillMatrix(n);
            bool matricesAreEqual = CompareMatrices(matrixExpected, matrixActual);
            Assert.IsTrue(matricesAreEqual);
        }

        [TestMethod]
        [Timeout(1000)]
        public void FillMatrixSide2Test()
        {
            int n = 2;

            int[,] matrixExpected = new int[,]
            {
                { 1, 4},
                { 3, 2},
            };

            int[,] matrixActual =  DiagonalMatrix.FillMatrix(n);
            bool matricesAreEqual = CompareMatrices(matrixExpected, matrixActual);
            Assert.IsTrue(matricesAreEqual);
        }

        [TestMethod]
        [Timeout(1000)]
        public void FillMatrixSide3Test()
        {
            int n = 3;

            int[,] matrixExpected = new int[,]
            {
                { 1, 7, 8},
                { 6, 2, 9},
                { 5, 4, 3},
            };

            int[,] matrixActual =  DiagonalMatrix.FillMatrix(n);
            bool matricesAreEqual = CompareMatrices(matrixExpected, matrixActual);
            Assert.IsTrue(matricesAreEqual);
        }

        [TestMethod]
        [Timeout(1000)]
        public void FillMatrixSide6Test()
        {
            int n = 6;

            int[,] matrixExpected = new int[,]
            {
                { 1, 16, 17, 18, 19, 20 },
                { 15, 2, 27, 28, 29, 21 },
                { 14, 31, 3, 26, 30, 22 },
                { 13, 36, 32, 4, 25, 23 },
                { 12, 35, 34, 33, 5, 24 },
                { 11, 10, 9, 8, 7, 6 }
            };

            int[,] matrixActual =  DiagonalMatrix.FillMatrix(n);
            bool matricesAreEqual = CompareMatrices(matrixExpected, matrixActual);
            Assert.IsTrue(matricesAreEqual);
        }

        [TestMethod]
        [Timeout(1000)]
        public void FillMatrixSide6Test35ValueDuplicated()
        {
            int n = 6;

            int[,] matrixExpected = new int[,]
            {
                { 1, 16, 17, 18, 19, 20 },
                { 15, 2, 27, 28, 29, 21 },
                { 14, 31, 3, 26, 30, 22 },
                { 13, 35, 32, 4, 25, 23 },
                { 12, 35, 34, 33, 5, 24 },
                { 11, 10, 9, 8, 7, 6 }
            };

            int[,] matrixActual =  DiagonalMatrix.FillMatrix(n);
            bool matricesAreEqual = CompareMatrices(matrixExpected, matrixActual);
            Assert.IsTrue(!matricesAreEqual);
        }

        [TestMethod]
        [Timeout(1000)]
        public void FillMatrixSide6Test6ValueMissing()
        {
            int n = 6;

            int[,] matrixExpected = new int[,]
            {
                { 1, 16, 17, 18, 19, 20 },
                { 15, 2, 27, 28, 29, 21 },
                { 14, 31, 3, 26, 30, 22 },
                { 13, 36, 32, 4, 25, 23 },
                { 12, 35, 34, 33, 5, 24 },
                { 11, 10, 9, 8, 7, 0}
            };

            int[,] matrixActual =  DiagonalMatrix.FillMatrix(n);
            bool matricesAreEqual = CompareMatrices(matrixExpected, matrixActual);
            Assert.IsTrue(!matricesAreEqual);
        }

        [TestMethod]
        [Timeout(1000)]
        public void FillMatrixSide6TestWrongNumberOfSideN()
        {
            int n = 4;

            int[,] matrixExpected = new int[,]
            {
                { 1, 7, 8},
                { 6, 2, 9},
                { 5, 4, 3},
            };

            int[,] matrixActual =  DiagonalMatrix.FillMatrix(n);
            bool matricesAreEqual = CompareMatrices(matrixExpected, matrixActual);
            Assert.IsTrue(!matricesAreEqual);
        }

        [TestMethod]
        public void ToStringTestSide6MissingSpace()
        {
            int n = 6;
            DiagonalMatrix matrixActual = new DiagonalMatrix(n);
            string expected = " 1 16 17 18 19 20\r\n" +
                               " 15 2 27 28 29 21\r\n" +
                               " 14 31 3 26 30 22\r\n" +
                               " 13 36 32 4 25 23\r\n" +
                               " 12 35 34 33 5 24\r\n" +
                               " 11 10 9 8 7 6\r\n";

            string actual = matrixActual.ToString();

            Assert.IsTrue(expected != actual);
        }
    }
}