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
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
            activarbotones(true);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void ClienteForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            activarbotones(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            activarbotones(false);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarcampos();
            activarbotones(true);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            activarbotones(true);
        }

        private void limpiarcampos()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtBarrio.Text = "";
            txtCodFijo.Text = "";
            txtCodMovil.Text = "";
            txtDocumento.Text = "";
            txtTelFijo.Text = "";
            txtTelMovil.Text = "";
            rdbFemenino.Checked = false;
            rdbMasculino.Checked = false;
        }

        private void activarbotones(bool k)
        {
            btnNuevo.Enabled = k;
            btnEditar.Enabled = k;
            btnSalir.Enabled = k;

            txtApellido.Enabled = !k;
            txtNombre.Enabled = !k;
            listBox1.Enabled = !k;
            txtDireccion.Enabled = !k;
            txtDocumento.Enabled = !k;
            txtTelFijo.Enabled = !k;
            txtTelMovil.Enabled = !k;
            txtCodFijo.Enabled = !k;
            txtCodMovil.Enabled = !k;
            rdbFemenino.Enabled = !k;
            rdbMasculino.Enabled = !k;
            txtBarrio.Enabled = !k;
            btnCancelar.Enabled = !k;
            btnGuardar.Enabled = !k;
        }

    }
    
}
