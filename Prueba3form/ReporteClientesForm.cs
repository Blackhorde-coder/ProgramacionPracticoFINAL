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
            this.ClienteTableAdapter.ReportClientes(this.DataSetClientes.Cliente);
            this.reportViewer1.RefreshReport();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (rdbTodos.Checked == true)
            {
                this.ClienteTableAdapter.ReportClientes(this.DataSetClientes.Cliente);
                this.reportViewer1.RefreshReport();
            }
            else if (rdbActivos.Checked == true)
            {
                this.ClienteTableAdapter.FillBy(this.DataSetClientes.Cliente, true);
                this.reportViewer1.RefreshReport();
            }
            else if (rdbInactivos.Checked == false)
            {
                this.ClienteTableAdapter.FillBy(this.DataSetClientes.Cliente, false);
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
