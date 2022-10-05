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
            ErrorALabel.Text = message;
        }

        private void ClearErrorA() {
            ErrorALabel.Text = "";
        }

        private void PrintErrorB(string message) {
            ErrorBLabel.Text = message;
        }

        private void ClearErrorB() {
            ErrorBLabel.Text = "";
        }

        private void GenerateAButton_Click(object sender, EventArgs e) {
            ClearErrorA();
            try {
                int N = int.Parse(NColumnANumeric.Value.ToString());
                int M = int.Parse(NRowANumeric.Value.ToString());
                if (N < 0 || M < 0) {
                    N = Math.Abs(N);
                    M = Math.Abs(M);
                }
                NColumnANumeric.Value = N;
                NRowANumeric.Value = M;
                Matrix newMatrix = new Matrix(N, M, new Random());
                ARichTextBox.Text = newMatrix.ToString();
            } catch (Exception err) {
                PrintErrorA(err.Message);
            }
        }

        private void ClearAButton_Click(object sender, EventArgs e) {
            ClearErrorA();
            ARichTextBox.Clear();
        }

        private void TransponseAButton_Click(object sender, EventArgs e) {
            ClearErrorA();
            try {
                Matrix transponsedMatrix = ConvertStringToMatrix(ARichTextBox.Text.ToString()).Transpose();
                ARichTextBox.Text = transponsedMatrix.ToString();
            } catch (Exception err) {
                PrintErrorA(err.Message);
            }
        }

        private void DeterminantAButton_Click(object sender, EventArgs e) {
            ClearErrorA();
            try {
                double determinant = ConvertStringToMatrix(ARichTextBox.Text.ToString()).Determinant();
                MessageBox.Show($"Определитель матрицы: {determinant:0.00}", "Определитель");
            } catch (Exception err) {
                PrintErrorA(err.Message);
            }
        }

        private void MultiplyAButton_Click(object sender, EventArgs e) {
            ClearErrorA();
            try {
                int multiplier = int.Parse(MultiplierANumeric.Value.ToString());
                Matrix newMatrix = ConvertStringToMatrix(ARichTextBox.Text.ToString()) * multiplier;
                ARichTextBox.Text = newMatrix.ToString();
            } catch (Exception err) {
                PrintErrorA(err.Message);
            }
        }

        private void RaistoToPowerAButton_Click(object sender, EventArgs e) {
            ClearErrorA();
            try {
                int argument = int.Parse(ArgumentANumeric.Value.ToString());
                Matrix newMatrix = ConvertStringToMatrix(ARichTextBox.Text.ToString()) ^ argument;
                ArgumentANumeric.Value = argument;
                ARichTextBox.Text = newMatrix.ToString();
            } catch (Exception err) {
                PrintErrorA(err.Message);
            }
        }

        private void ReverseAButton_Click(object sender, EventArgs e) {
            ClearErrorA();
            try {
                Matrix inversedMatrix = ConvertStringToMatrix(ARichTextBox.Text.ToString()).Inverse();
                ARichTextBox.Text = inversedMatrix.ToString();
            } catch (Exception err) {
                PrintErrorA(err.Message);
            }
        }

        private void ClearBButton_Click(object sender, EventArgs e) {
            ClearErrorB();
            BRichTextBox.Clear();
        }

        private void GenerateBButton_Click(object sender, EventArgs e) {
            ClearErrorB();
            try {
                int N = int.Parse(NColumnBNumeric.Value.ToString());
                int M = int.Parse(NRowBNumeric.Value.ToString());
                if (N < 0 || M < 0) {
                    N = Math.Abs(N);
                    M = Math.Abs(M);
                }
                NColumnBNumeric.Value = N;
                NRowBNumeric.Value = M;
                Matrix newMatrix = new Matrix(N, M, new Random());
                BRichTextBox.Text = newMatrix.ToString();
            } catch (Exception err) {
                PrintErrorB(err.Message);
            }
        }

        private void TransponseBButton_Click(object sender, EventArgs e) {
            ClearErrorB();
            try {
                Matrix transponsedMatrix = ConvertStringToMatrix(BRichTextBox.Text.ToString()).Transpose();
                BRichTextBox.Text = transponsedMatrix.ToString();
            } catch (Exception err) {
                PrintErrorB(err.Message);
            }
        }

        private void DeterminantBButton_Click(object sender, EventArgs e) {
            double determinant = ConvertStringToMatrix(BRichTextBox.Text.ToString()).Determinant();
            MessageBox.Show($"Определитель матрицы: {determinant:0.00}", "Определитель");
        }

        private void MultiplyBButton_Click(object sender, EventArgs e) {
            ClearErrorB();
            try {
                int multiplier = int.Parse(MultiplierBNumeric.Value.ToString());
                Matrix newMatrix = ConvertStringToMatrix(BRichTextBox.Text.ToString()) * multiplier;
                BRichTextBox.Text = newMatrix.ToString();
            } catch (Exception err) {
                PrintErrorB(err.Message);
            }
        }

        private void RaistoToPowerBButton_Click(object sender, EventArgs e) {
            ClearErrorB();
            try {
                int argument = int.Parse(ArgumentBNumeric.Value.ToString());
                Matrix newMatrix = ConvertStringToMatrix(BRichTextBox.Text.ToString()) ^ argument;
                ArgumentANumeric.Value = argument;
                BRichTextBox.Text = newMatrix.ToString();
            } catch (Exception err) {
                PrintErrorB(err.Message);
            }
        }

        private void ReverseBButton_Click(object sender, EventArgs e) {
            ClearErrorB();
            try {
                Matrix inversedMatrix = ConvertStringToMatrix(BRichTextBox.Text.ToString()).Inverse();
                BRichTextBox.Text = inversedMatrix.ToString();
            } catch (Exception err) {
                PrintErrorB(err.Message);
            }
        }

        private void SumButton_Click(object sender, EventArgs e) {
            ClearErrorA();
            ClearErrorB();
            try {
                Matrix a = ConvertStringToMatrix(ARichTextBox.Text.ToString());
                Matrix b = ConvertStringToMatrix(BRichTextBox.Text.ToString());
                CRichTextBox.Text = (a + b).ToString();
            } catch (Exception err) {
                PrintErrorA(err.Message);
                PrintErrorB(err.Message);
            }
        }

        private void SubtractionButton_Click(object sender, EventArgs e) {
            ClearErrorA();
            ClearErrorB();
            try {
                Matrix a = ConvertStringToMatrix(ARichTextBox.Text.ToString());
                Matrix b = ConvertStringToMatrix(BRichTextBox.Text.ToString());
                CRichTextBox.Text = (a - b).ToString();
            } catch (Exception err) {
                PrintErrorA(err.Message);
                PrintErrorB(err.Message);
            }
        }

        private void MultiplyButton_Click(object sender, EventArgs e) {
            ClearErrorA();
            ClearErrorB();
            try {
                Matrix a = ConvertStringToMatrix(ARichTextBox.Text.ToString());
                Matrix b = ConvertStringToMatrix(BRichTextBox.Text.ToString());
                CRichTextBox.Text = (a * b).ToString();
            } catch (Exception err) {
                PrintErrorA(err.Message);
                PrintErrorB(err.Message);
            }
        }

        private void ARichTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != ' ')) {
                e.Handled = true;
            }
        }

        private void BRichTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != ' ')) {
                e.Handled = true;
            }
        }

        private void CRichTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != ' ')) {
                e.Handled = true;
            }
        }
    }
}
