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
    public partial class ReporteMascotasForm : Form
    {
        public ReporteMascotasForm()
        {
            InitializeComponent();
        }

        private void ReporteMascotasForm_Load(object sender, EventArgs e)
        {
            this.DataTable1TableAdapter.FillMascotas(this.DataSetMascotas.DataTable1);
            this.reportViewer1.RefreshReport();
        }


    }
}
