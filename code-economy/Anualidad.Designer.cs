namespace code_economy
{
    partial class Anualidad
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
            SuspendLayout();
            // 
            // LabelAnualidad
            // 
            LabelAnualidad.Anchor = AnchorStyles.Top;
            LabelAnualidad.AutoSize = true;
            LabelAnualidad.Font = new Font("Segoe UI", 42F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LabelAnualidad.ForeColor = Color.White;
            LabelAnualidad.Location = new Point(305, 9);
            LabelAnualidad.Name = "LabelAnualidad";
            LabelAnualidad.Size = new Size(305, 74);
            LabelAnualidad.TabIndex = 1;
            LabelAnualidad.Text = "Anualidad";
            LabelAnualidad.TextAlign = ContentAlignment.TopCenter;
            // 
            // Anualidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(916, 612);
            Controls.Add(LabelAnualidad);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Anualidad";
            Text = "Anualidad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelAnualidad;
    }
}