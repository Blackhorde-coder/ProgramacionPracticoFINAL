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
    public partial class CargarMascotaForm : Form
    {
        manipulationcls bd = new manipulationcls(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Blackhorde\Documents\GitHub\ProgramacionPracticoFINAL\Prueba3form\TP Programacion ll.mdb");
        const int tam = 1000;
        mascotacls [] arraymascotas = new mascotacls [tam];
        clientecls[] arrayclientes = new clientecls[tam];



        public CargarMascotaForm()
        {
            InitializeComponent();
        }
        private void CargarMascotaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ClienteForm cc = new ClienteForm();
            cc.ShowDialog();
        }

        private void limpiarcampos()
        {
            txtDescripcion.Text = "";
            txtNombre.Text = "";
            cmbTipo.SelectedIndex = -1;
            dtpFechaNac.Value = DateTime.Today;

        }


    }
}
