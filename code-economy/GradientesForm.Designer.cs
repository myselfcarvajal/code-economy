namespace code_economy
{
    partial class GradientesForm
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
            BtnTrashIntCompuesto = new Button();
            LabelPorciento = new Label();
            BtnCalcular = new Button();
            ComboBoxTiempo = new ComboBox();
            ComboBoxTI = new ComboBox();
            TextBoxTiempo = new TextBox();
            TextBoxCuota = new TextBox();
            TextBoxI = new TextBox();
            TextBoxG = new TextBox();
            TexBoxCreciente = new TextBox();
            LabelTiempo = new Label();
            LabelValorFinal = new Label();
            LabelTasaInteres = new Label();
            LabelCapital = new Label();
            LabelInteres = new Label();
            ComboBoxQTema = new ComboBox();
            LabelQCalcular = new Label();
            Label_gradiente = new Label();
            comboBoxCal = new ComboBox();
            label1 = new Label();
            textBoxValor2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // BtnTrashIntCompuesto
            // 
            BtnTrashIntCompuesto.BackColor = Color.FromArgb(49, 66, 82);
            BtnTrashIntCompuesto.FlatAppearance.BorderSize = 0;
            BtnTrashIntCompuesto.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            BtnTrashIntCompuesto.FlatStyle = FlatStyle.Flat;
            BtnTrashIntCompuesto.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnTrashIntCompuesto.ForeColor = Color.White;
            BtnTrashIntCompuesto.Image = Properties.Resources.icon_trash;
            BtnTrashIntCompuesto.Location = new Point(132, 527);
            BtnTrashIntCompuesto.Name = "BtnTrashIntCompuesto";
            BtnTrashIntCompuesto.Padding = new Padding(1, 0, 0, 0);
            BtnTrashIntCompuesto.Size = new Size(70, 58);
            BtnTrashIntCompuesto.TabIndex = 52;
            BtnTrashIntCompuesto.UseVisualStyleBackColor = false;
            BtnTrashIntCompuesto.Click += BtnTrashIntCompuesto_Click;
            // 
            // LabelPorciento
            // 
            LabelPorciento.AutoSize = true;
            LabelPorciento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPorciento.ForeColor = Color.White;
            LabelPorciento.Location = new Point(523, 454);
            LabelPorciento.Name = "LabelPorciento";
            LabelPorciento.Size = new Size(24, 21);
            LabelPorciento.TabIndex = 51;
            LabelPorciento.Text = "%";
            // 
            // BtnCalcular
            // 
            BtnCalcular.BackColor = Color.FromArgb(255, 128, 0);
            BtnCalcular.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCalcular.ForeColor = Color.White;
            BtnCalcular.Location = new Point(464, 535);
            BtnCalcular.Margin = new Padding(2);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(160, 50);
            BtnCalcular.TabIndex = 50;
            BtnCalcular.Text = "Calcular";
            BtnCalcular.UseVisualStyleBackColor = false;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // ComboBoxTiempo
            // 
            ComboBoxTiempo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxTiempo.FormattingEnabled = true;
            ComboBoxTiempo.Items.AddRange(new object[] { "Dia", "Mensual", "Bimensual", "Trimestral", "Cuatrimestral", "Semestral", "Anual" });
            ComboBoxTiempo.Location = new Point(527, 335);
            ComboBoxTiempo.Name = "ComboBoxTiempo";
            ComboBoxTiempo.Size = new Size(121, 23);
            ComboBoxTiempo.TabIndex = 49;
            // 
            // ComboBoxTI
            // 
            ComboBoxTI.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxTI.FormattingEnabled = true;
            ComboBoxTI.Items.AddRange(new object[] { "Dia", "Mensual", "Bimensual", "Trimestral", "Cuatrimestral", "Semestral", "Anual" });
            ComboBoxTI.Location = new Point(553, 452);
            ComboBoxTI.Name = "ComboBoxTI";
            ComboBoxTI.Size = new Size(121, 23);
            ComboBoxTI.TabIndex = 48;
            // 
            // TextBoxTiempo
            // 
            TextBoxTiempo.Location = new Point(421, 335);
            TextBoxTiempo.Name = "TextBoxTiempo";
            TextBoxTiempo.Size = new Size(100, 23);
            TextBoxTiempo.TabIndex = 47;
            // 
            // TextBoxCuota
            // 
            TextBoxCuota.Location = new Point(421, 375);
            TextBoxCuota.Name = "TextBoxCuota";
            TextBoxCuota.Size = new Size(100, 23);
            TextBoxCuota.TabIndex = 46;
            // 
            // TextBoxI
            // 
            TextBoxI.Location = new Point(421, 452);
            TextBoxI.Name = "TextBoxI";
            TextBoxI.Size = new Size(100, 23);
            TextBoxI.TabIndex = 45;
            // 
            // TextBoxG
            // 
            TextBoxG.Location = new Point(421, 412);
            TextBoxG.Name = "TextBoxG";
            TextBoxG.Size = new Size(100, 23);
            TextBoxG.TabIndex = 44;
            // 
            // TexBoxCreciente
            // 
            TexBoxCreciente.Location = new Point(421, 298);
            TexBoxCreciente.Name = "TexBoxCreciente";
            TexBoxCreciente.Size = new Size(100, 23);
            TexBoxCreciente.TabIndex = 43;
            // 
            // LabelTiempo
            // 
            LabelTiempo.AutoSize = true;
            LabelTiempo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTiempo.ForeColor = Color.White;
            LabelTiempo.Location = new Point(318, 337);
            LabelTiempo.Name = "LabelTiempo";
            LabelTiempo.Size = new Size(66, 21);
            LabelTiempo.TabIndex = 42;
            LabelTiempo.Text = "Tiempo";
            // 
            // LabelValorFinal
            // 
            LabelValorFinal.AutoSize = true;
            LabelValorFinal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelValorFinal.ForeColor = Color.White;
            LabelValorFinal.Location = new Point(300, 377);
            LabelValorFinal.Name = "LabelValorFinal";
            LabelValorFinal.Size = new Size(99, 21);
            LabelValorFinal.TabIndex = 41;
            LabelValorFinal.Text = "Cuota Inicial";
            // 
            // LabelTasaInteres
            // 
            LabelTasaInteres.AutoSize = true;
            LabelTasaInteres.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTasaInteres.ForeColor = Color.White;
            LabelTasaInteres.Location = new Point(317, 454);
            LabelTasaInteres.Name = "LabelTasaInteres";
            LabelTasaInteres.Size = new Size(65, 21);
            LabelTasaInteres.TabIndex = 40;
            LabelTasaInteres.Text = " Interes";
            // 
            // LabelCapital
            // 
            LabelCapital.AutoSize = true;
            LabelCapital.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelCapital.ForeColor = Color.White;
            LabelCapital.Location = new Point(318, 414);
            LabelCapital.Name = "LabelCapital";
            LabelCapital.Size = new Size(82, 21);
            LabelCapital.TabIndex = 39;
            LabelCapital.Text = "Gradiente";
            // 
            // LabelInteres
            // 
            LabelInteres.AutoSize = true;
            LabelInteres.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelInteres.ForeColor = Color.White;
            LabelInteres.Location = new Point(296, 300);
            LabelInteres.Name = "LabelInteres";
            LabelInteres.Size = new Size(116, 21);
            LabelInteres.TabIndex = 38;
            LabelInteres.Text = "Valor presente";
            // 
            // ComboBoxQTema
            // 
            ComboBoxQTema.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxQTema.FormattingEnabled = true;
            ComboBoxQTema.Items.AddRange(new object[] { "Gradiente Aritmetico", "Gradiente Geometrico" });
            ComboBoxQTema.Location = new Point(503, 154);
            ComboBoxQTema.Name = "ComboBoxQTema";
            ComboBoxQTema.Size = new Size(121, 23);
            ComboBoxQTema.TabIndex = 37;
            ComboBoxQTema.SelectedIndexChanged += ComboBoxQCalcularGra_SelectedIndexChanged;
            // 
            // LabelQCalcular
            // 
            LabelQCalcular.AutoSize = true;
            LabelQCalcular.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelQCalcular.ForeColor = Color.White;
            LabelQCalcular.Location = new Point(341, 147);
            LabelQCalcular.Name = "LabelQCalcular";
            LabelQCalcular.Size = new Size(147, 30);
            LabelQCalcular.TabIndex = 36;
            LabelQCalcular.Text = "Elige un tema";
            LabelQCalcular.Click += LabelQCalcular_Click;
            // 
            // Label_gradiente
            // 
            Label_gradiente.Anchor = AnchorStyles.Top;
            Label_gradiente.AutoSize = true;
            Label_gradiente.Font = new Font("Segoe UI", 42F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Label_gradiente.ForeColor = Color.White;
            Label_gradiente.Location = new Point(269, 27);
            Label_gradiente.Name = "Label_gradiente";
            Label_gradiente.Size = new Size(290, 74);
            Label_gradiente.TabIndex = 35;
            Label_gradiente.Text = "Gradiente";
            Label_gradiente.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBoxCal
            // 
            comboBoxCal.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCal.FormattingEnabled = true;
            comboBoxCal.Items.AddRange(new object[] { "Gradiente", "Valor Presente", "Valor Futuro", "Valor Infinito", "Capital", "Gradiente Anual" });
            comboBoxCal.Location = new Point(503, 205);
            comboBoxCal.Name = "comboBoxCal";
            comboBoxCal.Size = new Size(121, 23);
            comboBoxCal.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(296, 196);
            label1.Name = "label1";
            label1.Size = new Size(192, 30);
            label1.TabIndex = 53;
            label1.Text = "que desea calcular";
            // 
            // textBoxValor2
            // 
            textBoxValor2.Location = new Point(527, 298);
            textBoxValor2.Name = "textBoxValor2";
            textBoxValor2.Size = new Size(100, 23);
            textBoxValor2.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(421, 274);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 56;
            label2.Text = "Creciente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(527, 274);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 57;
            label3.Text = "Decreciente";
            // 
            // GradientesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(916, 612);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxValor2);
            Controls.Add(comboBoxCal);
            Controls.Add(label1);
            Controls.Add(BtnTrashIntCompuesto);
            Controls.Add(LabelPorciento);
            Controls.Add(BtnCalcular);
            Controls.Add(ComboBoxTiempo);
            Controls.Add(ComboBoxTI);
            Controls.Add(TextBoxTiempo);
            Controls.Add(TextBoxCuota);
            Controls.Add(TextBoxI);
            Controls.Add(TextBoxG);
            Controls.Add(TexBoxCreciente);
            Controls.Add(LabelTiempo);
            Controls.Add(LabelValorFinal);
            Controls.Add(LabelTasaInteres);
            Controls.Add(LabelCapital);
            Controls.Add(LabelInteres);
            Controls.Add(ComboBoxQTema);
            Controls.Add(LabelQCalcular);
            Controls.Add(Label_gradiente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GradientesForm";
            Text = "GradientesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnTrashIntCompuesto;
        private Label LabelPorciento;
        private Button BtnCalcular;
        private ComboBox ComboBoxTiempo;
        private ComboBox ComboBoxTI;
        private TextBox TextBoxTiempo;
        private TextBox TextBoxCuota;
        private TextBox TextBoxI;
        private TextBox TextBoxG;
        private TextBox TexBoxCreciente;
        private Label LabelTiempo;
        private Label LabelValorFinal;
        private Label LabelTasaInteres;
        private Label LabelCapital;
        private Label LabelInteres;
        private ComboBox ComboBoxQTema;
        private Label LabelQCalcular;
        private Label Label_gradiente;
        private ComboBox comboBoxCal;
        private Label label1;
        private TextBox textBoxValor2;
        private Label label2;
        private Label label3;
    }
}