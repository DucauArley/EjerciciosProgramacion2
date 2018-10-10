using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class FormDT : Form
    {
        private DirectorTecnico dt;

        public FormDT()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Crea un Director tecnico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCrear_Click(object sender, EventArgs e)
        {
            int edad = 0;
            int dni = 0;
            int experiencia = 0;

            int.TryParse(numericUpDownEdad.Text, out edad);
            int.TryParse(numericUpDownDni.Text, out dni);
            int.TryParse(numericUpDownExperiencia.Text, out experiencia);

            dt = new DirectorTecnico(textBoxNombre.Text, textBoxApellido.Text, edad, dni, experiencia);

            MessageBox.Show("Se ha creado un DT!");

        }


        /// <summary>
        /// Valida que el director tecnico se haya creado o no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonValidar_Click(object sender, EventArgs e)
        {
            if(dt is null)
            {
                MessageBox.Show("Aun no se ha creao el DT del formulario");
            }
            else
            {
                if (dt.ValidarAptitud())
                {
                    MessageBox.Show("El DT es apto");
                }
                else
                {
                    MessageBox.Show("El DT no es apto");
                }
            }





        }
    }
}
