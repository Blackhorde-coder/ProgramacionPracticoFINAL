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
        Mascotacls [] arraymascotas = new Mascotacls [tam];
        Clientecls[] arrayclientes = new Clientecls[tam];
        bool nuevo;



        public CargarMascotaForm()
        {
            InitializeComponent();
            cargarlalista("cliente");
            cargarcombo(cmbTipo,"tipo_id");
            botonesenable(false);
            cargarlistamascotas("mascota");
        }
        private void CargarMascotaForm_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnGuardar, "GUARDAR");
            toolTip.SetToolTip(btnCancelar, "CANCELAR CAMBIOS");
            toolTip.SetToolTip(btnSalir, "SALIR");
            toolTip.SetToolTip(btnCliente, "CARGAR NUEVO CLIENTE");
            toolTip.SetToolTip(btnActualizarLista, "ACTUALIZAR LISTA DE CLIENTES");
            toolTip.SetToolTip(btnEliminar, "ELIMINAR MASCOTA");
            toolTip.SetToolTip(btnNuevo, "NUEVA MASCOTA");
            toolTip.SetToolTip(btnEditar, "EDITAR MASCOTA");
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            botonesenable(true);
            listMascotas.Enabled = false;
            nuevo = true;
            btnEliminar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            botonesenable(true);
            nuevo = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarcampos();
            botonesenable(false);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (validar() == true)
            {
                Mascotacls m = new Mascotacls();
                m.Nombre1 = txtNombre.Text;
                m.FecNac = dtpFechaNac.Value;
                m.Tipo = cmbTipo.SelectedIndex;
                m.Peso = Convert.ToDouble(txtPeso.Text);
                m.Descripcion = txtDescripcion.Text;
                m.Cliente = arrayclientes[listCliente.SelectedIndex];
                if (rdbHembra.Checked == true)
                    m.Sexo = false;
                else
                    m.Sexo = true;
            //cargar en la basde de datos
            
                if (nuevo == true)
                {
                    string consultasql = "insert into mascota (Nombre,fecha_nac,tipo,sexo,peso,descripcion,cliente_id) values " +
                                          "('" + m.Nombre1 +
                                          "','" + m.FecNac +
                                          "'," + m.Tipo +
                                          "," + m.Sexo +
                                          "," + m.Peso +
                                          ",'" + m.Descripcion +
                                          "'," + m.Cliente.ClienteID + ")";
                    bd.modificarbd(consultasql);
                    cargarlistamascotas("mascota");
                }
                else
                {
                    string consultasql = "Update mascota set " +
                                            "nombre= '" + m.Nombre1 + "'," +
                                            "fecha_nac= '" + m.FecNac + "'," +
                                            "tipo= " + m.Tipo + "," +
                                            "sexo= " + m.Sexo + "," +
                                            "peso= " + m.Peso + "," +
                                            "descripcion= '" + m.Descripcion + "'," +
                                            "cliente_id= " + m.Cliente.ClienteID + " " +
                                            "where id= " + arraymascotas[listMascotas.SelectedIndex].Id;
                    bd.modificarbd(consultasql);
                    cargarlistamascotas("mascota");

                }
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ClienteForm cc = new ClienteForm();
            cc.ShowDialog();
        }
        private void vacunas(int tipom)
        {
            if (tipom == 0)
            {
                groupBox1.Enabled = true;
                checkBoxPanleucopenia.Enabled = false;
                checkBoxInfluenza.Enabled = false;
                checkBoxLeucemia.Enabled = false;
                checkBoxClamidiosis.Enabled = false;
                checkBoxMoquillo.Enabled = true;
                checkBoxHepatitis.Enabled = true;
                checkBoxLeptospirosis.Enabled = true;
                checkBoxParvovirosis.Enabled = true;
            }
            else if (tipom == 1)
            {
                groupBox1.Enabled = true;
                checkBoxMoquillo.Enabled = false;
                checkBoxHepatitis.Enabled = false;
                checkBoxLeptospirosis.Enabled = false;
                checkBoxParvovirosis.Enabled = false;
                checkBoxPanleucopenia.Enabled = true;
                checkBoxInfluenza.Enabled = true;
                checkBoxLeucemia.Enabled = true;
                checkBoxClamidiosis.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }

        }

        private void limpiarcampos()
        {
            txtDescripcion.Text = "";
            txtNombre.Text = "";
            cmbTipo.SelectedIndex = -1;
            dtpFechaNac.Value = DateTime.Today;
            rdbMacho.Checked = false;
            rdbHembra.Checked = false;
            txtPeso.Text = "";
            listCliente.SelectedIndex = -1;


        }
        private void cargarlalista(string nombretabla)
        {
            bd.leertabla(nombretabla);
            int c = 0;
            while (bd.Reader.Read())
            {
                Clientecls cli = new Clientecls();
                if(!bd.Reader.IsDBNull(0))
                    cli.ClienteID = bd.Reader.GetInt32(0);
                if (!bd.Reader.IsDBNull(1))
                    cli.Nombre = bd.Reader.GetString(1);
                if (!bd.Reader.IsDBNull(2))
                    cli.Apellido = bd.Reader.GetString(2);
                if (!bd.Reader.IsDBNull(3))
                    cli.Documento = bd.Reader.GetInt32(3);
                if (!bd.Reader.IsDBNull(4))
                    cli.Sexo = bd.Reader.GetBoolean(4);
                if (!bd.Reader.IsDBNull(5))
                    cli.Direccion1 = bd.Reader.GetString(5);
                if (!bd.Reader.IsDBNull(6))
                    cli.Barrio1 = bd.Reader.GetString(6);
                if (!bd.Reader.IsDBNull(7))
                    cli.Codfijo1 = bd.Reader.GetInt32(7);
                if (!bd.Reader.IsDBNull(8))
                    cli.Fijo1 = bd.Reader.GetInt32(8);
                if (!bd.Reader.IsDBNull(9))
                    cli.Codmovil = bd.Reader.GetInt32(9);
                if (!bd.Reader.IsDBNull(10))
                    cli.Movil = bd.Reader.GetInt32(10);
                arrayclientes[c] = cli;
                c++;
            }
            bd.Reader.Close();
            bd.desconectar();
            listCliente.Items.Clear();
            for (int i = 0; i < c; i++)
            {
                listCliente.Items.Add(arrayclientes[i].Apellido + " " + arrayclientes[i].Nombre);
            }
        }
        private void cargarlistamascotas(string nombretabla)
        {
            bd.leertabla(nombretabla);
            int c = 0;
            while (bd.Reader.Read())
            {
                Mascotacls mas = new Mascotacls();
                Clientecls cli = new Clientecls();
                if(!bd.Reader.IsDBNull(0))
                    mas.Id = bd.Reader.GetInt32(0);
                if (!bd.Reader.IsDBNull(1))
                    mas.Nombre1 = bd.Reader.GetString(1);
                if (!bd.Reader.IsDBNull(2))
                    mas.FecNac = bd.Reader.GetDateTime(2);
                if (!bd.Reader.IsDBNull(3))
                    mas.Tipo = bd.Reader.GetInt32(3);
                if (!bd.Reader.IsDBNull(4))
                    mas.Sexo = bd.Reader.GetBoolean(4);
                if (!bd.Reader.IsDBNull(5))
                    mas.Peso = bd.Reader.GetDouble(5);
                if (!bd.Reader.IsDBNull(6))
                    mas.Descripcion = bd.Reader.GetString(6);
                mas.Cliente = cli;
                if (!bd.Reader.IsDBNull(7))
                    mas.Cliente.ClienteID = bd.Reader.GetInt32(7);
                arraymascotas[c] = mas;
                c++;
            }
            bd.Reader.Close();
            bd.desconectar();
            listMascotas.Items.Clear();
            for (int i = 0; i < c; i++)
            {
                listMascotas.Items.Add(arraymascotas[i].Nombre1 + "  -------  " + arraymascotas[i].Descripcion);
            }

        }
        private void cargarcombo(ComboBox combo, string nomtabla)
        {
            DataTable tb = new DataTable();
            tb = bd.consultartabla(nomtabla);
            combo.DataSource = tb;
            combo.ValueMember = tb.Columns[0].ColumnName;
            combo.DisplayMember = tb.Columns[1].ColumnName;
            combo.SelectedIndex = 0;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnActualizarLista_Click(object sender, EventArgs e)
        {
            cargarlalista("cliente");
        }
        private bool validar()
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("INSERTE EL NOMBRE DE LA MASCOTA PARA PODER IDENTIFICARLA :-)");
                txtNombre.Focus();
                return false;
            }
            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("SELECCIONE TIPO DE MASCOTA");
                cmbTipo.Focus();
                return false;
            }
            if (txtPeso.Text == "")
            {
                MessageBox.Show("INGRESE PESO DE LA MASCOTA");
                txtPeso.Focus();
                return false;
            }
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("AGREGE UNA DESCRIPCION");
                txtDescripcion.Focus();
                return false;
            }
            if (listCliente.SelectedIndex == -1)
            {
                MessageBox.Show("SELECCIONE EL DUEÑO DE LA MASCOTA O AGREGE UNO NUEVO");
                return false;
            }
            if (rdbHembra.Checked == false && rdbMacho.Checked == false)
            {
                MessageBox.Show("SELECCIONE SEXO");
                return false;
            }
            else
                return true;
        }
        private void botonesenable(bool f)
        {
            txtNombre.Enabled = f;
            txtDescripcion.Enabled = f;
            txtPeso.Enabled = f;
            btnCancelar.Enabled = f;
            btnGuardar.Enabled = f;
            listCliente.Enabled = f;
            listMascotas.Enabled = f;
            cmbTipo.Enabled = f;
            dtpFechaNac.Enabled = f;
            btnCliente.Enabled = f;
            btnActualizarLista.Enabled = f;
            rdbHembra.Enabled = f;
            rdbMacho.Enabled = f;
            btnEliminar.Enabled = f;

            btnNuevo.Enabled = !f;
            btnSalir.Enabled = !f;
            btnEditar.Enabled = !f;
        }

        private void listMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = arrayclientes.Count(x => x != null);
            if (listMascotas.SelectedIndex != -1)
            {
                int sel = listMascotas.SelectedIndex;
                txtNombre.Text = arraymascotas[sel].Nombre1;
                txtDescripcion.Text = arraymascotas[sel].Descripcion;
                txtPeso.Text =Convert.ToString(arraymascotas[sel].Peso);
                if (arraymascotas[sel].Sexo == true)
                    rdbMacho.Checked = true;
                else
                    rdbHembra.Checked = true;
                dtpFechaNac.Value = arraymascotas[sel].FecNac;
                for (int i = 0; i < c; i++)
                {
                    if (arrayclientes[i].ClienteID == arraymascotas[sel].Cliente.ClienteID)
                        listCliente.SelectedIndex = i;
                }
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
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
            if (listMascotas.SelectedIndex != -1)
            {
                int sel = listMascotas.SelectedIndex;
                string deletesql = "delete from mascota where id= " + arraymascotas[sel].Id;
                bd.modificarbd(deletesql);
                cargarlistamascotas("mascota");
                limpiarcampos();
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            vacunas(cmbTipo.SelectedIndex);
        }

        private void cmbTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            vacunas(cmbTipo.SelectedIndex);
        }
    }
    
}
