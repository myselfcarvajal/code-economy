namespace code_economy
{
    partial class TasaInternaRetorno
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
            LabelAnualidad = new Label();
            labelInvInicial = new Label();
            textBoxIvInicial = new TextBox();
            labelDinero = new Label();
            labelQCantidadPeriodos = new Label();
            ComboBoxQCantidadPeriodos = new ComboBox();
            textBoxAnyo1 = new TextBox();
            textBoxAnyo2 = new TextBox();
            label1 = new Label();
            textBoxTIR = new TextBox();
            labelPorcentaje = new Label();
            BtnCalcularTIR = new Button();
            SuspendLayout();
            // 
            // LabelAnualidad
            // 
            LabelAnualidad.Anchor = AnchorStyles.Top;
            LabelAnualidad.AutoSize = true;
            LabelAnualidad.Font = new Font("Segoe UI", 42F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LabelAnualidad.ForeColor = Color.White;
            LabelAnualidad.Location = new Point(180, 9);
            LabelAnualidad.Name = "LabelAnualidad";
            LabelAnualidad.Size = new Size(580, 74);
            LabelAnualidad.TabIndex = 1;
            LabelAnualidad.Text = "Tasa Interna Retorno";
            LabelAnualidad.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelInvInicial
            // 
            labelInvInicial.AutoSize = true;
            labelInvInicial.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelInvInicial.ForeColor = Color.White;
            labelInvInicial.Location = new Point(322, 133);
            labelInvInicial.Name = "labelInvInicial";
            labelInvInicial.Size = new Size(152, 25);
            labelInvInicial.TabIndex = 2;
            labelInvInicial.Text = "Inversión Inicial:";
            // 
            // textBoxIvInicial
            // 
            textBoxIvInicial.Location = new Point(480, 133);
            textBoxIvInicial.Name = "textBoxIvInicial";
            textBoxIvInicial.Size = new Size(100, 23);
            textBoxIvInicial.TabIndex = 3;
            textBoxIvInicial.KeyPress += textBoxIvInicial_KeyPress;
            // 
            // labelDinero
            // 
            labelDinero.AutoSize = true;
            labelDinero.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelDinero.ForeColor = Color.White;
            labelDinero.Location = new Point(586, 133);
            labelDinero.Name = "labelDinero";
            labelDinero.Size = new Size(23, 25);
            labelDinero.TabIndex = 4;
            labelDinero.Text = "$";
            // 
            // labelQCantidadPeriodos
            // 
            labelQCantidadPeriodos.AutoSize = true;
            labelQCantidadPeriodos.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelQCantidadPeriodos.ForeColor = Color.White;
            labelQCantidadPeriodos.Location = new Point(207, 176);
            labelQCantidadPeriodos.Name = "labelQCantidadPeriodos";
            labelQCantidadPeriodos.Size = new Size(270, 25);
            labelQCantidadPeriodos.TabIndex = 5;
            labelQCantidadPeriodos.Text = "¿Cantidad de periodos? (Años)";
            // 
            // ComboBoxQCantidadPeriodos
            // 
            ComboBoxQCantidadPeriodos.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxQCantidadPeriodos.FormattingEnabled = true;
            ComboBoxQCantidadPeriodos.Items.AddRange(new object[] { "1", "2" });
            ComboBoxQCantidadPeriodos.Location = new Point(480, 176);
            ComboBoxQCantidadPeriodos.Name = "ComboBoxQCantidadPeriodos";
            ComboBoxQCantidadPeriodos.Size = new Size(100, 23);
            ComboBoxQCantidadPeriodos.TabIndex = 9;
            ComboBoxQCantidadPeriodos.SelectedIndexChanged += ComboBoxQCantidadPeriodos_SelectedIndexChanged;
            // 
            // textBoxAnyo1
            // 
            textBoxAnyo1.Location = new Point(480, 228);
            textBoxAnyo1.Name = "textBoxAnyo1";
            textBoxAnyo1.Size = new Size(100, 23);
            textBoxAnyo1.TabIndex = 10;
            textBoxAnyo1.KeyPress += textBoxAnyo1_KeyPress;
            // 
            // textBoxAnyo2
            // 
            textBoxAnyo2.Location = new Point(480, 260);
            textBoxAnyo2.Name = "textBoxAnyo2";
            textBoxAnyo2.Size = new Size(100, 23);
            textBoxAnyo2.TabIndex = 11;
            textBoxAnyo2.KeyPress += textBoxAnyo2_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(194, 325);
            label1.Name = "label1";
            label1.Size = new Size(260, 25);
            label1.TabIndex = 12;
            label1.Text = "Tasa Interna de retorno (TIR):";
            // 
            // textBoxTIR
            // 
            textBoxTIR.Location = new Point(480, 327);
            textBoxTIR.Name = "textBoxTIR";
            textBoxTIR.Size = new Size(100, 23);
            textBoxTIR.TabIndex = 13;
            // 
            // labelPorcentaje
            // 
            labelPorcentaje.AutoSize = true;
            labelPorcentaje.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelPorcentaje.ForeColor = Color.White;
            labelPorcentaje.Location = new Point(586, 327);
            labelPorcentaje.Name = "labelPorcentaje";
            labelPorcentaje.Size = new Size(28, 25);
            labelPorcentaje.TabIndex = 14;
            labelPorcentaje.Text = "%";
            // 
            // BtnCalcularTIR
            // 
            BtnCalcularTIR.BackColor = Color.FromArgb(255, 128, 0);
            BtnCalcularTIR.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCalcularTIR.ForeColor = Color.White;
            BtnCalcularTIR.Location = new Point(364, 457);
            BtnCalcularTIR.Margin = new Padding(2);
            BtnCalcularTIR.Name = "BtnCalcularTIR";
            BtnCalcularTIR.Size = new Size(160, 50);
            BtnCalcularTIR.TabIndex = 33;
            BtnCalcularTIR.Text = "Calcular";
            BtnCalcularTIR.UseVisualStyleBackColor = false;
            BtnCalcularTIR.Click += BtnCalcularTIR_Click;
            // 
            // TasaInternaRetorno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(916, 612);
            Controls.Add(BtnCalcularTIR);
            Controls.Add(labelPorcentaje);
            Controls.Add(textBoxTIR);
            Controls.Add(label1);
            Controls.Add(textBoxAnyo2);
            Controls.Add(textBoxAnyo1);
            Controls.Add(ComboBoxQCantidadPeriodos);
            Controls.Add(labelQCantidadPeriodos);
            Controls.Add(labelDinero);
            Controls.Add(textBoxIvInicial);
            Controls.Add(labelInvInicial);
            Controls.Add(LabelAnualidad);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TasaInternaRetorno";
            Text = "Tasa Interna Retorno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelAnualidad;
        private Label labelInvInicial;
        private TextBox textBoxIvInicial;
        private Label labelDinero;
        private Label labelQCantidadPeriodos;
        private ComboBox ComboBoxQCantidadPeriodos;
        private TextBox textBoxAnyo1;
        private TextBox textBoxAnyo2;
        private Label label1;
        private TextBox textBoxTIR;
        private Label labelPorcentaje;
        private Button BtnCalcularTIR;
    }
}