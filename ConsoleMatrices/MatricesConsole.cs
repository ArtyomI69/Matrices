using System;
using ClassLibraryMatrices;

namespace ConsoleMatrices {
    internal class MatricesConsole {
        static void Main(string[] args) {
            //Matrix a = new Matrix(4, 3);
            //Console.Write(a.ToString());
            //Console.WriteLine();
            Matrix a = new Matrix(4, 3, new Random());
            Console.WriteLine(a);
            Console.WriteLine();
            (int N, int M) = GetMatrixSize(a.ToString());
            Console.WriteLine(N + " " + M);

            double[,] data = new double[N, M];
            string s = a.ToString();
            string[] lines = s.Split('\n'); ;
            int idx = 0;
            string curr = "";
            for (int j = 0; j < lines.Length; j++) {
                idx = 0;
                string line = lines[j];
                for (int i = 0; i < line.Length; i++) {
                    if (line[i].ToString() != " ") {
                        if (line[i].ToString() == ".") curr += ",";
                        else curr += line[i];
                    } else {
                        if (curr.Length > 0) {
                            data[idx, j] = double.Parse(curr);
                            idx++;
                        }
                        curr = "";
                    }
                }
            }

            Console.WriteLine(new Matrix(data));
        }

        public static Matrix ConvertStringToMatrix(string s) {
            (int N, int M) = GetMatrixSize(s);
            double[,] data = new double[N, M];

            string[] lines = s.Split('\n');
            int idx = 0;
            string curr = "";
            for (int j = 0; j < lines.Length; j++) {
                idx = 0;
                string line = lines[j];
                for (int i = 0; i < line.Length; i++) {
                    if (line[i].ToString() != " ") {
                        if (line[i].ToString() == ".") curr += ",";
                        else curr += line[i];
                    } else {
                        if (curr.Length > 0) {
                            data[idx, j] = double.Parse(curr);
                            idx++;
                        }
                        curr = "";
                    }
                }
            }

            return new Matrix(data);
        }

        public static (int N, int M) GetMatrixSize(string s) {
            string[] lines = s.Split('\n');
            string firstLine = lines[0];
            string curr = "";
            int count = 0;
            for (int i = 0; i < firstLine.Length; i++) {
                if (firstLine[i].ToString() != " ") {
                    curr += firstLine[i].ToString();
                } else {
                    if (curr.Length > 0) count++;
                    curr = "";
                }
            }
            if (curr.Length > 0) count++;
            int N = count;

            count = 0;
            for (int i = 0; i < lines.Length; i++) {
                string line = lines[i];
                if (!string.IsNullOrEmpty(line) && line[0].ToString() != " ") count++;
            }
            int M = count;
            return (N, M);
        }
    }
}
