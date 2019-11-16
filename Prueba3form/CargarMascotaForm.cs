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



        public CargarMascotaForm()
        {
            InitializeComponent();
            cargarlalista("cliente");
            cargarcombo(cmbTipo,"tipo_id");
        }
        private void CargarMascotaForm_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnCargar, "CARGAR MASCOTA");
            toolTip.SetToolTip(btnCancelar, "CANCELAR CAMBIOS");
            toolTip.SetToolTip(btnSalir, "SALIR");
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
            //hacer if para que siempre se tenga q seleccionar un cliente
            Mascotacls m = new Mascotacls();
            m.Nombre1 = txtNombre.Text;
            m.FecNac = dtpFechaNac.Value;
            m.Tipo = cmbTipo.SelectedIndex;
            m.Descripcion = txtDescripcion.Text;
            m.Cliente = arrayclientes[listCliente.SelectedIndex];
            //cargar en la basde de datos
            string consultasql = "insert into mascota (Nombre, fecha_nac, tipo, descripcion, cliente_id) values " +
                                  "('" + m.Nombre1 + 
                                  "','" + m.FecNac + 
                                  "'," + m.Tipo +
                                  ",'" + m.Descripcion +
                                  "'," + m.Cliente.ClienteID + ")";
            bd.modificarbd(consultasql);



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
            listCliente.Items.Clear();
            for (int i = 0; i < c; i++)
            {
                listCliente.Items.Add(arrayclientes[i].Apellido + " " + arrayclientes[i].Nombre);
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


    }
}
