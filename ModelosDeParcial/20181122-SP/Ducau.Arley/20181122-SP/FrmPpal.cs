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
using Patentes;
using Archivos;
using System.Threading;

namespace _20181122_SP
{
    public partial class FrmPpal : Form
    {
        Queue<Patente> cola;
        List<Thread> threads;

        public FrmPpal()
        {
            InitializeComponent();

            this.cola = new Queue<Patente>();
            this.threads = new List<Thread>();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            vistaPatente1.finExposcion += ProximaPatente;
            vistaPatente2.finExposcion += ProximaPatente;
        }

        private void IniciarSimulacion()
        {
            FinalizarSimulacion();

            ProximaPatente(vistaPatente1);
            ProximaPatente(vistaPatente2);
        }

        private void ProximaPatente(VistaPatente vistaPatente)
        {
            if(cola.Count != 0 && cola != null)
            {
                Thread t = new Thread(new ParameterizedThreadStart(vistaPatente.MostrarPatente));

                t.Start(cola.Last());
                
                threads.Add(t);             
            }
            
        }
        
        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            FinalizarSimulacion();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            Xml<Queue<Patente>> xml = new Xml<Queue<Patente>>();

            xml.Leer("patentes", out cola);
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            Texto txt = new Texto();

            txt.Leer("patentes", out cola);
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            Sql sql = new Sql();

            sql.Leer("Patentes", out cola);
        }

        private void FinalizarSimulacion()
        {
            foreach (Thread t in threads)
            {
                if (t.IsAlive)
                {
                    t.Abort();
                }
            }
        }
    }
}
