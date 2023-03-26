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
        public void MatrixTest()
        {
            double[,] n = { { 1.0, 0.0, 0.0 }, { 0.0, 1.0, 0.0 }, { 0.0, 0.0, 1.0 } };
            test = new Matrix(n);
            test1 = new Matrix(3, true);
            var ExpectedMatrix = new Likeness<Matrix, Matrix>(test);
            Assert.AreEqual(ExpectedMatrix, test1);
        }

        [TestMethod]
        public void AddMatrixTest()
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
        public void SubtractMatrixTest() {
            double[,] num1 = { { 46, 46, 86 }, { 17, 19, 10 }, { 15, 75, 10 } };
            double[,] num2 = { { 11, 24, 75 }, { 5, 14, 3 }, { 13, 65, 9 } };
            test = new Matrix(num1);
            test1 = new Matrix(num2);
            var ExpectedMatrix = new Likeness<Matrix, Matrix>(test - test1);
            double[,] num3 = { { 35, 22, 11 }, { 12, 5, 7 }, { 2, 10, 1 } };
            Assert.AreEqual(ExpectedMatrix, new Matrix(num3));
        }
    }
}
