using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ejercicio67
{
    public partial class Form1 : Form
    {
        Temporizador temp = null;

        public Form1()
        {
            InitializeComponent();
            lblTimer.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            temp = new Temporizador(1000);
            temp.EventoTiempo += AsignarHora;
            temp.Activar = true;
        }

        private void AsignarHora()
        {
            if (this.lblTimer.InvokeRequired)
            {
                this.lblTimer.BeginInvoke((MethodInvoker)delegate ()
                {
                    lblTimer.Text = DateTime.Now.ToString();
                }
                );
            }
            else
            {
                lblTimer.Text = DateTime.Now.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            temp.Activar = false;
        }
    }
}
