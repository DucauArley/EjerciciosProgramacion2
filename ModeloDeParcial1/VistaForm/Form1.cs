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
    public partial class Form1 : Form
    {
        private Curso curso;

        public Form1()
        {
            InitializeComponent();
            cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));
            cmbDivision.DataSource = Enum.GetValues(typeof(Divisiones));

        }

        private void btnCrearCurso_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);

            curso = new Curso(short.Parse(nudAnioCurso.Text), division, new Profesor(txtNombreProfe.Text, txtApellidoProfe.Text, txtDocumentoProfe.Text, DateTime.Parse(dtpFechaIngreso.Text)));

            //MessageBox.Show("No se pudo crear el curso");

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            rtbDatos.Text = (string)curso;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);

            Alumno alumno = new Alumno(txtNombre.Text, txtApellido.Text, txtDocumento.Text, short.Parse(nudAnio.Text), division);

            curso = curso + alumno;
            
        }
    }
}
