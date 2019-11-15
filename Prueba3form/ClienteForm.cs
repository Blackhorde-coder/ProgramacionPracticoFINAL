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
        manipulationcls bd = new manipulationcls(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Blackhorde\Documents\GitHub\ProgramacionPracticoFINAL\Prueba3form\TP Programacion ll.mdb");
        const int tam = 1000;
        Clientecls[] arrayclientes = new Clientecls[tam];
        bool isnew;

        public ClienteForm()
        {
            InitializeComponent();
            activarbotones(true);
            cargarlalista("cliente");
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
            isnew = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            activarbotones(false);
            isnew = false;
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
            Clientecls cli = new Clientecls();
            string consultasql;
            cli.Nombre = txtNombre.Text;
            cli.Apellido = txtApellido.Text;
            cli.Documento = Convert.ToInt32(txtDocumento.Text);
            if (rdbFemenino.Checked == true)
                cli.Sexo = false;
            else
                cli.Sexo = true;
            cli.Direccion1 = txtDireccion.Text;
            cli.Barrio1 = txtBarrio.Text;
            cli.Codfijo1 = Convert.ToInt32(txtCodFijo.Text);
            cli.Fijo1 = Convert.ToInt32(txtTelFijo.Text);
            cli.Codmovil = Convert.ToInt32(txtCodMovil.Text);
            cli.Movil = Convert.ToInt32(txtTelMovil.Text);
            if (isnew == true)
            {

                consultasql = "insert into cliente (nombre,apellido,dni,sexo,direccion,barrio,cod_area,fijo,cod_area_mov,movil) values " +
                                        "('" + cli.Nombre +
                                        "','" + cli.Apellido +
                                        "'," + cli.Documento +
                                        "," + cli.Sexo +
                                        ",'" + cli.Direccion1 +
                                        "','" + cli.Barrio1 +
                                        "'," + cli.Codfijo1 +
                                        "," + cli.Fijo1 +
                                        "," + cli.Codmovil +
                                        "," + cli.Movil +
                                        ")";
            }
            else
            {

                consultasql = "update cliente set " +
                                "nombre=" + cli.Nombre +
                                "apellido=" + cli.Apellido +
                                "dni=" + cli.Documento +
                                "sexo=" + cli.Sexo +
                                "direccion=" + cli.Direccion1 +
                                "barrio=" + cli.Barrio1 +
                                "cod_area=" + cli.Codfijo1 +
                                "fijo=" + cli.Fijo1 +
                                "cod_area_mov=" + cli.Codmovil +
                                "movil=" + cli.Movil + " " +
                                "where= " + arrayclientes[listBox1.SelectedIndex].ClienteID;

            }
            bd.modificarbd(consultasql);
            cargarlalista("cliente");


                                  


            activarbotones(true);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sel = listBox1.SelectedIndex;
            if (sel != -1)
            {
                txtNombre.Text = arrayclientes[sel].Nombre;
                txtApellido.Text = arrayclientes[sel].Apellido;
                txtDocumento.Text = Convert.ToString(arrayclientes[sel].Documento);
                txtDireccion.Text = arrayclientes[sel].Direccion1;
                txtBarrio.Text = arrayclientes[sel].Barrio1;
                if (arrayclientes[sel].Sexo == true)
                    rdbMasculino.Checked = true;
                else if (arrayclientes[sel].Sexo == false)
                    rdbFemenino.Checked = true;
                txtCodFijo.Text = Convert.ToString(arrayclientes[sel].Codfijo1);
                txtCodMovil.Text = Convert.ToString(arrayclientes[sel].Codmovil);
                txtTelFijo.Text = Convert.ToString(arrayclientes[sel].Fijo1);
                txtTelMovil.Text = Convert.ToString(arrayclientes[sel].Movil);
            }
            else
            {

            }
        }
        private void validaciones()
        {

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
        private void cargarlalista(string nombretabla)
        {
            bd.leertabla(nombretabla);
            int c = 0;
            while (bd.Reader.Read())
            {
                Clientecls cli = new Clientecls();
                cli.ClienteID = bd.Reader.GetInt32(0);
                cli.Nombre = bd.Reader.GetString(1);
                cli.Apellido = bd.Reader.GetString(2);
                cli.Documento = bd.Reader.GetInt32(3);
                cli.Sexo = bd.Reader.GetBoolean(4);
                cli.Direccion1 = bd.Reader.GetString(5);
                cli.Barrio1 = bd.Reader.GetString(6);
                cli.Codfijo1 = bd.Reader.GetInt32(7);
                cli.Fijo1 = bd.Reader.GetInt32(8);
                cli.Codmovil = bd.Reader.GetInt32(9);
                cli.Movil = bd.Reader.GetInt32(10);
                arrayclientes[c] = cli;
                c++;
            }
            bd.Reader.Close();
            bd.desconectar();
            listBox1.Items.Clear();
            for (int i = 0; i < c; i++)
            {
                listBox1.Items.Add(arrayclientes[i].Apellido + " " + arrayclientes[i].Nombre);
            }
        }


    }
    
}
