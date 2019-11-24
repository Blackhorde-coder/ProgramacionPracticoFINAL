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
            rdbTodos.Checked = true;
        }

        private void ReporteMascotasForm_Load(object sender, EventArgs e)
        {
            this.DataTable1TableAdapter.FillMascotas(this.DataSetMascotas.DataTable1);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (rdbTodos.Checked == true)
            {
                this.DataTable1TableAdapter.FillBy(this.DataSetMascotas.DataTable1, dtp1.Value, dtp2.Value);
                this.reportViewer1.RefreshReport();
            }
            else if (rdbActivos.Checked == true)
            {
                this.DataTable1TableAdapter.FillBy1(this.DataSetMascotas.DataTable1, dtp1.Value, dtp2.Value, true);
                this.reportViewer1.RefreshReport();
            }
            else if (rdbInactivos.Checked == true)
            {
                this.DataTable1TableAdapter.FillBy1(this.DataSetMascotas.DataTable1, dtp1.Value, dtp2.Value, false);
                this.reportViewer1.RefreshReport();

            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.ActiveBorder;
        }
    }
}
