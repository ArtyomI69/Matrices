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
        public void IdentityMatrixTest() {
            double[,] n = { { 1.0, 0.0, 0.0 }, { 0.0, 1.0, 0.0 }, { 0.0, 0.0, 1.0 } };
            test = new Matrix(n);
            test1 = new Matrix(3, true);
            Assert.IsTrue(test.Equals(test1));
        }

        [TestMethod]
        public void AddMatrixTest() {
            double[,] num1 = { { 11, 24, 75 }, { 5, 14, 3 }, { 13, 65, 9 } };
            double[,] num2 = { { 35, 22, 11 }, { 12, 5, 7 }, { 2, 10, 1 } };
            test = new Matrix(num1);
            test1 = new Matrix(num2);
            double[,] num3 = { { 46, 46, 86 }, { 17, 19, 10 }, { 15, 75, 10 } };
            Assert.IsTrue((test + test1).Equals(new Matrix(num3)));
        }

        [TestMethod]
        public void SubtractMatrixTest() {
            double[,] num1 = { { 46, 46, 86 }, { 17, 19, 10 }, { 15, 75, 10 } };
            double[,] num2 = { { 11, 24, 75 }, { 5, 14, 3 }, { 13, 65, 9 } };
            test = new Matrix(num1);
            test1 = new Matrix(num2);
            double[,] num3 = { { 35, 22, 11 }, { 12, 5, 7 }, { 2, 10, 1 } };
            Assert.IsTrue((test - test1).Equals(new Matrix(num3)));
        }

        [TestMethod]
        public void MultiplyMatrixTest() {
            double[,] num1 = { { -6.00, -2.00, 7.00 }, { -1.00, 5.00, -9.00 }, { -9.00, 7.00, -7.00 } };
            double[,] num2 = { { 5.00, 4.00, -2.00 }, { 3.00, 6.00, 0.00 }, { 1.00, -2.00, 1.00 } };
            test = new Matrix(num1);
            test1 = new Matrix(num2);
            double[,] num3 = { { -29, -50, 19 }, { 1, 44, -7 }, { -31, 20, 11 } };
            Assert.IsTrue((test * test1).Equals(new Matrix(num3)));
        }

        [TestMethod]
        public void MultiplyMatrixToIdentityMatrixTest() {
            double[,] num1 = { { 4.00, -2.00, 1.00 }, { 1.00, 6.00, -2.00 }, { 1.00, 0.00, 0.00 } };
            double[,] num2 = { { 0.00, 0.00, 1.00 }, { 1.00, 0.50, -4.50 }, { 3.00, 1.00, -13.00 } };
            test = new Matrix(num1);
            test1 = new Matrix(num2);
            double[,] num3 = { { 1.0, 0.0, 0.0 }, { 0.0, 1.0, 0.0 }, { 0.0, 0.0, 1.0 } };
            Assert.IsTrue((test * test1).Equals(new Matrix(num3)));
        }

        [TestMethod]
        public void MultiplyMatrixByNumberTest() {
            double[,] num1 = { { 4.00, -2.00, 1.00 }, { 1.00, 6.00, -2.00 }, { 1.00, 0.00, 0.00 } };
            test = new Matrix(num1);
            double[,] num2 = { { 8.00, -4.00, 2.00 }, { 2.00, 12.00, -4.00 }, { 2.00, 0.00, 0.00 } };
            Assert.IsTrue((test * 2).Equals(new Matrix(num2)));
        }

        [TestMethod]
        public void RaiseByPowerMatrixTest1() {
            double[,] num1 = { { 4.00, -5.00, -1.00 }, { 2.00, -5.00, -5.00 }, { -2.00, 6.00, 7.00 } };
            test = new Matrix(num1);
            double[,] num2 = { { 51700.00, -405941.00, -651162.00 }, { -142680.00, 171953.00, 35588.00 }, { 222958.00, -347762.00, -202459.00 } };
            Assert.IsTrue((test ^ 10).Equals(new Matrix(num2)));
        }

        [TestMethod]
        public void RaiseByPowerMatrixTest2() {
            double[,] num1 = { { 4.00, -5.00, -1.00 }, { 2.00, -5.00, -5.00 }, { -2.00, 6.00, 7.00 } };
            test = new Matrix(num1);
            double[,] num2 = { { 1.0, 0.0, 0.0 }, { 0.0, 1.0, 0.0 }, { 0.0, 0.0, 1.0 } };
            Assert.IsTrue((test ^ 0).Equals(new Matrix(num2)));
        }

        [TestMethod]
        public void InverseMatrixTest() {
            double[,] num1 = { { 4.00, -5.00, -1.00 }, { 2.00, -5.00, -5.00 }, { -2.00, 6.00, 7.00 } };
            test = new Matrix(num1);
            double[,] num2 = { { 2.00, -14.00, -9.00 }, { 1.00, -12.00, -8.00 }, { 0.00, 6.00, 4.00 } };
            Matrix res = test.Inverse();
            for (int i = 0; i < res.N; i++) {
                for (int j = 0; j < res.M; j++) {
                    res[i, j] = (int)res[i, j];
                }
            }
            Assert.IsTrue(res.Equals(new Matrix(num2)));
        }

        [TestMethod]
        public void DeterminantMatrixTest() {
            double[,] num1 = { { 4.00, -5.00, -1.00 }, { 2.00, -5.00, -5.00 }, { -2.00, 6.00, 7.00 } };
            test = new Matrix(num1);
            Assert.AreEqual((int)test.Determinant(), -2);
        }
    }
}
