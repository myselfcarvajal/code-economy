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
    public partial class GradientesForm : Form
    {
        public GradientesForm()
        {
            InitializeComponent();
            TextBoxTiempo.Text = "0";
            TexBoxCreciente.Text = "0";


        }

        private void ComboBoxQCalcularGra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LabelQCalcular_Click(object sender, EventArgs e)
        {

        }

        // variables

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double cuotainicial = double.Parse(TextBoxCuota.Text);

            double Tiempo = double.Parse(TextBoxTiempo.Text);

            double Interes = double.Parse(TextBoxI.Text);
            double Gradiente = double.Parse(TextBoxG.Text);
            double creciente = double.Parse(TexBoxCreciente.Text);



            string selectedComboBoxQTema = ComboBoxQTema.SelectedItem.ToString();
            string selectedComboBoxCal = comboBoxCal.SelectedItem.ToString();

            switch (selectedComboBoxQTema)
            {
                case "Gradiente Aritmetico":
                    switch (selectedComboBoxCal)
                    {
                        case "Valor Presente":
                            var aux = ValorPresente(cuotainicial, Gradiente, Tiempo, Interes);
                            double Vcreciente = aux.creciente;
                            TexBoxCreciente.Text = Vcreciente.ToString();
                            double Vdecreciente = aux.decreciente;
                            textBoxValor2.Text = Vdecreciente.ToString();

                            break;

                        case "Valor Infinito":
                            aux = ValorInfinito(cuotainicial, Gradiente, Interes);
                            Vcreciente = aux.creciente;
                            TexBoxCreciente.Text = Vcreciente.ToString();
                            Vdecreciente = aux.decreciente;
                            textBoxValor2.Text = Vdecreciente.ToString();

                            break;

                        case "Valor Futuro":
                            aux = ValorFuturo(cuotainicial, Gradiente, Tiempo, Interes);
                            Vcreciente = aux.creciente;
                            TexBoxCreciente.Text = Vcreciente.ToString();
                            Vdecreciente = aux.decreciente;
                            textBoxValor2.Text = Vdecreciente.ToString();

                            break;

                        case "Capital":
                            var aux1 = CalcularCapital(creciente, Gradiente, Tiempo, Interes);

                            TextBoxCuota.Text = aux1.ToString();


                            break;

                        // Agrega más casos según sea necesario para otras opciones de comboBoxCal

                        default:
                            // Manejar un caso por defecto si no se encuentra una coincidencia en comboBoxCal
                            break;


                    }
                    break;

                // Agrega más casos según sea necesario para otras opciones de ComboBoxQTema

                default:
                    // Manejar un caso por defecto si no se encuentra una coincidencia en ComboBoxQTema
                    break;
            }




        }

        private (double creciente, double decreciente) ValorPresente(double A, double G, double N, double I)
        {
            double PD = I / 100;



            double comun = Math.Pow((1 + PD), N);
            double comun2 = G / PD;
            double P1 = (comun - 1) / (PD * comun);

            double creciente = A * P1 + comun2 * (P1 - (N / comun));
            double decreciente = A * P1 - comun2 * (P1 - (N / comun));

            return (creciente, decreciente);
        }


        private (double creciente, double decreciente) ValorFuturo(double A, double G, double N, double I)
        {
            double PD = I / 100;



            double comun = Math.Pow((1 + PD), N);
            double comun2 = G / PD;

            double decreciente = A * ((comun - 1) / PD) - G * ((comun - 1 - N * PD) / Math.Pow(PD, 2));


            double creciente = A * ((comun - 1) / PD) + G * ((comun - 1 - N * PD) / Math.Pow(PD, 2));
            //double decreciente = A * (comun / PD) - comun2 * ((comun / PD) - N);


            return (creciente, decreciente);
        }

        private (double creciente, double decreciente) ValorInfinito(double A, double G, double I)
        {

            double PD = I / 100;
            double creciente = (A / PD) + (G / Math.Pow(PD, 2));
            double decreciente = (A / PD) - (G / Math.Pow(PD, 2));
            return (creciente, decreciente);
        }

        private double CalcularCapital(double ValorFuturo, double G, double N, double I)
        {
            double PD = I / 100;

            double comun = Math.Pow((1 + PD), N);
            double denominador = (comun - 1) / PD;
            double A = (ValorFuturo - G * ((comun - 1 - N * PD) / Math.Pow(PD, 2))) / denominador;

            return A;
        }

        private void BtnTrashIntCompuesto_Click(object sender, EventArgs e)
        {

        }
    }
}
