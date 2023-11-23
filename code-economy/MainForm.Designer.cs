namespace code_economy
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Titlebar = new Panel();
            BtnRestore = new PictureBox();
            BtnMinimize = new PictureBox();
            BtnMaximize = new PictureBox();
            BtnClose = new PictureBox();
            SideBar = new Panel();
            BtnGra = new Button();
            BtnAnualidad = new Button();
            BtnInteresCompuesto = new Button();
            BtnInteresSimple = new Button();
            PictureBoxLogo = new PictureBox();
            ContainerPanel = new Panel();
            Titlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnRestore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnClose).BeginInit();
            SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // Titlebar
            // 
            Titlebar.BackColor = Color.FromArgb(0, 80, 200);
            Titlebar.Controls.Add(BtnRestore);
            Titlebar.Controls.Add(BtnMinimize);
            Titlebar.Controls.Add(BtnMaximize);
            Titlebar.Controls.Add(BtnClose);
            Titlebar.Dock = DockStyle.Top;
            Titlebar.Location = new Point(0, 0);
            Titlebar.Name = "Titlebar";
            Titlebar.Size = new Size(1200, 38);
            Titlebar.TabIndex = 0;
            Titlebar.Paint += Titlebar_Paint;
            Titlebar.MouseDown += Titlebar_MouseDown;
            // 
            // BtnRestore
            // 
            BtnRestore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnRestore.Cursor = Cursors.Hand;
            BtnRestore.Image = Properties.Resources.icon_restaurar;
            BtnRestore.Location = new Point(1132, 7);
            BtnRestore.Name = "BtnRestore";
            BtnRestore.Size = new Size(25, 25);
            BtnRestore.SizeMode = PictureBoxSizeMode.Zoom;
            BtnRestore.TabIndex = 6;
            BtnRestore.TabStop = false;
            BtnRestore.Visible = false;
            BtnRestore.Click += BtnRestore_Click;
            // 
            // BtnMinimize
            // 
            BtnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMinimize.Cursor = Cursors.Hand;
            BtnMinimize.Image = Properties.Resources.icon_minimize_;
            BtnMinimize.Location = new Point(1101, 7);
            BtnMinimize.Name = "BtnMinimize";
            BtnMinimize.Size = new Size(25, 25);
            BtnMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            BtnMinimize.TabIndex = 5;
            BtnMinimize.TabStop = false;
            BtnMinimize.Click += BtnMinimize_Click;
            // 
            // BtnMaximize
            // 
            BtnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMaximize.Cursor = Cursors.Hand;
            BtnMaximize.Image = Properties.Resources.icon_maximixar;
            BtnMaximize.Location = new Point(1132, 7);
            BtnMaximize.Name = "BtnMaximize";
            BtnMaximize.Size = new Size(25, 25);
            BtnMaximize.SizeMode = PictureBoxSizeMode.Zoom;
            BtnMaximize.TabIndex = 4;
            BtnMaximize.TabStop = false;
            BtnMaximize.Click += BtnMaximize_Click;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Cursor = Cursors.Hand;
            BtnClose.Image = Properties.Resources.close_x_icon;
            BtnClose.Location = new Point(1163, 7);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(25, 25);
            BtnClose.SizeMode = PictureBoxSizeMode.Zoom;
            BtnClose.TabIndex = 3;
            BtnClose.TabStop = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // SideBar
            // 
            SideBar.BackColor = Color.FromArgb(26, 32, 40);
            SideBar.Controls.Add(BtnGra);
            SideBar.Controls.Add(BtnAnualidad);
            SideBar.Controls.Add(BtnInteresCompuesto);
            SideBar.Controls.Add(BtnInteresSimple);
            SideBar.Controls.Add(PictureBoxLogo);
            SideBar.Dock = DockStyle.Left;
            SideBar.Location = new Point(0, 38);
            SideBar.Name = "SideBar";
            SideBar.Size = new Size(284, 612);
            SideBar.TabIndex = 1;
            // 
            // BtnGra
            // 
            BtnGra.BackColor = Color.FromArgb(26, 32, 40);
            BtnGra.FlatAppearance.BorderSize = 0;
            BtnGra.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            BtnGra.FlatStyle = FlatStyle.Flat;
            BtnGra.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGra.ForeColor = Color.White;
            BtnGra.Image = Properties.Resources.icon_others_;
            BtnGra.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGra.Location = new Point(0, 524);
            BtnGra.Name = "BtnGra";
            BtnGra.Padding = new Padding(1, 0, 0, 0);
            BtnGra.Size = new Size(284, 90);
            BtnGra.TabIndex = 3;
            BtnGra.Text = "Gradiente";
            BtnGra.UseVisualStyleBackColor = false;
            BtnGra.Click += BtnOtros_Click;
            // 
            // BtnAnualidad
            // 
            BtnAnualidad.BackColor = Color.FromArgb(26, 32, 40);
            BtnAnualidad.FlatAppearance.BorderSize = 0;
            BtnAnualidad.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            BtnAnualidad.FlatStyle = FlatStyle.Flat;
            BtnAnualidad.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAnualidad.ForeColor = Color.White;
            BtnAnualidad.Image = Properties.Resources.icon_anualidades_;
            BtnAnualidad.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAnualidad.Location = new Point(0, 428);
            BtnAnualidad.Name = "BtnAnualidad";
            BtnAnualidad.Padding = new Padding(1, 0, 0, 0);
            BtnAnualidad.Size = new Size(284, 90);
            BtnAnualidad.TabIndex = 2;
            BtnAnualidad.Text = "Tasa Interna Retorno";
            BtnAnualidad.UseVisualStyleBackColor = false;
            BtnAnualidad.Click += BtnAnualidad_Click;
            // 
            // BtnInteresCompuesto
            // 
            BtnInteresCompuesto.BackColor = Color.FromArgb(26, 32, 40);
            BtnInteresCompuesto.FlatAppearance.BorderSize = 0;
            BtnInteresCompuesto.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            BtnInteresCompuesto.FlatStyle = FlatStyle.Flat;
            BtnInteresCompuesto.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnInteresCompuesto.ForeColor = Color.White;
            BtnInteresCompuesto.Image = Properties.Resources.Icon_interes_Compuesto_;
            BtnInteresCompuesto.ImageAlign = ContentAlignment.MiddleLeft;
            BtnInteresCompuesto.Location = new Point(0, 332);
            BtnInteresCompuesto.Name = "BtnInteresCompuesto";
            BtnInteresCompuesto.Padding = new Padding(1, 0, 0, 0);
            BtnInteresCompuesto.Size = new Size(284, 90);
            BtnInteresCompuesto.TabIndex = 1;
            BtnInteresCompuesto.Text = "Interes Compuesto";
            BtnInteresCompuesto.UseVisualStyleBackColor = false;
            BtnInteresCompuesto.Click += BtnInteresCompuesto_Click;
            // 
            // BtnInteresSimple
            // 
            BtnInteresSimple.BackColor = Color.FromArgb(26, 32, 40);
            BtnInteresSimple.FlatAppearance.BorderSize = 0;
            BtnInteresSimple.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            BtnInteresSimple.FlatStyle = FlatStyle.Flat;
            BtnInteresSimple.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnInteresSimple.ForeColor = Color.White;
            BtnInteresSimple.Image = Properties.Resources.Icon_interes_Simple_;
            BtnInteresSimple.ImageAlign = ContentAlignment.MiddleLeft;
            BtnInteresSimple.Location = new Point(0, 236);
            BtnInteresSimple.Name = "BtnInteresSimple";
            BtnInteresSimple.Padding = new Padding(1, 0, 0, 0);
            BtnInteresSimple.Size = new Size(284, 90);
            BtnInteresSimple.TabIndex = 0;
            BtnInteresSimple.Text = "Interes Simple";
            BtnInteresSimple.UseVisualStyleBackColor = false;
            BtnInteresSimple.Click += BtnInteresSimple_Click;
            // 
            // PictureBoxLogo
            // 
            PictureBoxLogo.Cursor = Cursors.Hand;
            PictureBoxLogo.Image = Properties.Resources.Logo;
            PictureBoxLogo.Location = new Point(0, -38);
            PictureBoxLogo.Name = "PictureBoxLogo";
            PictureBoxLogo.Size = new Size(284, 277);
            PictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxLogo.TabIndex = 0;
            PictureBoxLogo.TabStop = false;
            PictureBoxLogo.Click += PictureBoxLogo_Click;
            // 
            // ContainerPanel
            // 
            ContainerPanel.BackColor = Color.FromArgb(49, 66, 82);
            ContainerPanel.Dock = DockStyle.Fill;
            ContainerPanel.Location = new Point(284, 38);
            ContainerPanel.Name = "ContainerPanel";
            ContainerPanel.Size = new Size(916, 612);
            ContainerPanel.TabIndex = 2;
            ContainerPanel.Paint += ContainerPanel_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 650);
            Controls.Add(ContainerPanel);
            Controls.Add(SideBar);
            Controls.Add(Titlebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "Code-Economy";
            Titlebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnRestore).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMaximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnClose).EndInit();
            SideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Titlebar;
        private Panel SideBar;
        private Panel ContainerPanel;
        private PictureBox BtnClose;
        private PictureBox BtnMaximize;
        private PictureBox BtnMinimize;
        private PictureBox BtnRestore;
        private PictureBox PictureBoxLogo;
        private Button BtnInteresSimple;
        private Button BtnInteresCompuesto;
        private Button BtnAnualidad;
        private Button BtnGra;
    }
}