using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClassLibraryMatrices;

namespace WindowsFormsMatrixes {
    public partial class SoLEForm : Form {
        public SoLEForm() {
            InitializeComponent();
        }

        private void SoLEForm_Load(object sender, EventArgs e) {
            try {
                // Выводим уравнение
                SoLE input = ConvertStringToSoLE(SoLEInput.Text);
                SoLERepresentation.Text = input.ToString();

                // Решение
                List<double> solution = input.Solution();
                int N = solution.Count;
                string s = "";
                for (int i = 0; i < N; i++) {
                    s += $"x{i + 1}: {solution[i]:0.00}";
                    s += "\n";
                }
                SoLEOutput.Text = s;
            } catch {
                SoLERepresentation.Text = "Введите систему линейных алгебраических уравнений в правильной форме (см. Справку).";
            }
        }

        private SoLE ConvertStringToSoLE(string s) {
            double[,] arr = ConvertStringToArr(s);
            SoLE result = ConvertArrToSoLE(arr);
            return result;
        }

        private static double[,] ConvertStringToArr(string s) {
            int N = GetArrSize(s);
            double[,] data = new double[N + 1, N];

            string[] lines = s.Split('\n');
            string curr = "";
            for (int j = 0; j < lines.Length; j++) {
                int idx = 0;
                string line = lines[j].TrimStart().TrimEnd();
                if (string.IsNullOrEmpty(line)) continue;
                for (int i = 0; i < line.Length; i++) {
                    if (line[i].ToString() != " " && line[i].ToString() != "=") {
                        curr += line[i];
                    } else {
                        if (curr.Length > 0) {
                            data[idx, j] = double.Parse(curr);
                            idx++;
                        }
                        curr = "";
                    }
                }
                if (curr.Length > 0) {
                    data[idx, j] = double.Parse(curr);
                }
                curr = "";
            }

            return data;
        }

        private static int GetArrSize(string s) {
            string[] lines = s.Split('\n');
            int count = 0;
            for (int i = 0; i < lines.Length; i++) {
                string line = lines[i].TrimStart().TrimEnd();
                if (!string.IsNullOrEmpty(line)) count++;
            }

            int N = count;
            return N;
        }

        private static SoLE ConvertArrToSoLE(double[,] arr) {
            int N = arr.GetLength(1);
            double[,] a = new double[N, N];
            double[,] b = new double[1, N];

            for (int j = 0; j < N; j++) {
                for (int i = 0; i < N; i++) {
                    a[i, j] = arr[i, j];
                }
            }

            for (int j = 0; j < N; j++) {
                b[0, j] = arr[N, j];
            }

            Matrix aMatrix = new Matrix(a);
            Matrix bMatrix = new Matrix(b);
            SoLE result = new SoLE(aMatrix, bMatrix);
            return result;
        }

        private void SoLEInput_TextChanged(object sender, EventArgs e) {
            SoLEOutput.Text = "";
            try {
                // Выводим уравнение
                SoLE input = ConvertStringToSoLE(SoLEInput.Text);
                SoLERepresentation.Text = input.ToString();

                // Решение
                List<double> solution = input.Solution();
                int N = solution.Count;
                string s = "";
                for (int i = 0; i < N; i++) {
                    s += $"x{i + 1}: {solution[i]:0.00}";
                    s += "\n";
                }
                SoLEOutput.Text = s;
            } catch {
                SoLERepresentation.Text = "Введите систему линейных алгебраических уравнений в правильной форме (см. Справку).";
            }
        }

        private void Reference_Click(object sender, EventArgs e) {
            string s = "Калькулятор предназначен для решения системы линейных уравнений.\n";
            s += "Формат ввода системы линейных алгебраических уравнений (СЛАУ).\n";
            s += "1 2 3 10\n";
            s += "3 0 5 7\n";
            s += "0 4 6 12\n";
            s += "Через пробел. Последнее число в строке это свободный коэффициент";
            MessageBox.Show(s);
        }

        private void OnlyNumbers(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != ' ') && (e.KeyChar != '-') && (e.KeyChar != '=')) {
                e.Handled = true;
            }
        }
    }
}
