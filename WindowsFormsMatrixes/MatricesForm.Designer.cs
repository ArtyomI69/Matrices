namespace WindowsFormsMatrixes {
    partial class MatricesForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.PanelInput = new System.Windows.Forms.Panel();
            this.PanelB = new System.Windows.Forms.Panel();
            this.NRowBNumeric = new System.Windows.Forms.NumericUpDown();
            this.NColumnBNumeric = new System.Windows.Forms.NumericUpDown();
            this.MultiplierBNumeric = new System.Windows.Forms.NumericUpDown();
            this.ArgumentBNumeric = new System.Windows.Forms.NumericUpDown();
            this.ReverseBButton = new System.Windows.Forms.Button();
            this.RaistoToPowerBButton = new System.Windows.Forms.Button();
            this.DeterminantBButton = new System.Windows.Forms.Button();
            this.TransponseBButton = new System.Windows.Forms.Button();
            this.MultiplyBButton = new System.Windows.Forms.Button();
            this.ClearBButton = new System.Windows.Forms.Button();
            this.GenerateBButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PanelActions = new System.Windows.Forms.Panel();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.SubtractionButton = new System.Windows.Forms.Button();
            this.SumButton = new System.Windows.Forms.Button();
            this.PanelA = new System.Windows.Forms.Panel();
            this.NRowANumeric = new System.Windows.Forms.NumericUpDown();
            this.NColumnANumeric = new System.Windows.Forms.NumericUpDown();
            this.MultiplierANumeric = new System.Windows.Forms.NumericUpDown();
            this.ArgumentANumeric = new System.Windows.Forms.NumericUpDown();
            this.ReverseAButton = new System.Windows.Forms.Button();
            this.RaistoToPowerAButton = new System.Windows.Forms.Button();
            this.DeterminantAButton = new System.Windows.Forms.Button();
            this.TransponseAButton = new System.Windows.Forms.Button();
            this.MultiplyAButton = new System.Windows.Forms.Button();
            this.ClearAButton = new System.Windows.Forms.Button();
            this.GenerateAButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ARichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelOutput = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.CRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ErrorALabel = new System.Windows.Forms.Label();
            this.ErrorBLabel = new System.Windows.Forms.Label();
            this.PanelInput.SuspendLayout();
            this.PanelB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NRowBNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NColumnBNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplierBNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArgumentBNumeric)).BeginInit();
            this.PanelActions.SuspendLayout();
            this.PanelA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NRowANumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NColumnANumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplierANumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArgumentANumeric)).BeginInit();
            this.PanelOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelInput
            // 
            this.PanelInput.Controls.Add(this.PanelB);
            this.PanelInput.Controls.Add(this.PanelActions);
            this.PanelInput.Controls.Add(this.PanelA);
            this.PanelInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelInput.Location = new System.Drawing.Point(0, 0);
            this.PanelInput.Name = "PanelInput";
            this.PanelInput.Size = new System.Drawing.Size(1204, 628);
            this.PanelInput.TabIndex = 0;
            // 
            // PanelB
            // 
            this.PanelB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelB.Controls.Add(this.ErrorBLabel);
            this.PanelB.Controls.Add(this.NRowBNumeric);
            this.PanelB.Controls.Add(this.NColumnBNumeric);
            this.PanelB.Controls.Add(this.MultiplierBNumeric);
            this.PanelB.Controls.Add(this.ArgumentBNumeric);
            this.PanelB.Controls.Add(this.ReverseBButton);
            this.PanelB.Controls.Add(this.RaistoToPowerBButton);
            this.PanelB.Controls.Add(this.DeterminantBButton);
            this.PanelB.Controls.Add(this.TransponseBButton);
            this.PanelB.Controls.Add(this.MultiplyBButton);
            this.PanelB.Controls.Add(this.ClearBButton);
            this.PanelB.Controls.Add(this.GenerateBButton);
            this.PanelB.Controls.Add(this.label4);
            this.PanelB.Controls.Add(this.label5);
            this.PanelB.Controls.Add(this.BRichTextBox);
            this.PanelB.Controls.Add(this.label6);
            this.PanelB.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelB.Location = new System.Drawing.Point(673, 0);
            this.PanelB.Name = "PanelB";
            this.PanelB.Size = new System.Drawing.Size(531, 628);
            this.PanelB.TabIndex = 3;
            // 
            // NRowBNumeric
            // 
            this.NRowBNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NRowBNumeric.Location = new System.Drawing.Point(300, 261);
            this.NRowBNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NRowBNumeric.Name = "NRowBNumeric";
            this.NRowBNumeric.Size = new System.Drawing.Size(120, 30);
            this.NRowBNumeric.TabIndex = 22;
            this.NRowBNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NColumnBNumeric
            // 
            this.NColumnBNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NColumnBNumeric.Location = new System.Drawing.Point(119, 261);
            this.NColumnBNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NColumnBNumeric.Name = "NColumnBNumeric";
            this.NColumnBNumeric.Size = new System.Drawing.Size(120, 30);
            this.NColumnBNumeric.TabIndex = 21;
            this.NColumnBNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MultiplierBNumeric
            // 
            this.MultiplierBNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultiplierBNumeric.Location = new System.Drawing.Point(424, 361);
            this.MultiplierBNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MultiplierBNumeric.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.MultiplierBNumeric.Name = "MultiplierBNumeric";
            this.MultiplierBNumeric.Size = new System.Drawing.Size(80, 30);
            this.MultiplierBNumeric.TabIndex = 20;
            // 
            // ArgumentBNumeric
            // 
            this.ArgumentBNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArgumentBNumeric.Location = new System.Drawing.Point(424, 413);
            this.ArgumentBNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ArgumentBNumeric.Name = "ArgumentBNumeric";
            this.ArgumentBNumeric.Size = new System.Drawing.Size(80, 30);
            this.ArgumentBNumeric.TabIndex = 19;
            // 
            // ReverseBButton
            // 
            this.ReverseBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.ReverseBButton.Location = new System.Drawing.Point(256, 461);
            this.ReverseBButton.Name = "ReverseBButton";
            this.ReverseBButton.Size = new System.Drawing.Size(251, 37);
            this.ReverseBButton.TabIndex = 14;
            this.ReverseBButton.Text = "Обратная матрица";
            this.ReverseBButton.UseVisualStyleBackColor = true;
            this.ReverseBButton.Click += new System.EventHandler(this.ReverseBButton_Click);
            // 
            // RaistoToPowerBButton
            // 
            this.RaistoToPowerBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RaistoToPowerBButton.Location = new System.Drawing.Point(257, 408);
            this.RaistoToPowerBButton.Name = "RaistoToPowerBButton";
            this.RaistoToPowerBButton.Size = new System.Drawing.Size(163, 37);
            this.RaistoToPowerBButton.TabIndex = 13;
            this.RaistoToPowerBButton.Text = "Возвести в ";
            this.RaistoToPowerBButton.UseVisualStyleBackColor = true;
            this.RaistoToPowerBButton.Click += new System.EventHandler(this.RaistoToPowerBButton_Click);
            // 
            // DeterminantBButton
            // 
            this.DeterminantBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeterminantBButton.Location = new System.Drawing.Point(15, 461);
            this.DeterminantBButton.Name = "DeterminantBButton";
            this.DeterminantBButton.Size = new System.Drawing.Size(235, 37);
            this.DeterminantBButton.TabIndex = 11;
            this.DeterminantBButton.Text = "Определитель";
            this.DeterminantBButton.UseVisualStyleBackColor = true;
            this.DeterminantBButton.Click += new System.EventHandler(this.DeterminantBButton_Click);
            // 
            // TransponseBButton
            // 
            this.TransponseBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransponseBButton.Location = new System.Drawing.Point(15, 408);
            this.TransponseBButton.Name = "TransponseBButton";
            this.TransponseBButton.Size = new System.Drawing.Size(235, 37);
            this.TransponseBButton.TabIndex = 10;
            this.TransponseBButton.Text = "Транспонировать";
            this.TransponseBButton.UseVisualStyleBackColor = true;
            this.TransponseBButton.Click += new System.EventHandler(this.TransponseBButton_Click);
            // 
            // MultiplyBButton
            // 
            this.MultiplyBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultiplyBButton.Location = new System.Drawing.Point(256, 356);
            this.MultiplyBButton.Name = "MultiplyBButton";
            this.MultiplyBButton.Size = new System.Drawing.Size(163, 37);
            this.MultiplyBButton.TabIndex = 9;
            this.MultiplyBButton.Text = "Умножить на";
            this.MultiplyBButton.UseVisualStyleBackColor = true;
            this.MultiplyBButton.Click += new System.EventHandler(this.MultiplyBButton_Click);
            // 
            // ClearBButton
            // 
            this.ClearBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearBButton.Location = new System.Drawing.Point(15, 356);
            this.ClearBButton.Name = "ClearBButton";
            this.ClearBButton.Size = new System.Drawing.Size(235, 37);
            this.ClearBButton.TabIndex = 8;
            this.ClearBButton.Text = "Очистить";
            this.ClearBButton.UseVisualStyleBackColor = true;
            this.ClearBButton.Click += new System.EventHandler(this.ClearBButton_Click);
            // 
            // GenerateBButton
            // 
            this.GenerateBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateBButton.Location = new System.Drawing.Point(15, 309);
            this.GenerateBButton.Name = "GenerateBButton";
            this.GenerateBButton.Size = new System.Drawing.Size(489, 39);
            this.GenerateBButton.TabIndex = 7;
            this.GenerateBButton.Text = "Сгенерировать";
            this.GenerateBButton.UseVisualStyleBackColor = true;
            this.GenerateBButton.Click += new System.EventHandler(this.GenerateBButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(261, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "M";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(82, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "N";
            // 
            // BRichTextBox
            // 
            this.BRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BRichTextBox.Location = new System.Drawing.Point(12, 70);
            this.BRichTextBox.Name = "BRichTextBox";
            this.BRichTextBox.Size = new System.Drawing.Size(492, 185);
            this.BRichTextBox.TabIndex = 2;
            this.BRichTextBox.Text = "";
            this.BRichTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BRichTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(247, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "B";
            // 
            // PanelActions
            // 
            this.PanelActions.BackColor = System.Drawing.Color.White;
            this.PanelActions.Controls.Add(this.MultiplyButton);
            this.PanelActions.Controls.Add(this.SubtractionButton);
            this.PanelActions.Controls.Add(this.SumButton);
            this.PanelActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelActions.Location = new System.Drawing.Point(525, 0);
            this.PanelActions.Name = "PanelActions";
            this.PanelActions.Size = new System.Drawing.Size(679, 628);
            this.PanelActions.TabIndex = 2;
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultiplyButton.Location = new System.Drawing.Point(11, 302);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(119, 40);
            this.MultiplyButton.TabIndex = 2;
            this.MultiplyButton.Text = "A × B";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // SubtractionButton
            // 
            this.SubtractionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubtractionButton.Location = new System.Drawing.Point(11, 251);
            this.SubtractionButton.Name = "SubtractionButton";
            this.SubtractionButton.Size = new System.Drawing.Size(119, 40);
            this.SubtractionButton.TabIndex = 1;
            this.SubtractionButton.Text = "A - B";
            this.SubtractionButton.UseVisualStyleBackColor = true;
            this.SubtractionButton.Click += new System.EventHandler(this.SubtractionButton_Click);
            // 
            // SumButton
            // 
            this.SumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumButton.Location = new System.Drawing.Point(11, 205);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(119, 40);
            this.SumButton.TabIndex = 0;
            this.SumButton.Text = "A + B";
            this.SumButton.UseVisualStyleBackColor = true;
            this.SumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // PanelA
            // 
            this.PanelA.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelA.Controls.Add(this.ErrorALabel);
            this.PanelA.Controls.Add(this.NRowANumeric);
            this.PanelA.Controls.Add(this.NColumnANumeric);
            this.PanelA.Controls.Add(this.MultiplierANumeric);
            this.PanelA.Controls.Add(this.ArgumentANumeric);
            this.PanelA.Controls.Add(this.ReverseAButton);
            this.PanelA.Controls.Add(this.RaistoToPowerAButton);
            this.PanelA.Controls.Add(this.DeterminantAButton);
            this.PanelA.Controls.Add(this.TransponseAButton);
            this.PanelA.Controls.Add(this.MultiplyAButton);
            this.PanelA.Controls.Add(this.ClearAButton);
            this.PanelA.Controls.Add(this.GenerateAButton);
            this.PanelA.Controls.Add(this.label3);
            this.PanelA.Controls.Add(this.label2);
            this.PanelA.Controls.Add(this.ARichTextBox);
            this.PanelA.Controls.Add(this.label1);
            this.PanelA.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelA.Location = new System.Drawing.Point(0, 0);
            this.PanelA.Name = "PanelA";
            this.PanelA.Size = new System.Drawing.Size(525, 628);
            this.PanelA.TabIndex = 0;
            // 
            // NRowANumeric
            // 
            this.NRowANumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NRowANumeric.Location = new System.Drawing.Point(298, 256);
            this.NRowANumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NRowANumeric.Name = "NRowANumeric";
            this.NRowANumeric.Size = new System.Drawing.Size(120, 30);
            this.NRowANumeric.TabIndex = 20;
            this.NRowANumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NColumnANumeric
            // 
            this.NColumnANumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NColumnANumeric.Location = new System.Drawing.Point(113, 256);
            this.NColumnANumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NColumnANumeric.Name = "NColumnANumeric";
            this.NColumnANumeric.Size = new System.Drawing.Size(120, 30);
            this.NColumnANumeric.TabIndex = 19;
            this.NColumnANumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MultiplierANumeric
            // 
            this.MultiplierANumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultiplierANumeric.Location = new System.Drawing.Point(423, 361);
            this.MultiplierANumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MultiplierANumeric.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.MultiplierANumeric.Name = "MultiplierANumeric";
            this.MultiplierANumeric.Size = new System.Drawing.Size(80, 30);
            this.MultiplierANumeric.TabIndex = 18;
            // 
            // ArgumentANumeric
            // 
            this.ArgumentANumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArgumentANumeric.Location = new System.Drawing.Point(424, 413);
            this.ArgumentANumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ArgumentANumeric.Name = "ArgumentANumeric";
            this.ArgumentANumeric.Size = new System.Drawing.Size(80, 30);
            this.ArgumentANumeric.TabIndex = 17;
            // 
            // ReverseAButton
            // 
            this.ReverseAButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReverseAButton.Location = new System.Drawing.Point(256, 461);
            this.ReverseAButton.Name = "ReverseAButton";
            this.ReverseAButton.Size = new System.Drawing.Size(248, 37);
            this.ReverseAButton.TabIndex = 14;
            this.ReverseAButton.Text = "Обратная матрица";
            this.ReverseAButton.UseVisualStyleBackColor = true;
            this.ReverseAButton.Click += new System.EventHandler(this.ReverseAButton_Click);
            // 
            // RaistoToPowerAButton
            // 
            this.RaistoToPowerAButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RaistoToPowerAButton.Location = new System.Drawing.Point(255, 408);
            this.RaistoToPowerAButton.Name = "RaistoToPowerAButton";
            this.RaistoToPowerAButton.Size = new System.Drawing.Size(162, 37);
            this.RaistoToPowerAButton.TabIndex = 13;
            this.RaistoToPowerAButton.Text = "Возвести в ";
            this.RaistoToPowerAButton.UseVisualStyleBackColor = true;
            this.RaistoToPowerAButton.Click += new System.EventHandler(this.RaistoToPowerAButton_Click);
            // 
            // DeterminantAButton
            // 
            this.DeterminantAButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeterminantAButton.Location = new System.Drawing.Point(15, 461);
            this.DeterminantAButton.Name = "DeterminantAButton";
            this.DeterminantAButton.Size = new System.Drawing.Size(235, 37);
            this.DeterminantAButton.TabIndex = 11;
            this.DeterminantAButton.Text = "Определитель";
            this.DeterminantAButton.UseVisualStyleBackColor = true;
            this.DeterminantAButton.Click += new System.EventHandler(this.DeterminantAButton_Click);
            // 
            // TransponseAButton
            // 
            this.TransponseAButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransponseAButton.Location = new System.Drawing.Point(15, 408);
            this.TransponseAButton.Name = "TransponseAButton";
            this.TransponseAButton.Size = new System.Drawing.Size(235, 37);
            this.TransponseAButton.TabIndex = 10;
            this.TransponseAButton.Text = "Транспонировать";
            this.TransponseAButton.UseVisualStyleBackColor = true;
            this.TransponseAButton.Click += new System.EventHandler(this.TransponseAButton_Click);
            // 
            // MultiplyAButton
            // 
            this.MultiplyAButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultiplyAButton.Location = new System.Drawing.Point(254, 361);
            this.MultiplyAButton.Name = "MultiplyAButton";
            this.MultiplyAButton.Size = new System.Drawing.Size(163, 37);
            this.MultiplyAButton.TabIndex = 9;
            this.MultiplyAButton.Text = "Умножить на";
            this.MultiplyAButton.UseVisualStyleBackColor = true;
            this.MultiplyAButton.Click += new System.EventHandler(this.MultiplyAButton_Click);
            // 
            // ClearAButton
            // 
            this.ClearAButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearAButton.Location = new System.Drawing.Point(15, 361);
            this.ClearAButton.Name = "ClearAButton";
            this.ClearAButton.Size = new System.Drawing.Size(235, 37);
            this.ClearAButton.TabIndex = 8;
            this.ClearAButton.Text = "Очистить";
            this.ClearAButton.UseVisualStyleBackColor = true;
            this.ClearAButton.Click += new System.EventHandler(this.ClearAButton_Click);
            // 
            // GenerateAButton
            // 
            this.GenerateAButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateAButton.Location = new System.Drawing.Point(15, 309);
            this.GenerateAButton.Name = "GenerateAButton";
            this.GenerateAButton.Size = new System.Drawing.Size(489, 39);
            this.GenerateAButton.TabIndex = 7;
            this.GenerateAButton.Text = "Сгенерировать";
            this.GenerateAButton.UseVisualStyleBackColor = true;
            this.GenerateAButton.Click += new System.EventHandler(this.GenerateAButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(259, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "M";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(76, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "N";
            // 
            // ARichTextBox
            // 
            this.ARichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ARichTextBox.Location = new System.Drawing.Point(12, 70);
            this.ARichTextBox.Name = "ARichTextBox";
            this.ARichTextBox.Size = new System.Drawing.Size(492, 180);
            this.ARichTextBox.TabIndex = 2;
            this.ARichTextBox.Text = "";
            this.ARichTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ARichTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(249, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // PanelOutput
            // 
            this.PanelOutput.BackColor = System.Drawing.Color.White;
            this.PanelOutput.Controls.Add(this.label8);
            this.PanelOutput.Controls.Add(this.CRichTextBox);
            this.PanelOutput.Controls.Add(this.label7);
            this.PanelOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelOutput.Location = new System.Drawing.Point(1204, 0);
            this.PanelOutput.Name = "PanelOutput";
            this.PanelOutput.Size = new System.Drawing.Size(562, 628);
            this.PanelOutput.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(241, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 32);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ответ";
            // 
            // CRichTextBox
            // 
            this.CRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CRichTextBox.Location = new System.Drawing.Point(46, 70);
            this.CRichTextBox.Name = "CRichTextBox";
            this.CRichTextBox.Size = new System.Drawing.Size(492, 429);
            this.CRichTextBox.TabIndex = 17;
            this.CRichTextBox.Text = "";
            this.CRichTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CRichTextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(-8, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 51);
            this.label7.TabIndex = 0;
            this.label7.Text = "=";
            // 
            // ErrorALabel
            // 
            this.ErrorALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorALabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorALabel.Location = new System.Drawing.Point(15, 530);
            this.ErrorALabel.Name = "ErrorALabel";
            this.ErrorALabel.Size = new System.Drawing.Size(489, 97);
            this.ErrorALabel.TabIndex = 21;
            // 
            // ErrorBLabel
            // 
            this.ErrorBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorBLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorBLabel.Location = new System.Drawing.Point(15, 530);
            this.ErrorBLabel.Name = "ErrorBLabel";
            this.ErrorBLabel.Size = new System.Drawing.Size(492, 88);
            this.ErrorBLabel.TabIndex = 23;
            // 
            // MatricesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1766, 628);
            this.Controls.Add(this.PanelOutput);
            this.Controls.Add(this.PanelInput);
            this.Name = "MatricesForm";
            this.Text = "Матрицы";
            this.PanelInput.ResumeLayout(false);
            this.PanelB.ResumeLayout(false);
            this.PanelB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NRowBNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NColumnBNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplierBNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArgumentBNumeric)).EndInit();
            this.PanelActions.ResumeLayout(false);
            this.PanelA.ResumeLayout(false);
            this.PanelA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NRowANumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NColumnANumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplierANumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArgumentANumeric)).EndInit();
            this.PanelOutput.ResumeLayout(false);
            this.PanelOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelInput;
        private System.Windows.Forms.Panel PanelOutput;
        private System.Windows.Forms.Panel PanelActions;
        private System.Windows.Forms.Panel PanelA;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button SubtractionButton;
        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.RichTextBox ARichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GenerateAButton;
        private System.Windows.Forms.Button ClearAButton;
        private System.Windows.Forms.Button ReverseAButton;
        private System.Windows.Forms.Button RaistoToPowerAButton;
        private System.Windows.Forms.Button DeterminantAButton;
        private System.Windows.Forms.Button TransponseAButton;
        private System.Windows.Forms.Panel PanelB;
        private System.Windows.Forms.Button ReverseBButton;
        private System.Windows.Forms.Button RaistoToPowerBButton;
        private System.Windows.Forms.Button DeterminantBButton;
        private System.Windows.Forms.Button TransponseBButton;
        private System.Windows.Forms.Button MultiplyBButton;
        private System.Windows.Forms.Button ClearBButton;
        private System.Windows.Forms.Button GenerateBButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox BRichTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox CRichTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button MultiplyAButton;
        private System.Windows.Forms.NumericUpDown MultiplierBNumeric;
        private System.Windows.Forms.NumericUpDown ArgumentBNumeric;
        private System.Windows.Forms.NumericUpDown MultiplierANumeric;
        private System.Windows.Forms.NumericUpDown ArgumentANumeric;
        private System.Windows.Forms.NumericUpDown NColumnBNumeric;
        private System.Windows.Forms.NumericUpDown NRowANumeric;
        private System.Windows.Forms.NumericUpDown NColumnANumeric;
        private System.Windows.Forms.NumericUpDown NRowBNumeric;
        private System.Windows.Forms.Label ErrorBLabel;
        private System.Windows.Forms.Label ErrorALabel;
    }
}

