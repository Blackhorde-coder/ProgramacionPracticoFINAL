
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Prueba3form
{
    public partial class MenuPrincipalForm : Form
    {
      
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void comprobanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este boton aun no esta programado");

        }

        private void chequesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este boton aun no esta programado");
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este boton aun no esta programado");
        }

        private void ordenDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este boton aun no esta programado");
        }

        private void cobranzasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este boton aun no esta programado");
        }

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este boton aun no esta programado");
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este boton aun no esta programado");
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este boton aun no esta programado");
        }

        private void atencionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este boton aun no esta programado");
        }

        private void consultarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este boton aun no esta programado");
        }

        private void cargarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este boton aun no esta programado");
        }

        private void listaDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este boton aun no esta programado");
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este boton aun no esta programado");
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este boton aun no esta programado");
        }

        private void comprobanteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este boton aun no esta programado");
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este boton aun no esta programado");
        }

        private void cargarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteForm cc = new ClienteForm();
            cc.ShowDialog();

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //para el update de clientes
        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //para consulta sobre clientes.
        }

        private void cargarMascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CargarMascotaForm cm = new CargarMascotaForm();
            cm.ShowDialog();

        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
       
        }

        private void consultarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ReporteClientesForm rf = new ReporteClientesForm();
            rf.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NOSOTROS NECESITAMOS AYUDA: :-) jajajaj", "AYUDAAAAA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MenuPrincipalForm_Load(object sender, EventArgs e)
        {
            
        }

        private void mascotasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReporteMascotasForm rm = new ReporteMascotasForm();
            rm.ShowDialog();
            //crear reporte de mascotas con dueños y tipo
        }
    }
}
