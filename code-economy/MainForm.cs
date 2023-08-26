using System.Runtime.InteropServices;

namespace code_economy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PictureBoxLogo_Click(null, EventArgs.Empty);

        }

        private void OpenFormHija(object formhija)
        {
            if (this.ContainerPanel.Controls.Count > 0)
                this.ContainerPanel.Controls.RemoveAt(0);
            Form fh = formhija as Form;

            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.ContainerPanel.Controls.Add(fh);
            this.ContainerPanel.Tag = fh;
            fh.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximize.Visible = false;
            BtnRestore.Visible = true;
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnRestore.Visible = false;
            BtnMaximize.Visible = true;
        }

        private void Titlebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBoxLogo_Click(object sender, EventArgs e)
        {
            OpenFormHija(new Start());
        }

        private void BtnInteresSimple_Click(object sender, EventArgs e)
        {
            OpenFormHija(new InteresSimple());
        }

        private void BtnInteresCompuesto_Click(object sender, EventArgs e)
        {

        }

        private void BtnAnualidad_Click(object sender, EventArgs e)
        {

        }

        private void BtnOtros_Click(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int Param);

        private void Titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

//PictureBoxLogo_Click(null, e);