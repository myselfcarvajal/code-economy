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
    public partial class TasaInternaRetorno : Form
    {
        public TasaInternaRetorno()
        {
            InitializeComponent();
            ComboBoxQCantidadPeriodos.SelectedIndex = 1;
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

        private void textBoxIvInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_KeyPress(sender, e);
        }

        private void textBoxAnyo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_KeyPress(sender, e);
        }

        private void textBoxAnyo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_KeyPress(sender, e);
        }



        private void ComboBoxQCantidadPeriodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Año 1
            textBoxAnyo1.Enabled = true;
            textBoxAnyo1.Visible = true;

            //Año 2
            textBoxAnyo2.Enabled = true;
            textBoxAnyo2.Visible = true;

            textBoxTIR.Enabled = false;
            textBoxTIR.Text = "0";
            textBoxTIR.Focus();

            switch (ComboBoxQCantidadPeriodos.SelectedItem.ToString())
            {
                case "1":
                    //Año 1
                    textBoxAnyo2.Enabled = false;
                    textBoxAnyo2.Visible = false;
                    break;

                case "2":
                    //Año 1
                    textBoxAnyo1.Enabled = true;
                    textBoxAnyo1.Visible = true;
                    //Año 2
                    textBoxAnyo2.Enabled = true;
                    textBoxAnyo2.Visible = true;

                    break;

                default:
                    // Manejar otras opciones del ComboBox aquí
                    break;
            }
        }

        // Definir cadenas de formato.
        string MoneyFmt = "###,##0.00";
        string PercentFmt = "#0.00";

        double IvInicial = 0;
        double primerAnyo = 0;
        double segundoAnyo = 0;

        // Función para calcular la Tasa Interna de Retorno (TIR)
        static double IRR(double[] values, double guess)
        {
            const double tolerance = 0.00001;
            double x0 = guess;
            double x1 = 0;
            double npv = 0;

            do
            {
                npv = 0;
                for (int i = 0; i < values.Length; i++)
                {
                    npv += values[i] / Math.Pow(1 + x0, i);
                }

                double dNpv = 0;
                for (int i = 1; i < values.Length; i++)
                {
                    dNpv += -i * values[i] / Math.Pow(1 + x0, i + 1);
                }

                x1 = x0 - npv / dNpv;
                x0 = x1;
            } while (Math.Abs(npv) > tolerance);

            return x1;
        }

        private void BtnCalcularTIR_Click(object sender, EventArgs e)
        {
            IvInicial = double.Parse(textBoxIvInicial.Text);
            primerAnyo = double.Parse(textBoxAnyo1.Text);
            segundoAnyo = double.Parse(textBoxAnyo2.Text);

            double[] values = new double[6];
            // Costos iniciales del negocio.
            values[0] = -IvInicial;

            double Guess = 0.10;

            double CalcRetRate = 0;

            switch (ComboBoxQCantidadPeriodos.SelectedItem.ToString())
            {
                case "1":
                    //calculo de TIR en 1 años
                    //calculo de TIR en 1 año
                    //double[] values = new double[6];
                    // Costos iniciales del negocio.
                    //values[0] = - IvInicial;
                    // Flujos de efectivo positivos
                    values[1] = primerAnyo;


                    // Utilizar la función IRR para calcular la tasa de retorno.
                    // Suposición inicial comienza en 10 por ciento.
                    //double Guess = 0.10;
                    // Calcular la tasa interna.

                    CalcRetRate = IRR(values, Guess) * 100;


                    textBoxTIR.Text = CalcRetRate.ToString(PercentFmt);
                    break;

                case "2":
                    //calculo de TIR en 2 años
                    values[1] = primerAnyo;
                    values[2] = segundoAnyo;

                    CalcRetRate = IRR(values, Guess) * 100;

                    textBoxTIR.Text = CalcRetRate.ToString(PercentFmt);
                    break;

                default:
                    // Manejar otras opciones del ComboBox aquí
                    break;
            }
        }
    }
}
