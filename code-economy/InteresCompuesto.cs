using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace code_economy
{
    public partial class InteresCompuesto : Form
    {
        public InteresCompuesto()
        {
            InitializeComponent();
            ComboBoxQCalcular.SelectedIndex = 0;
            ComboBoxTI.SelectedIndex = 1;
            ComboBoxTiempo.SelectedIndex = 1;
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

            //############################################################################################
            // Habilitar todos los campos por defecto
            TextBoxInt.Enabled = true;
            TextBoxCap.Enabled = true;
            TextBoxVF.Enabled = true;
            TextBoxTI.Enabled = true;
            TextBoxTiempo.Enabled = true;

            // Mostrar todos los campos y etiquetas por defecto
            TextBoxInt.Visible = true;
            LabelInteres.Visible = true;
            TextBoxCap.Visible = true;
            LabelCapital.Visible = true;
            TextBoxVF.Visible = true;
            LabelValorFinal.Visible = true;
            TextBoxTI.Visible = true;
            LabelTasaInteres.Visible = true;
            TextBoxTiempo.Visible = true;
            LabelTiempo.Visible = true;

            switch (ComboBoxQCalcular.SelectedItem.ToString())
            {
                case "Interes":
                    TextBoxInt.Enabled = false;
                    TextBoxInt.Text = "0";
                    TextBoxInt.Focus();

                    // Ocultar el Valor Final (TextBox) y el label Valor Final
                    TextBoxVF.Visible = false; // Ocultar el TextBox de Valor Final
                    LabelValorFinal.Visible = false; // Ocultar el label de Valor Final
                    break;

                case "Capital":
                    TextBoxCap.Enabled = false;
                    TextBoxCap.Text = "0";
                    TextBoxCap.Focus();

                    // Ocultar el campo Valor Final (TextBox) y el label Valor Final
                    TextBoxVF.Visible = false;
                    LabelValorFinal.Visible = false;

                    break;

                case "Valor Final":
                    TextBoxVF.Enabled = false;
                    TextBoxVF.Text = "0";
                    TextBoxVF.Focus();

                    // Ocultar el campo Interes (TextBox) y el label Interes
                    TextBoxInt.Visible = false;
                    LabelInteres.Visible = false;
                    break;

                case "Tasa de Interes":
                    TextBoxTI.Enabled = false;
                    TextBoxTI.Text = "0";
                    TextBoxTI.Focus();

                    // Ocultar el Valor Final (TextBox) y el label Valor Final
                    TextBoxVF.Visible = false;
                    LabelValorFinal.Visible = false;
                    break;

                case "Tiempo":
                    TextBoxTiempo.Enabled = false;
                    TextBoxTiempo.Text = "0";
                    TextBoxTiempo.Focus();

                    // Ocultar el campo Valor Final (TextBox) y el label Valor Final
                    TextBoxVF.Visible = false;
                    LabelValorFinal.Visible = false;
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

        private bool CamposVacios(string selectedOption)
        {
            return selectedOption switch
            {
                "Interes" => TextBoxCap.Text == "" || TextBoxTI.Text == "" || TextBoxTiempo.Text == "",
                "Capital" => TextBoxCap.Text == "" || TextBoxInt.Text == "" || TextBoxTI.Text == "" || TextBoxTiempo.Text == "",
                "Valor Final" => TextBoxCap.Text == "" || TextBoxVF.Text == "" || TextBoxTI.Text == "" || TextBoxTiempo.Text == "",
                "Tasa de Interes" => TextBoxCap.Text == "" || TextBoxTI.Text == "" || TextBoxInt.Text == "" || TextBoxTiempo.Text == "",
                "Tiempo" => TextBoxCap.Text == "" || TextBoxInt.Text == "" || TextBoxTI.Text == "" || TextBoxTiempo.Text == "",
                _ => true,// En caso de opción no válida, considerar campos vacíos
            };
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            string selectedOption = ComboBoxQCalcular.SelectedItem.ToString();

            // Verificar campos vacíos
            if (CamposVacios(selectedOption))
            {
                MessageBox.Show("EXISTEN CAMPOS VACÍOS");
                return;
            }

            // Declaracion de variables
            double C = double.Parse(TextBoxCap.Text);
            double i = double.Parse(TextBoxTI.Text);
            double I = double.Parse(TextBoxInt.Text);
            double t = double.Parse(TextBoxTiempo.Text);
            double day;
            double month;
            double year;
            double aux;
            double VF;
            //double I;

            switch (selectedOption)
            {
                case "Interes":
                    // Calcular el interés
                    switch (ComboBoxTiempo.SelectedItem.ToString())
                    {
                        case "Mensual":
                            break;

                        case "Dia":
                            break;

                        case "Anual":
                            break;

                        case "Bimensual":
                            break;

                        case "Trimestral":
                            break;

                        case "Cuatrimestral":
                            break;

                        case "Semestral":
                            break;
                    }

                    break;

                case "Capital":
                    // Calcular el capital
                    switch (ComboBoxTiempo.SelectedItem.ToString())
                    {
                        case "Mensual":
                            break;

                        case "Dia":
                            break;

                        case "Anual":
                            break;

                        case "Bimensual":
                            break;

                        case "Trimestral":
                            break;

                        case "Cuatrimestral":
                            break;

                        case "Semestral":
                            break;
                    }
                    break;

                case "Valor Final":
                    // Calcular el valor final
                    switch (ComboBoxTiempo.SelectedItem.ToString())
                    {
                        case "Mensual":
                            break;

                        case "Dia":
                            break;

                        case "Anual":
                            break;

                        case "Bimensual":
                            break;

                        case "Trimestral":
                            break;

                        case "Cuatrimestral":
                            break;

                        case "Semestral":
                            break;
                    }

                    break;

                case "Tasa de Interes":
                    // Calcular la tasa de interés
                    switch (ComboBoxTiempo.SelectedItem.ToString())
                    {
                        case "Mensual":
                            break;

                        case "Dia":
                            break;

                        case "Anual":
                            break;

                        case "Bimensual":
                            break;

                        case "Trimestral":
                            break;

                        case "Cuatrimestral":
                            break;

                        case "Semestral":
                            break;
                    }
                    break;

                case "Tiempo":
                    // Calcular el tiempo
                    break;

                default:
                    // Manejar opción no válida
                    break;
            }
        }
    }
}


