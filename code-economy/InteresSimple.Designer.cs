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
            LabelInteres = new Label();
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
            TextBoxDias = new TextBox();
            TextBoxMeses = new TextBox();
            LabelPorciento = new Label();
            BtnTrashIntSimple = new Button();
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
            // LabelInteres
            // 
            LabelInteres.AutoSize = true;
            LabelInteres.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelInteres.ForeColor = Color.White;
            LabelInteres.Location = new Point(285, 231);
            LabelInteres.Name = "LabelInteres";
            LabelInteres.Size = new Size(61, 21);
            LabelInteres.TabIndex = 3;
            LabelInteres.Text = "Interes";
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
            ComboBoxTI.Items.AddRange(new object[] { "Dia", "Mensual", "Bimensual", "Trimestral", "Cuatrimestral", "Semestral", "Anual" });
            ComboBoxTI.Location = new Point(521, 345);
            ComboBoxTI.Name = "ComboBoxTI";
            ComboBoxTI.Size = new Size(121, 23);
            ComboBoxTI.TabIndex = 13;
            // 
            // ComboBoxTiempo
            // 
            ComboBoxTiempo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxTiempo.FormattingEnabled = true;
            ComboBoxTiempo.Items.AddRange(new object[] { "Dia", "Mensual", "Bimensual", "Trimestral", "Cuatrimestral", "Semestral", "Anual" });
            ComboBoxTiempo.Location = new Point(495, 383);
            ComboBoxTiempo.Name = "ComboBoxTiempo";
            ComboBoxTiempo.Size = new Size(121, 23);
            ComboBoxTiempo.TabIndex = 14;
            ComboBoxTiempo.SelectedIndexChanged += ComboBoxTiempo_SelectedIndexChanged;
            // 
            // BtnCalcular
            // 
            BtnCalcular.BackColor = Color.FromArgb(255, 128, 0);
            BtnCalcular.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCalcular.ForeColor = Color.White;
            BtnCalcular.Location = new Point(399, 508);
            BtnCalcular.Margin = new Padding(2);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(160, 50);
            BtnCalcular.TabIndex = 15;
            BtnCalcular.Text = "Calcular";
            BtnCalcular.UseVisualStyleBackColor = false;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // TextBoxDias
            // 
            TextBoxDias.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxDias.ForeColor = SystemColors.InactiveCaption;
            TextBoxDias.Location = new Point(389, 441);
            TextBoxDias.Name = "TextBoxDias";
            TextBoxDias.Size = new Size(100, 23);
            TextBoxDias.TabIndex = 17;
            TextBoxDias.Text = "Dias";
            TextBoxDias.KeyPress += TextBoxDias_KeyPress;
            TextBoxDias.MouseEnter += TextBoxDias_MouseEnter;
            TextBoxDias.MouseLeave += TextBoxDias_MouseLeave;
            // 
            // TextBoxMeses
            // 
            TextBoxMeses.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxMeses.ForeColor = SystemColors.InactiveCaption;
            TextBoxMeses.Location = new Point(389, 412);
            TextBoxMeses.Name = "TextBoxMeses";
            TextBoxMeses.Size = new Size(100, 23);
            TextBoxMeses.TabIndex = 18;
            TextBoxMeses.Text = "Meses";
            TextBoxMeses.KeyPress += TextBoxMeses_KeyPress;
            TextBoxMeses.MouseEnter += TextBoxMeses_MouseEnter;
            TextBoxMeses.MouseLeave += TextBoxMeses_MouseLeave;
            // 
            // LabelPorciento
            // 
            LabelPorciento.AutoSize = true;
            LabelPorciento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPorciento.ForeColor = Color.White;
            LabelPorciento.Location = new Point(491, 347);
            LabelPorciento.Name = "LabelPorciento";
            LabelPorciento.Size = new Size(24, 21);
            LabelPorciento.TabIndex = 19;
            LabelPorciento.Text = "%";
            // 
            // BtnTrashIntSimple
            // 
            BtnTrashIntSimple.BackColor = Color.FromArgb(49, 66, 82);
            BtnTrashIntSimple.FlatAppearance.BorderSize = 0;
            BtnTrashIntSimple.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            BtnTrashIntSimple.FlatStyle = FlatStyle.Flat;
            BtnTrashIntSimple.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnTrashIntSimple.ForeColor = Color.White;
            BtnTrashIntSimple.Image = Properties.Resources.icon_trash;
            BtnTrashIntSimple.Location = new Point(74, 500);
            BtnTrashIntSimple.Name = "BtnTrashIntSimple";
            BtnTrashIntSimple.Padding = new Padding(1, 0, 0, 0);
            BtnTrashIntSimple.Size = new Size(70, 58);
            BtnTrashIntSimple.TabIndex = 20;
            BtnTrashIntSimple.UseVisualStyleBackColor = false;
            BtnTrashIntSimple.Click += BtnTrashIntSimple_Click;
            // 
            // InteresSimple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(916, 612);
            Controls.Add(BtnTrashIntSimple);
            Controls.Add(LabelPorciento);
            Controls.Add(TextBoxMeses);
            Controls.Add(TextBoxDias);
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
        private Label LabelInteres;
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
        private TextBox TextBoxDias;
        private TextBox TextBoxMeses;
        private Label LabelPorciento;
        private Button BtnTrashIntSimple;
    }
}