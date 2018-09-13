using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace Ejercicio23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonEuro_Click(object sender, EventArgs e)
        {
            double numero;

            if(double.TryParse(textEuro.Text, out numero))
            {
                Euro euro = new Euro(numero);
               
                textEuroEuro.Text = "" + euro.GetCantidad();
                textEuroDolar.Text = "" + ((Dolar) euro).GetCantidad();
                textEuroPeso.Text = "" + ((Peso)euro).GetCantidad();
            }
        }

        private void buttonDolar_Click(object sender, EventArgs e)
        {
            double numero;

            if (double.TryParse(textDolar.Text, out numero))
            {
                Dolar dolar = new Dolar(numero);

                textDolarEuro.Text = "" + ((Euro) dolar).GetCantidad();
                textDolarDolar.Text = "" + dolar.GetCantidad();
                textDolarPeso.Text = "" + ((Peso)dolar).GetCantidad();
            }

        }

        private void buttonPeso_Click(object sender, EventArgs e)
        {
            double numero;

            if (double.TryParse(textPeso.Text, out numero))
            {
                Peso peso = new Peso(numero);

                textPesoEuro.Text = "" + ((Euro) peso).GetCantidad();
                textPesoDolar.Text = "" + ((Dolar)peso).GetCantidad();
                textPesoPeso.Text = "" + peso.GetCantidad();
            }

        }

        private void textEuroEuro_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
