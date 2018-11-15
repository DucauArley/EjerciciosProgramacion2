using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio61
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona p = new Persona(txtNombre.Text, txtApellido.Text);

            PersonaDAO.Guardar(p);
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            List<Persona> listaPersonas = PersonaDAO.Leer();

            lstPersonas.Text = listaPersonas.ToString();
        }
    }
}
