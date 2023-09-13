namespace code_economy
{
    partial class InteresCompuesto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LabelInteresCompuesto = new Label();
            ComboBoxQCalcular = new ComboBox();
            LabelQCalcular = new Label();
            LabelPorciento = new Label();
            BtnCalcular = new Button();
            ComboBoxTiempo = new ComboBox();
            ComboBoxTI = new ComboBox();
            TextBoxTiempo = new TextBox();
            TextBoxVF = new TextBox();
            TextBoxTI = new TextBox();
            TextBoxCap = new TextBox();
            TextBoxInt = new TextBox();
            LabelTiempo = new Label();
            LabelValorFinal = new Label();
            LabelTasaInteres = new Label();
            LabelCapital = new Label();
            LabelInteres = new Label();
            SuspendLayout();
            // 
            // LabelInteresCompuesto
            // 
            LabelInteresCompuesto.Anchor = AnchorStyles.Top;
            LabelInteresCompuesto.AutoSize = true;
            LabelInteresCompuesto.Font = new Font("Segoe UI", 42F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LabelInteresCompuesto.ForeColor = Color.White;
            LabelInteresCompuesto.Location = new Point(215, 9);
            LabelInteresCompuesto.Name = "LabelInteresCompuesto";
            LabelInteresCompuesto.Size = new Size(516, 74);
            LabelInteresCompuesto.TabIndex = 1;
            LabelInteresCompuesto.Text = "Interes Compuesto";
            LabelInteresCompuesto.TextAlign = ContentAlignment.TopCenter;
            // 
            // ComboBoxQCalcular
            // 
            ComboBoxQCalcular.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxQCalcular.FormattingEnabled = true;
            ComboBoxQCalcular.Items.AddRange(new object[] { "Interes", "Capital", "Valor Final", "Tasa de Interes", "Tiempo" });
            ComboBoxQCalcular.Location = new Point(506, 136);
            ComboBoxQCalcular.Name = "ComboBoxQCalcular";
            ComboBoxQCalcular.Size = new Size(121, 23);
            ComboBoxQCalcular.TabIndex = 4;
            ComboBoxQCalcular.SelectedIndexChanged += ComboBoxQCalcular_SelectedIndexChanged;
            // 
            // LabelQCalcular
            // 
            LabelQCalcular.AutoSize = true;
            LabelQCalcular.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelQCalcular.ForeColor = Color.White;
            LabelQCalcular.Location = new Point(287, 129);
            LabelQCalcular.Name = "LabelQCalcular";
            LabelQCalcular.Size = new Size(213, 30);
            LabelQCalcular.TabIndex = 3;
            LabelQCalcular.Text = "¿Que desea calcular?";
            // 
            // LabelPorciento
            // 
            LabelPorciento.AutoSize = true;
            LabelPorciento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPorciento.ForeColor = Color.White;
            LabelPorciento.Location = new Point(502, 356);
            LabelPorciento.Name = "LabelPorciento";
            LabelPorciento.Size = new Size(24, 21);
            LabelPorciento.TabIndex = 33;
            LabelPorciento.Text = "%";
            // 
            // BtnCalcular
            // 
            BtnCalcular.BackColor = Color.FromArgb(255, 128, 0);
            BtnCalcular.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCalcular.ForeColor = Color.White;
            BtnCalcular.Location = new Point(410, 517);
            BtnCalcular.Margin = new Padding(2);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(160, 50);
            BtnCalcular.TabIndex = 32;
            BtnCalcular.Text = "Calcular";
            BtnCalcular.UseVisualStyleBackColor = false;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // ComboBoxTiempo
            // 
            ComboBoxTiempo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxTiempo.FormattingEnabled = true;
            ComboBoxTiempo.Items.AddRange(new object[] { "Dia", "Mensual", "Bimensual", "Trimestral", "Cuatrimestral", "Semestral", "Anual" });
            ComboBoxTiempo.Location = new Point(506, 392);
            ComboBoxTiempo.Name = "ComboBoxTiempo";
            ComboBoxTiempo.Size = new Size(121, 23);
            ComboBoxTiempo.TabIndex = 31;
            // 
            // ComboBoxTI
            // 
            ComboBoxTI.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxTI.FormattingEnabled = true;
            ComboBoxTI.Items.AddRange(new object[] { "Dia", "Mensual", "Bimensual", "Trimestral", "Cuatrimestral", "Semestral", "Anual" });
            ComboBoxTI.Location = new Point(532, 354);
            ComboBoxTI.Name = "ComboBoxTI";
            ComboBoxTI.Size = new Size(121, 23);
            ComboBoxTI.TabIndex = 30;
            // 
            // TextBoxTiempo
            // 
            TextBoxTiempo.Location = new Point(400, 392);
            TextBoxTiempo.Name = "TextBoxTiempo";
            TextBoxTiempo.Size = new Size(100, 23);
            TextBoxTiempo.TabIndex = 29;
            TextBoxTiempo.KeyPress += TextBoxTiempo_KeyPress;
            // 
            // TextBoxVF
            // 
            TextBoxVF.Location = new Point(400, 315);
            TextBoxVF.Name = "TextBoxVF";
            TextBoxVF.Size = new Size(100, 23);
            TextBoxVF.TabIndex = 28;
            TextBoxVF.KeyPress += TextBoxVF_KeyPress;
            // 
            // TextBoxTI
            // 
            TextBoxTI.Location = new Point(400, 354);
            TextBoxTI.Name = "TextBoxTI";
            TextBoxTI.Size = new Size(100, 23);
            TextBoxTI.TabIndex = 27;
            TextBoxTI.KeyPress += TextBoxTI_KeyPress;
            // 
            // TextBoxCap
            // 
            TextBoxCap.Location = new Point(400, 273);
            TextBoxCap.Name = "TextBoxCap";
            TextBoxCap.Size = new Size(100, 23);
            TextBoxCap.TabIndex = 26;
            TextBoxCap.KeyPress += TextBoxCap_KeyPress;
            // 
            // TextBoxInt
            // 
            TextBoxInt.Location = new Point(400, 238);
            TextBoxInt.Name = "TextBoxInt";
            TextBoxInt.Size = new Size(100, 23);
            TextBoxInt.TabIndex = 25;
            TextBoxInt.KeyPress += TextBoxInt_KeyPress;
            // 
            // LabelTiempo
            // 
            LabelTiempo.AutoSize = true;
            LabelTiempo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTiempo.ForeColor = Color.White;
            LabelTiempo.Location = new Point(297, 394);
            LabelTiempo.Name = "LabelTiempo";
            LabelTiempo.Size = new Size(66, 21);
            LabelTiempo.TabIndex = 24;
            LabelTiempo.Text = "Tiempo";
            // 
            // LabelValorFinal
            // 
            LabelValorFinal.AutoSize = true;
            LabelValorFinal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelValorFinal.ForeColor = Color.White;
            LabelValorFinal.Location = new Point(297, 317);
            LabelValorFinal.Name = "LabelValorFinal";
            LabelValorFinal.Size = new Size(84, 21);
            LabelValorFinal.TabIndex = 23;
            LabelValorFinal.Text = "Valor Final";
            // 
            // LabelTasaInteres
            // 
            LabelTasaInteres.AutoSize = true;
            LabelTasaInteres.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTasaInteres.ForeColor = Color.White;
            LabelTasaInteres.Location = new Point(296, 356);
            LabelTasaInteres.Name = "LabelTasaInteres";
            LabelTasaInteres.Size = new Size(95, 21);
            LabelTasaInteres.TabIndex = 22;
            LabelTasaInteres.Text = "Tasa Interes";
            // 
            // LabelCapital
            // 
            LabelCapital.AutoSize = true;
            LabelCapital.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelCapital.ForeColor = Color.White;
            LabelCapital.Location = new Point(297, 275);
            LabelCapital.Name = "LabelCapital";
            LabelCapital.Size = new Size(60, 21);
            LabelCapital.TabIndex = 21;
            LabelCapital.Text = "Capital";
            // 
            // LabelInteres
            // 
            LabelInteres.AutoSize = true;
            LabelInteres.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelInteres.ForeColor = Color.White;
            LabelInteres.Location = new Point(296, 240);
            LabelInteres.Name = "LabelInteres";
            LabelInteres.Size = new Size(61, 21);
            LabelInteres.TabIndex = 20;
            LabelInteres.Text = "Interes";
            // 
            // InteresCompuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(916, 612);
            Controls.Add(LabelPorciento);
            Controls.Add(BtnCalcular);
            Controls.Add(ComboBoxTiempo);
            Controls.Add(ComboBoxTI);
            Controls.Add(TextBoxTiempo);
            Controls.Add(TextBoxVF);
            Controls.Add(TextBoxTI);
            Controls.Add(TextBoxCap);
            Controls.Add(TextBoxInt);
            Controls.Add(LabelTiempo);
            Controls.Add(LabelValorFinal);
            Controls.Add(LabelTasaInteres);
            Controls.Add(LabelCapital);
            Controls.Add(LabelInteres);
            Controls.Add(ComboBoxQCalcular);
            Controls.Add(LabelQCalcular);
            Controls.Add(LabelInteresCompuesto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InteresCompuesto";
            Text = "InteresCompuesto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelInteresCompuesto;
        private ComboBox ComboBoxQCalcular;
        private Label LabelQCalcular;
        private Label LabelPorciento;
        private Button BtnCalcular;
        private ComboBox ComboBoxTiempo;
        private ComboBox ComboBoxTI;
        private TextBox TextBoxTiempo;
        private TextBox TextBoxVF;
        private TextBox TextBoxTI;
        private TextBox TextBoxCap;
        private TextBox TextBoxInt;
        private Label LabelTiempo;
        private Label LabelValorFinal;
        private Label LabelTasaInteres;
        private Label LabelCapital;
        private Label LabelInteres;
    }
}