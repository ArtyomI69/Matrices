using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMatrixes {
    public enum Forms {
        MatrixCalculator,
        SoLE
    }

    public partial class MainForm : Form {
        public Forms OpenedForm = Forms.MatrixCalculator;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            ShowFormMatrices();
            MatrixCalculatorTab.BackColor = Color.FromArgb(255, 200, 200, 200);
        }

        private void ShowFormMatrices() {
            MatricesForm formTables = new MatricesForm();
            formTables.TopLevel = false;
            formTables.Text = "";
            formTables.ControlBox = false;
            formTables.Dock = DockStyle.Fill;
            // Добавляем форму таблицы как элемент управления внутрь элемента Panel
            ControlPanel.Controls.Add(formTables);
            formTables.BringToFront();
            formTables.Show();
        }

        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            foreach (ToolStripMenuItem item in MenuStrip.Items) {
                item.BackColor = SystemColors.Control;
            }
            e.ClickedItem.BackColor = Color.FromArgb(255, 200, 200, 200);
        }

        private void MatrixCalculatorTab_Click(object sender, EventArgs e) {
            if (OpenedForm == Forms.MatrixCalculator) return;
            ShowFormMatrices();
            OpenedForm = Forms.MatrixCalculator;
        }
    }
}
