using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryMatrices;
using SemanticComparison;

namespace UnitTestProjectMatrices {
    [TestClass]
    public class MatricesUnitTests {
        public double[,] n;
        Matrix test;
        Matrix test1;

        [TestMethod]
        public void MatrixTest1()
        {
            double[,] n = { { 1.0, 0.0, 0.0 }, { 0.0, 1.0, 0.0 }, { 0.0, 0.0, 1.0 } };
            test = new Matrix(n);
            test1 = new Matrix(3, true);
            var ExpectedMatrix = new Likeness<Matrix, Matrix>(test);
            Assert.AreEqual(ExpectedMatrix, test1);
        }

        [TestMethod]
        public void AddMatrixTest1()
        {
            double[,] num1 = { { 11, 24, 75 }, { 5, 14, 3 }, { 13, 65, 9 } };
            double[,] num2 = { { 35,22,11 }, { 12, 5, 7 }, { 2, 10, 1 } };
            test = new Matrix(num1);
            test1 = new Matrix(num2);
            double[,] num3 = { { 46, 46, 86 }, { 17, 19, 10 }, { 15, 75, 10 } };
            var ExpectedMatrix = new Likeness<Matrix, Matrix>(test+test1);
            Assert.AreEqual(ExpectedMatrix, new Matrix(num3));
        }

        [TestMethod]
        public void MatrixTest2()
        {
            double[,] n = { { 1.0, 0.0, 0.0 }, { 0.0, 1.0, 0.0 }, { 0.0, 0.0, 1.0 } };
            test = new Matrix(n);
            test1 = new Matrix(3, true);
            var ExpectedMatrix = new Likeness<Matrix, Matrix>(test);
            Assert.AreEqual(ExpectedMatrix, test1);
        }

        [TestMethod]
        public void AddMatrixTest2()
        {
            double[,] num1 = { { 11, 24, 75 }, { 5, 14, 3 }, { 13, 65, 9 } };
            double[,] num2 = { { 35, 22, 11 }, { 12, 5, 7 }, { 2, 10, 1 } };
            test = new Matrix(num1);
            test1 = new Matrix(num2);
            double[,] num3 = { { 46, 46, 86 }, { 17, 19, 10 }, { 15, 75, 10 } };
            var ExpectedMatrix = new Likeness<Matrix, Matrix>(test + test1);
            Assert.AreEqual(ExpectedMatrix, new Matrix(num3));
        }

        [TestMethod]
        public void MatrixTest3()
        {
            double[,] n = { { 1.0, 0.0, 0.0 }, { 0.0, 1.0, 0.0 }, { 0.0, 0.0, 1.0 } };
            test = new Matrix(n);
            test1 = new Matrix(3, true);
            var ExpectedMatrix = new Likeness<Matrix, Matrix>(test);
            Assert.AreEqual(ExpectedMatrix, test1);
        }

        [TestMethod]
        public void AddMatrixTest3()
        {
            double[,] num1 = { { 11, 24, 75 }, { 5, 14, 3 }, { 13, 65, 9 } };
            double[,] num2 = { { 35, 22, 11 }, { 12, 5, 7 }, { 2, 10, 1 } };
            test = new Matrix(num1);
            test1 = new Matrix(num2);
            double[,] num3 = { { 46, 46, 86 }, { 17, 19, 10 }, { 15, 75, 10 } };
            var ExpectedMatrix = new Likeness<Matrix, Matrix>(test + test1);
            Assert.AreEqual(ExpectedMatrix, new Matrix(num3));
        }

        [TestMethod]
        public void MatrixTest4()
        {
            double[,] n = { { 1.0, 0.0, 0.0 }, { 0.0, 1.0, 0.0 }, { 0.0, 0.0, 1.0 } };
            test = new Matrix(n);
            test1 = new Matrix(3, true);
            var ExpectedMatrix = new Likeness<Matrix, Matrix>(test);
            Assert.AreEqual(ExpectedMatrix, test1);
        }

        [TestMethod]
        public void AddMatrixTest4()
        {
            double[,] num1 = { { 11, 24, 75 }, { 5, 14, 3 }, { 13, 65, 9 } };
            double[,] num2 = { { 35, 22, 11 }, { 12, 5, 7 }, { 2, 10, 1 } };
            test = new Matrix(num1);
            test1 = new Matrix(num2);
            double[,] num3 = { { 46, 46, 86 }, { 17, 19, 10 }, { 15, 75, 10 } };
            var ExpectedMatrix = new Likeness<Matrix, Matrix>(test + test1);
            Assert.AreEqual(ExpectedMatrix, new Matrix(num3));
        }

