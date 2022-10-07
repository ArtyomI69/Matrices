using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryMatrices;

namespace WindowsFormsMatrixes {
    public partial class MatricesForm : Form {
        public MatricesForm() {
            InitializeComponent();
        }

        private static Matrix ConvertStringToMatrix(string s) {
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
                if (curr.Length > 0) {
                    data[idx, j] = double.Parse(curr);
                }
            }

            return new Matrix(data);
        }

        private static (int N, int M) GetMatrixSize(string s) {
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

        private void PrintErrorA(string message) {
            ErrorA.Text = message;
        }

        private void ClearErrorA() {
            ErrorA.Text = "";
        }

        private void PrintErrorB(string message) {
            ErrorB.Text = message;
        }

        private void ClearErrorB() {
            ErrorB.Text = "";
        }

        private void GenerateA_Click(object sender, EventArgs e) {
            ClearErrorA();
            try {
                int N = int.Parse(MatrixANInput.Text);
                int M = int.Parse(MatrixAMInput.Text);
                if (N < 0 || M < 0) {
                    N = Math.Abs(N);
                    M = Math.Abs(M);
                }
                MatrixANInput.Text = N.ToString();
                MatrixAMInput.Text = M.ToString();
                Matrix newMatrix = new Matrix(N, M, new Random());
                MatrixAInput.Text = newMatrix.ToString();
            } catch (FormatException err) {
                PrintErrorA("N и M целые должны быть целыми числами");
            } catch (Exception err) {
                PrintErrorA(err.Message);
            }
        }

        private void ClearA_Click(object sender, EventArgs e) {
            ClearErrorA();
            MatrixAInput.Clear();
        }

        private void TransponseA_Click(object sender, EventArgs e) {
            ClearErrorA();
            try {
                Matrix transponsedMatrix = ConvertStringToMatrix(MatrixAInput.Text).Transpose();
                MatrixAInput.Text = transponsedMatrix.ToString();
            } catch (FormatException err) {
                PrintErrorA("Введите матрицу в правильном формате");
            } catch (Exception err) {
                PrintErrorA(err.Message);
            }
        }

        private void DeterminantA_Click(object sender, EventArgs e) {
            ClearErrorA();
            try {
                double determinant = ConvertStringToMatrix(MatrixAInput.Text).Determinant();
                MessageBox.Show($"Определитель матрицы: {determinant:0.00}", "Определитель");
            } catch (FormatException err) {
                PrintErrorA("Введите матрицу в правильном формате");
            } catch (Exception err) {
                PrintErrorA(err.Message);
            }
        }

        private void MultiplyA_Click(object sender, EventArgs e) {
            ClearErrorA();
            try {
                double multiplier = double.Parse(MatrixAMultiplierInput.Text);
                Matrix newMatrix = ConvertStringToMatrix(MatrixAInput.Text) * multiplier;
                MatrixAInput.Text = newMatrix.ToString();
            } catch (FormatException err) {
                PrintErrorA("Введите матрицу и множитель в правильном формате");
            } catch (Exception err) {
                PrintErrorA(err.Message);
            }
        }

        private void RaistoToPowerA_Click(object sender, EventArgs e) {
            ClearErrorA();
            try {
                int argument = int.Parse(MatrixAArumentInput.Text);
                Matrix newMatrix = ConvertStringToMatrix(MatrixAInput.Text) ^ argument;
                MatrixAArumentInput.Text = argument.ToString();
                MatrixAInput.Text = newMatrix.ToString();
            } catch (FormatException err) {
                PrintErrorA("Введите аргумент и матрицу в правильном формате");
            } catch (Exception err) {
                PrintErrorA(err.Message);
            }
        }

        private void ReverseA_Click(object sender, EventArgs e) {
            ClearErrorA();
            try {
                Matrix inversedMatrix = ConvertStringToMatrix(MatrixAInput.Text).Inverse();
                MatrixAInput.Text = inversedMatrix.ToString();
            } catch (FormatException err) {
                PrintErrorA("Введите матрицу в правильном формате");
            } catch (Exception err) {
                PrintErrorA(err.Message);
            }
        }

        private void GenerateB_Click(object sender, EventArgs e) {
            ClearErrorB();
            try {
                int N = int.Parse(MatrixBNInput.Text);
                int M = int.Parse(MatrixBMInput.Text);
                if (N < 0 || M < 0) {
                    N = Math.Abs(N);
                    M = Math.Abs(M);
                }
                MatrixBNInput.Text = N.ToString();
                MatrixBMInput.Text = M.ToString();
                Matrix newMatrix = new Matrix(N, M, new Random());
                MatrixBInput.Text = newMatrix.ToString();
            } catch (FormatException err) {
                PrintErrorB("N и M целые должны быть целыми числами");
            } catch (Exception err) {
                PrintErrorB(err.Message);
            }
        }

        private void ClearB_Click(object sender, EventArgs e) {
            ClearErrorB();
            MatrixBInput.Clear();
        }

        private void TransponseB_Click(object sender, EventArgs e) {
            ClearErrorB();
            try {
                Matrix transponsedMatrix = ConvertStringToMatrix(MatrixBInput.Text).Transpose();
                MatrixBInput.Text = transponsedMatrix.ToString();
            } catch (FormatException err) {
                PrintErrorB("Введите матрицу в правильном формате");
            } catch (Exception err) {
                PrintErrorB(err.Message);
            }
        }

        private void DeterminantB_Click(object sender, EventArgs e) {
            ClearErrorB();
            try {
                double determinant = ConvertStringToMatrix(MatrixBInput.Text).Determinant();
                MessageBox.Show($"Определитель матрицы: {determinant:0.00}", "Определитель");
            } catch (FormatException err) {
                PrintErrorB("Введите матрицу в правильном формате");
            } catch (Exception err) {
                PrintErrorB(err.Message);
            }
        }

        private void MultiplyB_Click(object sender, EventArgs e) {
            ClearErrorB();
            try {
                double multiplier = double.Parse(MatrixBMultiplierInput.Text);
                Matrix newMatrix = ConvertStringToMatrix(MatrixBInput.Text) * multiplier;
                MatrixBInput.Text = newMatrix.ToString();
            } catch (FormatException err) {
                PrintErrorB("Введите матрицу и множитель в правильном формате");
            } catch (Exception err) {
                PrintErrorB(err.Message);
            }
        }

        private void RaistoToPowerB_Click(object sender, EventArgs e) {
            ClearErrorB();
            try {
                int argument = int.Parse(MatrixBArumentInput.Text);
                Matrix newMatrix = ConvertStringToMatrix(MatrixBInput.Text) ^ argument;
                MatrixBArumentInput.Text = argument.ToString();
                MatrixBInput.Text = newMatrix.ToString();
            } catch (FormatException err) {
                PrintErrorB("Введите матрицу и аргумент в правильном формате");
            } catch (Exception err) {
                PrintErrorB(err.Message);
            }
        }

        private void ReverseB_Click(object sender, EventArgs e) {
            ClearErrorB();
            try {
                Matrix inversedMatrix = ConvertStringToMatrix(MatrixBInput.Text).Inverse();
                MatrixBInput.Text = inversedMatrix.ToString();
            } catch (FormatException err) {
                PrintErrorB("Введите матрицу в правильном формате");
            } catch (Exception err) {
                PrintErrorB(err.Message);
            }
        }

        private void OnlyNumbers(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != ' ') && (e.KeyChar != '-')) {
                e.Handled = true;
            }
        }

        private void Swap_Click(object sender, EventArgs e) {
            string tmp = ErrorA.Text;
            ErrorA.Text = ErrorB.Text;
            ErrorB.Text = tmp;
            tmp = MatrixAInput.Text;
            MatrixAInput.Text = MatrixBInput.Text;
            MatrixBInput.Text = tmp;
        }

        private void Sum_Click(object sender, EventArgs e) {
            ClearErrorA();
            ClearErrorB();
            try {
                Matrix a = ConvertStringToMatrix(MatrixAInput.Text);
                Matrix b = ConvertStringToMatrix(MatrixBInput.Text);
                Matrix c = a + b;
                MatrixOutput.Text = c.ToString();
            } catch (FormatException err) {
                PrintErrorA("Введите матрицы в нужном формате");
            } catch (Exception err) {
                PrintErrorA(err.Message);
            }
        }

        private void Substraction_Click(object sender, EventArgs e) {
            ClearErrorA();
            ClearErrorB();
            try {

                Matrix a = ConvertStringToMatrix(MatrixAInput.Text);
                Matrix b = ConvertStringToMatrix(MatrixBInput.Text);
                Matrix c = a - b;
                MatrixOutput.Text = c.ToString();
            } catch (FormatException err) {
                PrintErrorA("Введите матрицы в нужном формате");
            } catch (Exception err) {
                PrintErrorA(err.Message);
            }
        }

        private void Multiplication_Click(object sender, EventArgs e) {
            ClearErrorA();
            ClearErrorB();
            try {
                Matrix a = ConvertStringToMatrix(MatrixAInput.Text);
                Matrix b = ConvertStringToMatrix(MatrixBInput.Text);
                Matrix c = a * b;
                MatrixOutput.Text = c.ToString();
            } catch (FormatException err) {
                PrintErrorA("Введите матрицы в нужном формате");
            } catch (Exception err) {
                PrintErrorA(err.Message);
            }
        }

        private void InsertResultInA_Click(object sender, EventArgs e) {
            MatrixAInput.Text = MatrixOutput.Text;
            MatrixOutput.Clear();
        }

        private void InsertResultInB_Click(object sender, EventArgs e) {
            MatrixBInput.Text = MatrixOutput.Text;
            MatrixOutput.Clear();
        }
    }
}
