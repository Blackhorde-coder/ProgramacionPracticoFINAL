using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba3form
{
    public partial class ReporteClientesForm : Form
    {
        public ReporteClientesForm()
        {
            InitializeComponent();
        }

        private void ReporteClientesForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetClientes.Cliente' Puede moverla o quitarla según sea necesario.
            this.ClienteTableAdapter.ReportClientes(this.DataSetClientes.Cliente);
            this.reportViewer1.RefreshReport();
        }
    }
}
