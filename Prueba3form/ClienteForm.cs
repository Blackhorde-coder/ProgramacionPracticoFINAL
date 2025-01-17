﻿using System;
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
        Mascotacls[] arraymascotas = new Mascotacls[tam];
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
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnNuevo, "NUEVO CLIENTE");
            toolTip.SetToolTip(btnEditar, "EDITAR CLIENTE");
            toolTip.SetToolTip(btnEliminar, "ELIMINAR REGISTRO");
            toolTip.SetToolTip(btnCancelar, "CANCELAR");
            toolTip.SetToolTip(btnSalir, "SALIR");
            toolTip.SetToolTip(btnGuardar, "GUARDAR CAMBIOS");
            toolTip.SetToolTip(lblInfo, "INSERTE AL MENOS UN TELEFONO");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            activarbotones(false);
            isnew = true;
            listBox1.Enabled = false;
            btnEliminar.Enabled = false;
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
            if (validaciones() == true)
            {
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
                if (txtCodFijo.Text == "")
                    cli.Codfijo1 = 0;
                else
                    cli.Codfijo1 = Convert.ToInt32(txtCodFijo.Text);
                if (txtTelFijo.Text == "")
                    cli.Fijo1 = 0;
                else
                    cli.Fijo1 = Convert.ToInt32(txtTelFijo.Text);
                if (txtCodMovil.Text == "")
                    cli.Codmovil = 0;
                else
                    cli.Codmovil = Convert.ToInt32(txtCodMovil.Text);
                if (txtTelMovil.Text == "")
                    cli.Movil = 0;
                else
                    cli.Movil = Convert.ToInt32(txtTelMovil.Text);

                if (validartelefono(cli) == true)
                {
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
                        bd.modificarbd(consultasql);
                        activarbotones(true);
                    }
                    else
                    {
                        consultasql = "update cliente set " +
                                        "nombre='" + cli.Nombre + "'," +
                                        "apellido='" + cli.Apellido + "'," +
                                        "dni=" + cli.Documento + "," +
                                        "sexo=" + cli.Sexo + "," +
                                        "direccion='" + cli.Direccion1 + "'," +
                                        "barrio='" + cli.Barrio1 + "'," +
                                        "cod_area=" + cli.Codfijo1 + "," +
                                        "fijo=" + cli.Fijo1 + "," +
                                        "cod_area_mov=" + cli.Codmovil + "," +
                                        "movil=" + cli.Movil + " " +
                                        "where id= " + arrayclientes[listBox1.SelectedIndex].ClienteID;
                        bd.modificarbd(consultasql);
                        activarbotones(true);
                    }
                    limpiarcampos();
                    cargarlalista("cliente");
                }
                else
                {
                    MessageBox.Show("CORROBORE LOS NUMEROS TELEFONICOS");
                    txtCodFijo.Focus();
                }

            }
        
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
        private bool validaciones()
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("CARGAR NOMBRE");
                txtNombre.Focus();
                return false;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("CARGAR APELLIDO");
                txtApellido.Focus();
                return false;
            }
            if (txtDocumento.Text == "")
            {
                MessageBox.Show("CARGAR DOCUMENTO");
                txtDocumento.Focus();
                return false;
            }
            if (rdbFemenino.Checked == false && rdbMasculino.Checked == false)
            {
                MessageBox.Show("SELECCIONE SEXO");
                return false;
            }
            if ((txtCodFijo.Text != "" && txtTelFijo.Text == "") || (txtTelFijo.Text != "" && txtCodFijo.Text==""))
            {
                MessageBox.Show("INDIQUE CODIGO DE AREA Y TELEFONO");
                txtCodFijo.Focus();
                return false;
            }
            if ((txtCodMovil.Text != "" && txtTelMovil.Text == "") || (txtCodMovil.Text == "" && txtTelMovil.Text != ""))
            {
                MessageBox.Show("INDIQUE CODIGO DE AREA Y TELEFONO");
                txtCodMovil.Focus();
                return false;
            }
            if (txtCodFijo.Text == "" && txtCodMovil.Text == "")
            {
                MessageBox.Show("ES NECESARIO AL MENOS UN TELEFONO");
                txtCodFijo.Focus();
                return false;
            }
            else
                return true;
        }
        private bool validartelefono(Clientecls c)
        {
            if (c.Codfijo1 == 0 && c.Fijo1 == 0 && c.Movil == 0 && c.Codmovil == 0)
                return false;
            if (c.Codfijo1 == 0 && c.Fijo1 != 0 || c.Fijo1 == 0 && c.Codfijo1 != 0)
                return false;
            if (c.Codmovil == 0 && c.Movil != 0 || c.Movil == 0 && c.Codmovil != 0)
                return false;
            else
                return true;
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
            btnEliminar.Enabled = !k;
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
        private void arraymas()
        {
            bd.leertabla("mascota");
            int cm = 0;
            while (bd.Reader.Read())
            {
                Mascotacls m = new Mascotacls();
                m.Id = bd.Reader.GetInt32(0);
                m.Nombre1 = bd.Reader.GetString(1);
                m.FecNac = bd.Reader.GetDateTime(2);
                m.Tipo = bd.Reader.GetInt32(3);
                m.Descripcion = bd.Reader.GetString(4);
                Clientecls c = new Clientecls();
                m.Cliente = c;
                m.Cliente.ClienteID = bd.Reader.GetInt32(5);
                arraymascotas[cm] = m;
                cm++;
            }
            bd.Reader.Close();
            bd.desconectar();

        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = false;
            else if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int sel = listBox1.SelectedIndex;
            arraymas();//llamado al metodo array mascotas
            int c = arraymascotas.Count(x=>x!=null);//contador de elementos del array mascotas
            int f = arrayclientes.Count(x => x != null);//no hace falta

            for (int i = 0; i <c ; i++)
            {
                if (arrayclientes[sel].ClienteID == arraymascotas[i].Cliente.ClienteID)
                {
                    MessageBox.Show("Este cliente tiene la mascota " + arraymascotas[i].Nombre1 + " asociada, elimine primero la mascota para poder eliminar el cliente","CUIDADO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    string eliminar = "Delete from cliente where id= " + arrayclientes[sel].ClienteID;
                    bd.modificarbd(eliminar);
                    cargarlalista("cliente");
                    limpiarcampos();
                }
            }
   
        }
    }
    
}