        [TestMethod]
        public void MatrixTest5()
        {
            double[,] n = { { 1.0, 0.0, 0.0 }, { 0.0, 1.0, 0.0 }, { 0.0, 0.0, 1.0 } };
            test = new Matrix(n);
            test1 = new Matrix(3, true);
            var ExpectedMatrix = new Likeness<Matrix, Matrix>(test);
            Assert.AreEqual(ExpectedMatrix, test1);
        }

        [TestMethod]
        public void AddMatrixTest5()
        {
            double[,] num1 = { { 11, 24, 75 }, { 5, 14, 3 }, { 13, 65, 9 } };
            double[,] num2 = { { 35, 22, 11 }, { 12, 5, 7 }, { 2, 10, 1 } };
            test = new Matrix(num1);
            test1 = new Matrix(num2);
            double[,] num3 = { { 46, 46, 86 }, { 17, 19, 10 }, { 15, 75, 10 } };
            var ExpectedMatrix = new Likeness<Matrix, Matrix>(test + test1);
            Assert.AreEqual(ExpectedMatrix, new Matrix(num3));
        }

        [TestMethod]
        public void MatrixTest6()
        {
            double[,] n = { { 1.0, 0.0, 0.0 }, { 0.0, 1.0, 0.0 }, { 0.0, 0.0, 1.0 } };
            test = new Matrix(n);
            test1 = new Matrix(3, true);
            var ExpectedMatrix = new Likeness<Matrix, Matrix>(test);
            Assert.AreEqual(ExpectedMatrix, test1);
        }

        [TestMethod]
        public void AddMatrixTest6()
        {
            double[,] num1 = { { 11, 24, 75 }, { 5, 14, 3 }, { 13, 65, 9 } };
            double[,] num2 = { { 35, 22, 11 }, { 12, 5, 7 }, { 2, 10, 1 } };
            test = new Matrix(num1);
            test1 = new Matrix(num2);
            double[,] num3 = { { 46, 46, 86 }, { 17, 19, 10 }, { 15, 75, 10 } };
            var ExpectedMatrix = new Likeness<Matrix, Matrix>(test + test1);
            Assert.AreEqual(ExpectedMatrix, new Matrix(num3));
        }

        [TestMethod]
        public void MatrixTest7()
        {
            double[,] n = { { 1.0, 0.0, 0.0 }, { 0.0, 1.0, 0.0 }, { 0.0, 0.0, 1.0 } };
            test = new Matrix(n);
            test1 = new Matrix(3, true);
            var ExpectedMatrix = new Likeness<Matrix, Matrix>(test);
            Assert.AreEqual(ExpectedMatrix, test1);
        }

        [TestMethod]
        public void AddMatrixTest7()
        {
            double[,] num1 = { { 11, 24, 75 }, { 5, 14, 3 }, { 13, 65, 9 } };
            double[,] num2 = { { 35, 22, 11 }, { 12, 5, 7 }, { 2, 10, 1 } };
            test = new Matrix(num1);
            test1 = new Matrix(num2);
            double[,] num3 = { { 46, 46, 86 }, { 17, 19, 10 }, { 15, 75, 10 } };
            var ExpectedMatrix = new Likeness<Matrix, Matrix>(test + test1);
            Assert.AreEqual(ExpectedMatrix, new Matrix(num3));
        }

        [TestMethod]
        public void MatrixTest8()
        {
            double[,] n = { { 1.0, 0.0, 0.0 }, { 0.0, 1.0, 0.0 }, { 0.0, 0.0, 1.0 } };
            test = new Matrix(n);
            test1 = new Matrix(3, true);
            var ExpectedMatrix = new Likeness<Matrix, Matrix>(test);
            Assert.AreEqual(ExpectedMatrix, test1);
        }

        [TestMethod]
        public void AddMatrixTest8()
        {
            double[,] num1 = { { 11, 24, 75 }, { 5, 14, 3 }, { 13, 65, 9 } };
            double[,] num2 = { { 35, 22, 11 }, { 12, 5, 7 }, { 2, 10, 1 } };
            test = new Matrix(num1);
            test1 = new Matrix(num2);
            double[,] num3 = { { 46, 46, 86 }, { 17, 19, 10 }, { 15, 75, 10 } };
            var ExpectedMatrix = new Likeness<Matrix, Matrix>(test + test1);
            Assert.AreEqual(ExpectedMatrix, new Matrix(num3));
        }

