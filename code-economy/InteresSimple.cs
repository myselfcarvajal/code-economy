using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private void TextBoxDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_KeyPress(sender, e);
        }

        private void TextBoxMeses_KeyPress(object sender, KeyPressEventArgs e)
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

            //Si existen campos vacios
            if (TextBoxDias.Text == "Dias")
            {
                TextBoxDias.Text = "0";
            }

            if (TextBoxMeses.Text == "Meses")
            {
                TextBoxMeses.Text = "0";
            }

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
            double VF;
            //double I;

            switch (selectedOption)
            {
                case "Interes":
                    // Calcular el interés
                    switch (ComboBoxTiempo.SelectedItem.ToString())
                    {
                        case "Mensual":

                            day = double.Parse(TextBoxDias.Text);
                            month = double.Parse(TextBoxTiempo.Text);

                            I = CalculateInterest(C, i, day, month);

                            TextBoxInt.Text = I.ToString("0.00");
                            break;

                        case "Dia":

                            month = double.Parse(TextBoxTiempo.Text);

                            I = CalculateInterest(C, i, month);

                            TextBoxInt.Text = I.ToString("0.00");
                            break;

                        case "Anual":

                            day = double.Parse(TextBoxDias.Text);
                            month = double.Parse(TextBoxMeses.Text);
                            year = double.Parse(TextBoxTiempo.Text);

                            I = CalculateInterest(C, i, day, month, year);

                            TextBoxInt.Text = I.ToString("0.00");
                            break;

                        case "Bimensual":

                            aux = double.Parse(TextBoxTiempo.Text);
                            double bimensual = 2;
                            day = 0;

                            month = aux * bimensual;

                            I = CalculateInterest(C, i, day, month);

                            TextBoxInt.Text = I.ToString("0.00");
                            break;

                        case "Trimestral":

                            aux = double.Parse(TextBoxTiempo.Text);
                            double trimestral = 3;
                            day = 0;

                            month = aux * trimestral;


                            I = CalculateInterest(C, i, day, month);

                            TextBoxInt.Text = I.ToString("0.00");
                            break;

                        case "Cuatrimestral":

                            aux = double.Parse(TextBoxTiempo.Text);
                            double cuatrimestral = 4;
                            day = 0;

                            month = aux * cuatrimestral;

                            I = CalculateInterest(C, i, day, month);

                            TextBoxInt.Text = I.ToString("0.00");
                            break;

                        case "Semestral":

                            aux = double.Parse(TextBoxTiempo.Text);
                            double semestral = 6;
                            day = 0;

                            month = aux * semestral;


                            I = CalculateInterest(C, i, day, month);

                            TextBoxInt.Text = I.ToString("0.00");
                            break;
                    }

                    break;

                case "Capital":
                    // Calcular el capital
                    switch (ComboBoxTiempo.SelectedItem.ToString())
                    {
                        case "Mensual":

                            day = double.Parse(TextBoxDias.Text);
                            month = double.Parse(TextBoxTiempo.Text);

                            C = CalculateCapital(I, i, day, month);

                            TextBoxCap.Text = C.ToString("0.00");
                            break;

                        case "Dia":

                            day = double.Parse(TextBoxTiempo.Text);

                            C = CalculateCapital(I, i, day);

                            TextBoxCap.Text = C.ToString("0.00");
                            break;

                        case "Anual":

                            day = double.Parse(TextBoxDias.Text);
                            month = double.Parse(TextBoxMeses.Text);
                            year = double.Parse(TextBoxTiempo.Text);

                            C = CalculateCapital(I, i, day, month, year);

                            TextBoxCap.Text = C.ToString("0.00");
                            break;

                        case "Bimensual":

                            aux = double.Parse(TextBoxTiempo.Text);
                            double bimensual = 2;
                            day = 0;

                            month = aux * bimensual;

                            C = CalculateCapital(I, i, day, month);

                            TextBoxCap.Text = C.ToString("0.00");
                            break;

                        case "Trimestral":

                            aux = double.Parse(TextBoxTiempo.Text);
                            double trimestral = 3;
                            day = 0;

                            month = aux * trimestral;

                            C = CalculateCapital(I, i, day, month);

                            TextBoxCap.Text = C.ToString("0.00");
                            break;

                        case "Cuatrimestral":

                            aux = double.Parse(TextBoxTiempo.Text);
                            double cuatrimestral = 4;
                            day = 0;

                            month = aux * cuatrimestral;

                            C = CalculateCapital(I, i, day, month);

                            TextBoxCap.Text = C.ToString("0.00");
                            break;

                        case "Semestral":

                            aux = double.Parse(TextBoxTiempo.Text);
                            double semestral = 6;
                            day = 0;

                            month = aux * semestral;

                            C = CalculateCapital(I, i, day, month);

                            TextBoxCap.Text = C.ToString("0.00");
                            break;
                    }
                    break;

                case "Valor Final":
                    // Calcular el valor final
                    switch (ComboBoxTiempo.SelectedItem.ToString())
                    {
                        case "Mensual":

                            day = double.Parse(TextBoxDias.Text);
                            month = double.Parse(TextBoxTiempo.Text);

                            VF = CalculateValorFinal(C, i, day, month);

                            TextBoxVF.Text = VF.ToString("0.00");
                            break;

                        case "Dia":

                            month = double.Parse(TextBoxTiempo.Text);

                            VF = CalculateValorFinal(C, i, month);

                            TextBoxVF.Text = VF.ToString("0.00");
                            break;

                        case "Anual":

                            day = double.Parse(TextBoxDias.Text);
                            month = double.Parse(TextBoxMeses.Text);
                            year = double.Parse(TextBoxTiempo.Text);

                            VF = CalculateValorFinal(C, i, day, month, year);

                            TextBoxVF.Text = VF.ToString("0.00");
                            break;

                        case "Bimensual":

                            aux = double.Parse(TextBoxTiempo.Text);
                            double bimensual = 2;

                            month = aux * bimensual;


                            VF = CalculateValorFinal(C, i, month);

                            TextBoxVF.Text = VF.ToString("0.00");
                            break;

                        case "Trimestral":

                            aux = double.Parse(TextBoxTiempo.Text);
                            double trimestral = 3;

                            month = aux * trimestral;


                            VF = CalculateValorFinal(C, i, month);

                            TextBoxVF.Text = VF.ToString("0.00");
                            break;

                        case "Cuatrimestral":

                            aux = double.Parse(TextBoxTiempo.Text);
                            double cuatrimestral = 4;

                            month = aux * cuatrimestral;


                            VF = CalculateValorFinal(C, i, month);

                            TextBoxVF.Text = VF.ToString("0.00");
                            break;

                        case "Semestral":

                            aux = double.Parse(TextBoxTiempo.Text);
                            double semestral = 6;

                            month = aux * semestral;


                            VF = CalculateValorFinal(C, i, month);

                            TextBoxVF.Text = VF.ToString("0.00");
                            break;
                    }

                    break;

                case "Tasa de Interes":
                    // Calcular la tasa de interés
                    switch (ComboBoxTiempo.SelectedItem.ToString())
                    {
                        case "Mensual":

                            day = double.Parse(TextBoxDias.Text);
                            month = double.Parse(TextBoxTiempo.Text);

                            i = CalculateTasaInteres(I, C, day, month);

                            TextBoxTI.Text = i.ToString("0.00");
                            break;

                        case "Dia":

                            day = double.Parse(TextBoxTiempo.Text);

                            i = CalculateTasaInteres(I, C, day);

                            TextBoxTI.Text = i.ToString("0.00");
                            break;

                        case "Anual":

                            day = double.Parse(TextBoxDias.Text);
                            month = double.Parse(TextBoxMeses.Text);
                            year = double.Parse(TextBoxTiempo.Text);

                            i = CalculateTasaInteres(I, C, day, month, year);

                            TextBoxTI.Text = i.ToString("0.00");
                            break;

                        case "Bimensual":

                            aux = double.Parse(TextBoxTiempo.Text);
                            double bimensual = 2;
                            day = 0;

                            month = aux * bimensual;

                            i = CalculateTasaInteres(I, C, day, month);

                            TextBoxTI.Text = i.ToString("0.00");
                            break;

                        case "Trimestral":

                            aux = double.Parse(TextBoxTiempo.Text);
                            double trimestral = 3;
                            day = 0;

                            month = aux * trimestral;

                            i = CalculateTasaInteres(I, C, day, month);

                            TextBoxTI.Text = i.ToString("0.00");
                            break;

                        case "Cuatrimestral":

                            aux = double.Parse(TextBoxTiempo.Text);
                            double cuatrimestral = 4;
                            day = 0;

                            month = aux * cuatrimestral;

                            i = CalculateTasaInteres(I, C, day, month);

                            TextBoxTI.Text = i.ToString("0.00");
                            break;

                        case "Semestral":

                            aux = double.Parse(TextBoxTiempo.Text);
                            double semestral = 6;
                            day = 0;

                            month = aux * semestral;

                            i = CalculateTasaInteres(I, C, day, month);

                            TextBoxTI.Text = i.ToString("0.00");
                            break;
                    }
                    break;

                case "Tiempo":
                    // Calcular el tiempo

                    t = CalculateTiempo(I, C, i);

                    TextBoxTiempo.Text = t.ToString("0.0000");
                    break;

                default:
                    // Manejar opción no válida
                    break;
            }
        }
        private double CalculateInterest(double C, double i, double day = 0, double month = 0, double year = 0)
        {
            double porcentaje = i; // Este es el valor en porcentaje 
            double valorDecimal = porcentaje / 100.0; // Convierte el porcentaje a decimal

            // Calcular el interés simple utilizando la fórmula I = C * i * t
            double interest = C * valorDecimal * (year + (day / 365) + (month / 12));
            return interest;
        }

        private double CalculateValorFinal(double C, double i, double day = 0, double month = 0, double year = 0)
        {
            double porcentaje = i; // Este es el valor en porcentaje (16%)
            double valorDecimal = porcentaje / 100.0; // Convierte el porcentaje a decimal

            // Calcular el valor final utilizando la fórmula VF = C * (1 + (i*t))
            double valorFinal = C * (1 + (valorDecimal) * (year + (day / 365) + (month / 12)));
            return valorFinal;
        }

        private double CalculateCapital(double I, double i, double day = 0, double month = 0, double year = 0)
        {
            double porcentaje = i; // Este es el valor en porcentaje (16%)
            double valorDecimal = porcentaje / 100.0; // Convierte el porcentaje a decimal

            // Calcular el Capital utilizando la fórmula C = I / (i*t)
            double capital = I / ((valorDecimal) * (year + (day / 365) + (month / 12)));
            return capital;
        }

        private double CalculateTasaInteres(double I, double C, double day = 0, double month = 0, double year = 0)
        {
            // Calcular la Tasa de Interes utilizando la fórmula i = I / (C*t)
            double tasaInteres = I / ((C) * (year + (day / 365) + (month / 12)));


            //Convertir a porcentaje
            return tasaInteres * 100;
        }

        private double CalculateTiempo(double I, double C, double i)
        {
            double porcentaje = i; // Este es el valor en porcentaje (16%)
            double valorDecimal = porcentaje / 100.0; // Convierte el porcentaje a decimal

            // Calcular el tiempo utilizando la fórmula t = I / (C*i)
            double tiempo = I / ((C) * (valorDecimal));

            //Tiempo en años
            ComboBoxTiempo.SelectedIndex = 6;

            //Convertir a porcentaje
            return tiempo;
        }

        private void ComboBoxTiempo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Dias
            TextBoxDias.Enabled = false;
            TextBoxDias.Visible = false;

            //Meses
            TextBoxMeses.Enabled = false;
            TextBoxMeses.Visible = false;

            switch (ComboBoxTiempo.SelectedItem.ToString())
            {

                case "Dia":

                    break;

                case "Mensual":
                    TextBoxDias.Enabled = true;
                    TextBoxDias.Visible = true;

                    break;

                case "Bimensual":

                    break;

                case "Trimestral":

                    break;

                case "Cuatrimestral":

                    break;

                case "Semestral":

                    break;

                case "Anual":

                    //Activar ComboBox Dias
                    TextBoxDias.Enabled = true;
                    TextBoxDias.Visible = true;

                    //Activar ComboBox Meses
                    TextBoxMeses.Enabled = true;
                    TextBoxMeses.Visible = true;

                    break;
            }
        }

        //PlaceHolder Text
        private void TextBoxDias_MouseEnter(object sender, EventArgs e)
        {
            if (TextBoxDias.Text == "Dias")
            {
                TextBoxDias.Text = "";
                TextBoxDias.ForeColor = Color.Black;
            }

        }

        private void TextBoxDias_MouseLeave(object sender, EventArgs e)
        {
            if (TextBoxDias.Text == "")
            {
                TextBoxDias.Text = "Dias";
                TextBoxDias.ForeColor = Color.Silver;
            }
        }

        private void TextBoxMeses_MouseEnter(object sender, EventArgs e)
        {
            if (TextBoxMeses.Text == "Meses")
            {
                TextBoxMeses.Text = "";
                TextBoxMeses.ForeColor = Color.Black;
            }
        }

        private void TextBoxMeses_MouseLeave(object sender, EventArgs e)
        {
            if (TextBoxMeses.Text == "")
            {
                TextBoxMeses.Text = "Meses";
                TextBoxMeses.ForeColor = Color.Silver;
            }
        }

        private void LimpiarCampoIntSimple()
        {
            switch (ComboBoxQCalcular.SelectedItem.ToString())
            {
                case "Interes":
                    TextBoxInt.Text = "0";
                    TextBoxCap.Text = "";
                    TextBoxTI.Text = "";

                    TextBoxTiempo.Text = "";
                    TextBoxMeses.Text = "";
                    TextBoxDias.Text = "";
                    break;

                case "Capital":
                    TextBoxCap.Text = "0";
                    TextBoxInt.Text = "";
                    TextBoxTI.Text = "";

                    TextBoxTiempo.Text = "";
                    TextBoxMeses.Text = "";
                    TextBoxDias.Text = "";
                    break;

                case "Valor Final":
                    TextBoxVF.Text = "0";
                    TextBoxCap.Text = "";
                    TextBoxTI.Text = "";

                    TextBoxTiempo.Text = "";
                    TextBoxMeses.Text = "";
                    TextBoxDias.Text = "";
                    break;

                case "Tasa de Interes":
                    TextBoxTI.Text = "0";
                    TextBoxInt.Text = "";
                    TextBoxCap.Text = "";

                    TextBoxTiempo.Text = "";
                    TextBoxMeses.Text = "";
                    TextBoxDias.Text = "";
                    break;

                case "Tiempo":
                    TextBoxTiempo.Text = "0";
                    TextBoxInt.Text = "";
                    TextBoxCap.Text = "";
                    TextBoxTI.Text = "";

                    TextBoxMeses.Text = "";
                    TextBoxDias.Text = "";
                    break;
            }
        }

        private void BtnTrashIntSimple_Click(object sender, EventArgs e)
        {
            LimpiarCampoIntSimple();
        }
    }
}
