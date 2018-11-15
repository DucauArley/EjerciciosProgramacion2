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
        private List<Persona> listaPersonas;

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
            listaPersonas = PersonaDAO.Leer();

            lstPersonas.Text = listaPersonas.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = lstPersonas.SelectedIndex;

            Persona p = listaPersonas[indice];

            PersonaDAO.Modificar(p.ID, txtNombre.Text, txtApellido.Text);

            listaPersonas.Insert(indice, p);

            lstPersonas.Text = listaPersonas.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = lstPersonas.SelectedIndex;

            Persona p = listaPersonas[indice];

            PersonaDAO.Borrar(p.ID);

            listaPersonas.Remove(p);

            lstPersonas.Text = listaPersonas.ToString();
        }
    }
}
