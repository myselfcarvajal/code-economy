using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace code_economy
{
    public partial class InteresSimple : Form
    {
        public InteresSimple()
        {
            InitializeComponent();
            ComboBoxQCalcular.SelectedIndex = 0;
            ComboBoxTI.SelectedIndex = 1;
            ComboBoxTiempo.SelectedIndex = 1;
        }

        private void LabelInteresSimple_Click(object sender, EventArgs e)
        {

        }

        private void LabelQCalcular_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxQCalcular_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Interes
            TextBoxInt.Enabled = true;
            TextBoxInt.Text = "";

            //Capital
            TextBoxCap.Enabled = true;
            TextBoxCap.Text = "";

            //Valor Final
            TextBoxVF.Enabled = true;
            TextBoxVF.Text = "";

            //Tasa De Interes
            TextBoxTI.Enabled = true;
            TextBoxTI.Text = "";

            //Tiempo
            TextBoxTiempo.Enabled = true;
            TextBoxTiempo.Text = "";


            //Deshabilitar entrada al campo a calcular
            switch (ComboBoxQCalcular.SelectedItem.ToString())
            {
                case "Interes":
                    TextBoxInt.Enabled = false;
                    TextBoxInt.Text = "0";
                    TextBoxInt.Focus();
                    break;

                case "Capital":
                    TextBoxCap.Enabled = false;
                    TextBoxCap.Text = "0";
                    TextBoxCap.Focus();
                    break;

                case "Valor Final":
                    TextBoxVF.Enabled = false;
                    TextBoxVF.Text = "0";
                    TextBoxVF.Focus();
                    break;

                case "Tasa de Interes":
                    TextBoxTI.Enabled = false;
                    TextBoxTI.Text = "0";
                    TextBoxTI.Focus();
                    break;

                case "Tiempo":
                    TextBoxTiempo.Enabled = false;
                    TextBoxTiempo.Text = "0";
                    TextBoxTiempo.Focus();
                    break;
            }
        }

        //Solo permitir la entrada de (Numeros) y (,)
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && ((System.Windows.Forms.TextBox)sender).Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void TextBoxInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_KeyPress(sender, e);
        }

        private void TextBoxCap_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_KeyPress(sender, e);
        }

        private void TextBoxVF_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_KeyPress(sender, e);
        }

        private void TextBoxTI_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_KeyPress(sender, e);
        }

        private void TextBoxTiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_KeyPress(sender, e);
        }
    }
}
