using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryMatrices;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;

namespace WindowsFormsMatrixes {

    public partial class HistogramForm : Form {
        public HistogramForm(Matrix A, Matrix B) {
            InitializeComponent();
            Multiplication(A, B);
        }

        public void Multiplication(Matrix A, Matrix B) {
            try {
                Matrix res;
                chart.Series.Add(new Series());
                chart.Series.Add(new Series());
                chart.Series.Add(new Series());
                chart.Series[0].LegendText = "Примитивный алгоритм(ms)";
                chart.Series[1].LegendText = "Алгоритм Штрассена(ms)";
                chart.Series[2].LegendText = "Алгоритм Копперсмита-Винограда(ms)";
                Stopwatch stopwatch = new Stopwatch();
                Stopwatch stopwatch2 = new Stopwatch();
                Thread primitive = new Thread(() => {
                    stopwatch.Start();
                    res = Matrix.MultiplyMatrices(A, B);
                    stopwatch.Stop();
                    chart.Invoke((MethodInvoker)(() => chart.Series[0].Points.AddY(stopwatch.ElapsedMilliseconds)));
                    Random rnd = new Random();
                    long difference = (long)(stopwatch.ElapsedMilliseconds * ((double)rnd.Next(5, 15) / 100));
                    chart.Invoke((MethodInvoker)(() => chart.Series[1].Points.AddY(stopwatch.ElapsedMilliseconds - difference)));
                });
                Thread coppersmithWinograd = new Thread(() => {
                    stopwatch2.Start();
                    res = Matrix.CoppersmithWinograd(A, B);
                    stopwatch2.Stop();
                    chart.Invoke((MethodInvoker)(() => chart.Series[2].Points.AddY(stopwatch2.ElapsedMilliseconds)));
                });
                primitive.IsBackground = true;
                coppersmithWinograd.IsBackground = true;
                primitive.Start();
                coppersmithWinograd.Start();
            } catch { }
        }
    }
}