        [TestMethod]
        public void MatrixTest9()
        {
            double[,] n = { { 1.0, 0.0, 0.0 }, { 0.0, 1.0, 0.0 }, { 0.0, 0.0, 1.0 } };
            test = new Matrix(n);
            test1 = new Matrix(3, true);
            var ExpectedMatrix = new Likeness<Matrix, Matrix>(test);
            Assert.AreEqual(ExpectedMatrix, test1);
        }

        [TestMethod]
        public void AddMatrixTest9()
        {
            double[,] num1 = { { 11, 24, 75 }, { 5, 14, 3 }, { 13, 65, 9 } };
            double[,] num2 = { { 35, 22, 11 }, { 12, 5, 7 }, { 2, 10, 1 } };
            test = new Matrix(num1);
            test1 = new Matrix(num2);
            double[,] num3 = { { 46, 46, 86 }, { 17, 19, 10 }, { 15, 75, 10 } };
            var ExpectedMatrix = new Likeness<Matrix, Matrix>(test + test1);
            Assert.AreEqual(ExpectedMatrix, new Matrix(num3));
        }

        [TestMethod]
        public void MatrixTest10()
        {
            double[,] n = { { 1.0, 0.0, 0.0 }, { 0.0, 1.0, 0.0 }, { 0.0, 0.0, 1.0 } };
            test = new Matrix(n);
            test1 = new Matrix(3, true);
            var ExpectedMatrix = new Likeness<Matrix, Matrix>(test);
            Assert.AreEqual(ExpectedMatrix, test1);
        }

        [TestMethod]
        public void AddMatrixTest10()
        {
            double[,] num1 = { { 11, 24, 75 }, { 5, 14, 3 }, { 13, 65, 9 } };
            double[,] num2 = { { 35, 22, 11 }, { 12, 5, 7 }, { 2, 10, 1 } };
            test = new Matrix(num1);
            test1 = new Matrix(num2);
            double[,] num3 = { { 46, 46, 86 }, { 17, 19, 10 }, { 15, 75, 10 } };
            var ExpectedMatrix = new Likeness<Matrix, Matrix>(test + test1);
            Assert.AreEqual(ExpectedMatrix, new Matrix(num3));
        }

        [TestMethod]
        public void MatrixTest11()
        {
            double[,] n = { { 1.0, 0.0, 0.0 }, { 0.0, 1.0, 0.0 }, { 0.0, 0.0, 1.0 } };
            test = new Matrix(n);
            test1 = new Matrix(3, true);
            var ExpectedMatrix = new Likeness<Matrix, Matrix>(test);
            Assert.AreEqual(ExpectedMatrix, test1);
        }

        [TestMethod]
        public void AddMatrixTest11()
        {
            double[,] num1 = { { 11, 24, 75 }, { 5, 14, 3 }, { 13, 65, 9 } };
            double[,] num2 = { { 35, 22, 11 }, { 12, 5, 7 }, { 2, 10, 1 } };
            test = new Matrix(num1);
            test1 = new Matrix(num2);
            double[,] num3 = { { 46, 46, 86 }, { 17, 19, 10 }, { 15, 75, 10 } };
            var ExpectedMatrix = new Likeness<Matrix, Matrix>(test + test1);
            Assert.AreEqual(ExpectedMatrix, new Matrix(num3));
        }

        [TestMethod]
        public void MatrixTest12()
        {
            double[,] n = { { 1.0, 0.0, 0.0 }, { 0.0, 1.0, 0.0 }, { 0.0, 0.0, 1.0 } };
            test = new Matrix(n);
            test1 = new Matrix(3, true);
            var ExpectedMatrix = new Likeness<Matrix, Matrix>(test);
            Assert.AreEqual(ExpectedMatrix, test1);
        }

        [TestMethod]
        public void AddMatrixTest12()
        {
            double[,] num1 = { { 11, 24, 75 }, { 5, 14, 3 }, { 13, 65, 9 } };
            double[,] num2 = { { 35, 22, 11 }, { 12, 5, 7 }, { 2, 10, 1 } };
            test = new Matrix(num1);
            test1 = new Matrix(num2);
            double[,] num3 = { { 46, 46, 86 }, { 17, 19, 10 }, { 15, 75, 10 } };
            var ExpectedMatrix = new Likeness<Matrix, Matrix>(test + test1);
            Assert.AreEqual(ExpectedMatrix, new Matrix(num3));
        }
    }
}
