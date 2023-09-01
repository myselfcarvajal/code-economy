namespace code_economy
{
    partial class InteresSimple
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
            LabelInteresSimple = new Label();
            LabelQCalcular = new Label();
            ComboBoxQCalcular = new ComboBox();
            labelInteres = new Label();
            LabelCapital = new Label();
            LabelTasaInteres = new Label();
            LabelValorFinal = new Label();
            LabelTiempo = new Label();
            TextBoxInt = new TextBox();
            TextBoxCap = new TextBox();
            TextBoxTI = new TextBox();
            TextBoxVF = new TextBox();
            TextBoxTiempo = new TextBox();
            ComboBoxTI = new ComboBox();
            ComboBoxTiempo = new ComboBox();
            BtnCalcular = new Button();
            SuspendLayout();
            // 
            // LabelInteresSimple
            // 
            LabelInteresSimple.Anchor = AnchorStyles.Top;
            LabelInteresSimple.AutoSize = true;
            LabelInteresSimple.Font = new Font("Segoe UI", 42F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LabelInteresSimple.ForeColor = Color.White;
            LabelInteresSimple.Location = new Point(301, 9);
            LabelInteresSimple.Name = "LabelInteresSimple";
            LabelInteresSimple.Size = new Size(403, 74);
            LabelInteresSimple.TabIndex = 0;
            LabelInteresSimple.Text = "Interes Simple";
            LabelInteresSimple.TextAlign = ContentAlignment.TopCenter;
            LabelInteresSimple.Click += LabelInteresSimple_Click;
            // 
            // LabelQCalcular
            // 
            LabelQCalcular.AutoSize = true;
            LabelQCalcular.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelQCalcular.ForeColor = Color.White;
            LabelQCalcular.Location = new Point(264, 125);
            LabelQCalcular.Name = "LabelQCalcular";
            LabelQCalcular.Size = new Size(213, 30);
            LabelQCalcular.TabIndex = 1;
            LabelQCalcular.Text = "¿Que desea calcular?";
            LabelQCalcular.Click += LabelQCalcular_Click;
            // 
            // ComboBoxQCalcular
            // 
            ComboBoxQCalcular.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxQCalcular.FormattingEnabled = true;
            ComboBoxQCalcular.Items.AddRange(new object[] { "Interes", "Capital", "Valor Final", "Tasa de Interes", "Tiempo" });
            ComboBoxQCalcular.Location = new Point(483, 132);
            ComboBoxQCalcular.Name = "ComboBoxQCalcular";
            ComboBoxQCalcular.Size = new Size(121, 23);
            ComboBoxQCalcular.TabIndex = 2;
            ComboBoxQCalcular.SelectedIndexChanged += ComboBoxQCalcular_SelectedIndexChanged;
            // 
            // labelInteres
            // 
            labelInteres.AutoSize = true;
            labelInteres.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelInteres.ForeColor = Color.White;
            labelInteres.Location = new Point(285, 231);
            labelInteres.Name = "labelInteres";
            labelInteres.Size = new Size(61, 21);
            labelInteres.TabIndex = 3;
            labelInteres.Text = "Interes";
            // 
            // LabelCapital
            // 
            LabelCapital.AutoSize = true;
            LabelCapital.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelCapital.ForeColor = Color.White;
            LabelCapital.Location = new Point(286, 266);
            LabelCapital.Name = "LabelCapital";
            LabelCapital.Size = new Size(60, 21);
            LabelCapital.TabIndex = 4;
            LabelCapital.Text = "Capital";
            // 
            // LabelTasaInteres
            // 
            LabelTasaInteres.AutoSize = true;
            LabelTasaInteres.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTasaInteres.ForeColor = Color.White;
            LabelTasaInteres.Location = new Point(285, 347);
            LabelTasaInteres.Name = "LabelTasaInteres";
            LabelTasaInteres.Size = new Size(95, 21);
            LabelTasaInteres.TabIndex = 5;
            LabelTasaInteres.Text = "Tasa Interes";
            // 
            // LabelValorFinal
            // 
            LabelValorFinal.AutoSize = true;
            LabelValorFinal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelValorFinal.ForeColor = Color.White;
            LabelValorFinal.Location = new Point(286, 308);
            LabelValorFinal.Name = "LabelValorFinal";
            LabelValorFinal.Size = new Size(84, 21);
            LabelValorFinal.TabIndex = 6;
            LabelValorFinal.Text = "Valor Final";
            // 
            // LabelTiempo
            // 
            LabelTiempo.AutoSize = true;
            LabelTiempo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTiempo.ForeColor = Color.White;
            LabelTiempo.Location = new Point(286, 385);
            LabelTiempo.Name = "LabelTiempo";
            LabelTiempo.Size = new Size(66, 21);
            LabelTiempo.TabIndex = 7;
            LabelTiempo.Text = "Tiempo";
            // 
            // TextBoxInt
            // 
            TextBoxInt.Location = new Point(389, 229);
            TextBoxInt.Name = "TextBoxInt";
            TextBoxInt.Size = new Size(100, 23);
            TextBoxInt.TabIndex = 8;
            TextBoxInt.KeyPress += TextBoxInt_KeyPress;
            // 
            // TextBoxCap
            // 
            TextBoxCap.Location = new Point(389, 264);
            TextBoxCap.Name = "TextBoxCap";
            TextBoxCap.Size = new Size(100, 23);
            TextBoxCap.TabIndex = 9;
            TextBoxCap.KeyPress += TextBoxCap_KeyPress;
            // 
            // TextBoxTI
            // 
            TextBoxTI.Location = new Point(389, 345);
            TextBoxTI.Name = "TextBoxTI";
            TextBoxTI.Size = new Size(100, 23);
            TextBoxTI.TabIndex = 10;
            TextBoxTI.KeyPress += TextBoxTI_KeyPress;
            // 
            // TextBoxVF
            // 
            TextBoxVF.Location = new Point(389, 306);
            TextBoxVF.Name = "TextBoxVF";
            TextBoxVF.Size = new Size(100, 23);
            TextBoxVF.TabIndex = 11;
            TextBoxVF.KeyPress += TextBoxVF_KeyPress;
            // 
            // TextBoxTiempo
            // 
            TextBoxTiempo.Location = new Point(389, 383);
            TextBoxTiempo.Name = "TextBoxTiempo";
            TextBoxTiempo.Size = new Size(100, 23);
            TextBoxTiempo.TabIndex = 12;
            TextBoxTiempo.KeyPress += TextBoxTiempo_KeyPress;
            // 
            // ComboBoxTI
            // 
            ComboBoxTI.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxTI.FormattingEnabled = true;
            ComboBoxTI.Items.AddRange(new object[] { "Mensual", "Bimensual", "Trimestral", "Semestral", "Anual" });
            ComboBoxTI.Location = new Point(495, 345);
            ComboBoxTI.Name = "ComboBoxTI";
            ComboBoxTI.Size = new Size(121, 23);
            ComboBoxTI.TabIndex = 13;
            // 
            // ComboBoxTiempo
            // 
            ComboBoxTiempo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxTiempo.FormattingEnabled = true;
            ComboBoxTiempo.Items.AddRange(new object[] { "Mensual", "Bimensual", "Trimestral", "Semestral", "Anual" });
            ComboBoxTiempo.Location = new Point(495, 383);
            ComboBoxTiempo.Name = "ComboBoxTiempo";
            ComboBoxTiempo.Size = new Size(121, 23);
            ComboBoxTiempo.TabIndex = 14;
            // 
            // BtnCalcular
            // 
            BtnCalcular.BackColor = Color.FromArgb(255, 128, 0);
            BtnCalcular.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCalcular.ForeColor = Color.White;
            BtnCalcular.Location = new Point(399, 490);
            BtnCalcular.Margin = new Padding(2);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(160, 50);
            BtnCalcular.TabIndex = 15;
            BtnCalcular.Text = "Calcular";
            BtnCalcular.UseVisualStyleBackColor = false;
            // 
            // InteresSimple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(916, 612);
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
            Controls.Add(labelInteres);
            Controls.Add(ComboBoxQCalcular);
            Controls.Add(LabelQCalcular);
            Controls.Add(LabelInteresSimple);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InteresSimple";
            Text = "InteresSimple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelInteresSimple;
        private Label LabelQCalcular;
        private ComboBox ComboBoxQCalcular;
        private Label labelInteres;
        private Label LabelCapital;
        private Label LabelTasaInteres;
        private Label LabelValorFinal;
        private Label LabelTiempo;
        private TextBox TextBoxInt;
        private TextBox TextBoxCap;
        private TextBox TextBoxTI;
        private TextBox TextBoxVF;
        private TextBox TextBoxTiempo;
        private ComboBox ComboBoxTI;
        private ComboBox ComboBoxTiempo;
        private Button BtnCalcular;
    }
}