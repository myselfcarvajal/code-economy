namespace code_economy
{
    partial class Start
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
            PictureWelcome = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureWelcome).BeginInit();
            SuspendLayout();
            // 
            // PictureWelcome
            // 
            PictureWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PictureWelcome.Image = Properties.Resources.welcome_code_economy;
            PictureWelcome.Location = new Point(188, 12);
            PictureWelcome.Name = "PictureWelcome";
            PictureWelcome.Size = new Size(560, 588);
            PictureWelcome.SizeMode = PictureBoxSizeMode.Zoom;
            PictureWelcome.TabIndex = 0;
            PictureWelcome.TabStop = false;
            PictureWelcome.Click += PictureWelcome_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(916, 612);
            Controls.Add(PictureWelcome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Start";
            Text = "Start";
            ((System.ComponentModel.ISupportInitialize)PictureWelcome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PictureWelcome;
    }
}