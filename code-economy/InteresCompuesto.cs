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
                case "Capital":
                    TextBoxCap.Enabled = false;
                    TextBoxCap.Text = "0";
                    TextBoxCap.Focus();

                    // Ocultar el Interes (TextBox) y el label Interes
                    TextBoxInt.Visible = false;
                    LabelInteres.Visible = false;

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

                    // Ocultar el Interes (TextBox) y el label Interes
                    TextBoxInt.Visible = false;
                    LabelInteres.Visible = false;
                    break;

                case "Tiempo":
                    TextBoxTiempo.Enabled = false;
                    TextBoxTiempo.Text = "0";
                    TextBoxTiempo.Focus();

                    // Ocultar el campo Interes (TextBox) y el Interes
                    TextBoxInt.Visible = false;
                    LabelInteres.Visible = false;

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
                "Capital" => TextBoxCap.Text == "" || TextBoxVF.Text == "" || TextBoxTI.Text == "" || TextBoxTiempo.Text == "",
                "Valor Final" => TextBoxCap.Text == "" || TextBoxVF.Text == "" || TextBoxTI.Text == "" || TextBoxTiempo.Text == "",
                "Tasa de Interes" => TextBoxCap.Text == "" || TextBoxVF.Text == "" || TextBoxTiempo.Text == "",
                "Tiempo" => TextBoxCap.Text == "" || TextBoxVF.Text == "" || TextBoxTI.Text == "" || TextBoxTiempo.Text == "",
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

            //Si existen campos vacios
            if (TextBoxInt.Text == "")
            {
                TextBoxInt.Text = "0";
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
            double VF = double.Parse(TextBoxVF.Text); ;
            //double I;

            switch (selectedOption)
            {

                case "Capital":
                    // Calcular el capital
                    C = CalculateCapital(C, VF, i, t);

                    TextBoxCap.Text = C.ToString("0.00"); ;
                    break;

                case "Valor Final":
                    // Calcular el valor final
                    t = double.Parse(TextBoxTiempo.Text);

                    VF = CalculateValorFinalIntComp(C, i, t);
                    TextBoxVF.Text = VF.ToString("0.00");
                    break;

                case "Tasa de Interes":
                    // Calcular la tasa de interés
                    t = double.Parse(TextBoxTiempo.Text);

                    i = CalculateTasaInteresIntComp(C, VF, t);
                    TextBoxTI.Text = i.ToString("0.00");

                    //Asignar temporalidad segun seleccion de ComboBoxTI
                    int indiceSeleccionado_ = ComboBoxTiempo.SelectedIndex;

                    ComboBoxTI.SelectedIndex = indiceSeleccionado_;

                    break;

                case "Tiempo":
                    // Calcular el tiempo
                    VF = double.Parse(TextBoxVF.Text);

                    t = CalculateTiempoIntComp(C, VF, i);
                    Math.Truncate(t);

                    TextBoxTiempo.Text = t.ToString("0.0000");

                    //Asignar temporalidad segun seleccion de ComboBoxTI
                    int indiceSeleccionado = ComboBoxTI.SelectedIndex;

                    ComboBoxTiempo.SelectedIndex = indiceSeleccionado;
                    break;

                default:
                    // Manejar opción no válida
                    break;
            }
        }

        private double CalculateValorFinalIntComp(double C, double i, double t = 0)
        {

            double porcentaje = i; // Este es el valor en porcentaje (16%)
            double valorDecimal = porcentaje / 100.0; // Convierte el porcentaje a decimal

            // Calcular el valor final utilizando la fórmula VF = C * ((1 + i)^t)
            double valorFinal = C * Math.Pow((1 + valorDecimal), t);
            return valorFinal;
        }

        private double CalculateTiempoIntComp(double C, double VF, double i)
        {

            double porcentaje = i; // Este es el valor en porcentaje (16%)
            double valorDecimal = porcentaje / 100.0; // Convierte el porcentaje a decimal

            double aux, _aux;
            aux = VF / C;
            _aux = 1 + valorDecimal;


            // Calcular el tiempo utilizando la fórmula t = Log VF – Log C / Log ( 1 + i)
            double valorFinal = Math.Log(aux) / Math.Log(_aux);
            return valorFinal;
        }

        private double CalculateTasaInteresIntComp(double C, double VF, double t)
        {
            // Calcular la Tasa de Interes utilizando la fórmula i = (VF / C) ^ 1 / n - 1
            double tasaInteres = Math.Pow((VF / C), 1 / t) - 1;
            tasaInteres = tasaInteres * 100;

            return tasaInteres;
        }

        private double CalculateCapital(double C, double VF, double i, double t)
        {
            double porcentaje = i; // Este es el valor en porcentaje (16%)
            double valorDecimal = porcentaje / 100.0; // Convierte el porcentaje a decimal

            // Calcular la Tasa de Interes utilizando la fórmula C = VF / (1 + i) ^ t
            double capital = VF / Math.Pow((1 + valorDecimal), t);

            return capital;
        }
    }
}


