namespace Prueba3form
{
    partial class CargarMascotaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargarMascotaForm));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listCliente = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnActualizarLista = new System.Windows.Forms.Button();
            this.rdbMacho = new System.Windows.Forms.RadioButton();
            this.rdbHembra = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.listMascotas = new System.Windows.Forms.ListBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxClamidiosis = new System.Windows.Forms.CheckBox();
            this.checkBoxLeucemia = new System.Windows.Forms.CheckBox();
            this.checkBoxInfluenza = new System.Windows.Forms.CheckBox();
            this.checkBoxPanleucopenia = new System.Windows.Forms.CheckBox();
            this.checkBoxRabia = new System.Windows.Forms.CheckBox();
            this.checkBoxParvovirosis = new System.Windows.Forms.CheckBox();
            this.checkBoxLeptospirosis = new System.Windows.Forms.CheckBox();
            this.checkBoxHepatitis = new System.Windows.Forms.CheckBox();
            this.checkBoxMoquillo = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.rdbInactivo = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxActivo = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGuardar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(288, 321);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 46);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnCargar_Click);
            this.btnGuardar.MouseEnter += new System.EventHandler(this.btnGuardar_MouseEnter);
            this.btnGuardar.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(426, 321);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 46);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.btnCancelar_MouseEnter);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(564, 321);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 46);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btnSalir_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbTipo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(119, 67);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(200, 23);
            this.cmbTipo.TabIndex = 3;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            this.cmbTipo.SelectionChangeCommitted += new System.EventHandler(this.cmbTipo_SelectionChangeCommitted);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNombre.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(119, 15);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDescripcion.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(119, 120);
            this.txtDescripcion.MaxLength = 30;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(200, 22);
            this.txtDescripcion.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "NACIMIENTO";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNac.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight;
            this.dtpFechaNac.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(119, 41);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaNac.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "TIPO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "DESCRIPCION";
            // 
            // listCliente
            // 
            this.listCliente.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listCliente.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCliente.FormattingEnabled = true;
            this.listCliente.ItemHeight = 15;
            this.listCliente.Location = new System.Drawing.Point(63, 8);
            this.listCliente.Name = "listCliente";
            this.listCliente.Size = new System.Drawing.Size(200, 154);
            this.listCliente.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "CLIENTE";
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCliente.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.Location = new System.Drawing.Point(269, 8);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(100, 38);
            this.btnCliente.TabIndex = 13;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            this.btnCliente.MouseEnter += new System.EventHandler(this.btnCliente_MouseEnter);
            this.btnCliente.MouseLeave += new System.EventHandler(this.btnCliente_MouseLeave);
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPeso.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(119, 94);
            this.txtPeso.MaxLength = 8;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(200, 22);
            this.txtPeso.TabIndex = 14;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "PESO";
            // 
            // btnActualizarLista
            // 
            this.btnActualizarLista.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnActualizarLista.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarLista.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarLista.Image")));
            this.btnActualizarLista.Location = new System.Drawing.Point(269, 52);
            this.btnActualizarLista.Name = "btnActualizarLista";
            this.btnActualizarLista.Size = new System.Drawing.Size(100, 38);
            this.btnActualizarLista.TabIndex = 16;
            this.btnActualizarLista.UseVisualStyleBackColor = false;
            this.btnActualizarLista.Click += new System.EventHandler(this.btnActualizarLista_Click);
            this.btnActualizarLista.MouseEnter += new System.EventHandler(this.btnActualizarLista_MouseEnter);
            this.btnActualizarLista.MouseLeave += new System.EventHandler(this.btnActualizarLista_MouseLeave);
            // 
            // rdbMacho
            // 
            this.rdbMacho.AutoSize = true;
            this.rdbMacho.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMacho.Location = new System.Drawing.Point(325, 46);
            this.rdbMacho.Name = "rdbMacho";
            this.rdbMacho.Size = new System.Drawing.Size(73, 19);
            this.rdbMacho.TabIndex = 17;
            this.rdbMacho.TabStop = true;
            this.rdbMacho.Text = "MACHO";
            this.rdbMacho.UseVisualStyleBackColor = true;
            // 
            // rdbHembra
            // 
            this.rdbHembra.AutoSize = true;
            this.rdbHembra.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHembra.Location = new System.Drawing.Point(325, 69);
            this.rdbHembra.Name = "rdbHembra";
            this.rdbHembra.Size = new System.Drawing.Size(79, 19);
            this.rdbHembra.TabIndex = 18;
            this.rdbHembra.TabStop = true;
            this.rdbHembra.Text = "HEMBRA";
            this.rdbHembra.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(346, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "SEXO";
            // 
            // listMascotas
            // 
            this.listMascotas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listMascotas.FormattingEnabled = true;
            this.listMascotas.Location = new System.Drawing.Point(560, 30);
            this.listMascotas.Name = "listMascotas";
            this.listMascotas.Size = new System.Drawing.Size(188, 238);
            this.listMascotas.TabIndex = 20;
            this.listMascotas.SelectedIndexChanged += new System.EventHandler(this.listMascotas_SelectedIndexChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.Location = new System.Drawing.Point(150, 321);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(132, 46);
            this.btnEditar.TabIndex = 32;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            this.btnEditar.MouseEnter += new System.EventHandler(this.btnEditar_MouseEnter);
            this.btnEditar.MouseLeave += new System.EventHandler(this.btnEditar_MouseLeave);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.Location = new System.Drawing.Point(12, 321);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(132, 46);
            this.btnNuevo.TabIndex = 31;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            this.btnNuevo.MouseEnter += new System.EventHandler(this.btnNuevo_MouseEnter);
            this.btnNuevo.MouseLeave += new System.EventHandler(this.btnNuevo_MouseLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(628, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "MASCOTAS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxClamidiosis);
            this.groupBox1.Controls.Add(this.checkBoxLeucemia);
            this.groupBox1.Controls.Add(this.checkBoxInfluenza);
            this.groupBox1.Controls.Add(this.checkBoxPanleucopenia);
            this.groupBox1.Controls.Add(this.checkBoxRabia);
            this.groupBox1.Controls.Add(this.checkBoxParvovirosis);
            this.groupBox1.Controls.Add(this.checkBoxLeptospirosis);
            this.groupBox1.Controls.Add(this.checkBoxHepatitis);
            this.groupBox1.Controls.Add(this.checkBoxMoquillo);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(431, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 282);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VACUNAS";
            // 
            // checkBoxClamidiosis
            // 
            this.checkBoxClamidiosis.AutoSize = true;
            this.checkBoxClamidiosis.Location = new System.Drawing.Point(6, 233);
            this.checkBoxClamidiosis.Name = "checkBoxClamidiosis";
            this.checkBoxClamidiosis.Size = new System.Drawing.Size(107, 19);
            this.checkBoxClamidiosis.TabIndex = 8;
            this.checkBoxClamidiosis.Text = "CLAMIDIOSIS";
            this.checkBoxClamidiosis.UseVisualStyleBackColor = true;
            // 
            // checkBoxLeucemia
            // 
            this.checkBoxLeucemia.AutoSize = true;
            this.checkBoxLeucemia.Location = new System.Drawing.Point(7, 208);
            this.checkBoxLeucemia.Name = "checkBoxLeucemia";
            this.checkBoxLeucemia.Size = new System.Drawing.Size(90, 19);
            this.checkBoxLeucemia.TabIndex = 7;
            this.checkBoxLeucemia.Text = "LEUCEMIA";
            this.checkBoxLeucemia.UseVisualStyleBackColor = true;
            // 
            // checkBoxInfluenza
            // 
            this.checkBoxInfluenza.AutoSize = true;
            this.checkBoxInfluenza.Location = new System.Drawing.Point(6, 183);
            this.checkBoxInfluenza.Name = "checkBoxInfluenza";
            this.checkBoxInfluenza.Size = new System.Drawing.Size(96, 19);
            this.checkBoxInfluenza.TabIndex = 6;
            this.checkBoxInfluenza.Text = "INFLUENZA";
            this.checkBoxInfluenza.UseVisualStyleBackColor = true;
            // 
            // checkBoxPanleucopenia
            // 
            this.checkBoxPanleucopenia.AutoSize = true;
            this.checkBoxPanleucopenia.Location = new System.Drawing.Point(6, 158);
            this.checkBoxPanleucopenia.Name = "checkBoxPanleucopenia";
            this.checkBoxPanleucopenia.Size = new System.Drawing.Size(128, 19);
            this.checkBoxPanleucopenia.TabIndex = 5;
            this.checkBoxPanleucopenia.Text = "PANLEUCOPENIA";
            this.checkBoxPanleucopenia.UseVisualStyleBackColor = true;
            // 
            // checkBoxRabia
            // 
            this.checkBoxRabia.AutoSize = true;
            this.checkBoxRabia.Location = new System.Drawing.Point(6, 133);
            this.checkBoxRabia.Name = "checkBoxRabia";
            this.checkBoxRabia.Size = new System.Drawing.Size(66, 19);
            this.checkBoxRabia.TabIndex = 4;
            this.checkBoxRabia.Text = "RABIA";
            this.checkBoxRabia.UseVisualStyleBackColor = true;
            // 
            // checkBoxParvovirosis
            // 
            this.checkBoxParvovirosis.AutoSize = true;
            this.checkBoxParvovirosis.Location = new System.Drawing.Point(6, 97);
            this.checkBoxParvovirosis.Name = "checkBoxParvovirosis";
            this.checkBoxParvovirosis.Size = new System.Drawing.Size(113, 19);
            this.checkBoxParvovirosis.TabIndex = 3;
            this.checkBoxParvovirosis.Text = "PARVOVIROSIS";
            this.checkBoxParvovirosis.UseVisualStyleBackColor = true;
            // 
            // checkBoxLeptospirosis
            // 
            this.checkBoxLeptospirosis.AutoSize = true;
            this.checkBoxLeptospirosis.Location = new System.Drawing.Point(6, 72);
            this.checkBoxLeptospirosis.Name = "checkBoxLeptospirosis";
            this.checkBoxLeptospirosis.Size = new System.Drawing.Size(117, 19);
            this.checkBoxLeptospirosis.TabIndex = 2;
            this.checkBoxLeptospirosis.Text = "LEPTOSPIROSIS";
            this.checkBoxLeptospirosis.UseVisualStyleBackColor = true;
            // 
            // checkBoxHepatitis
            // 
            this.checkBoxHepatitis.AutoSize = true;
            this.checkBoxHepatitis.Location = new System.Drawing.Point(6, 47);
            this.checkBoxHepatitis.Name = "checkBoxHepatitis";
            this.checkBoxHepatitis.Size = new System.Drawing.Size(128, 19);
            this.checkBoxHepatitis.TabIndex = 1;
            this.checkBoxHepatitis.Text = "HEPATITIS VIRAL";
            this.checkBoxHepatitis.UseVisualStyleBackColor = true;
            // 
            // checkBoxMoquillo
            // 
            this.checkBoxMoquillo.AutoSize = true;
            this.checkBoxMoquillo.Location = new System.Drawing.Point(7, 22);
            this.checkBoxMoquillo.Name = "checkBoxMoquillo";
            this.checkBoxMoquillo.Size = new System.Drawing.Size(92, 19);
            this.checkBoxMoquillo.TabIndex = 0;
            this.checkBoxMoquillo.Text = "MOQUILLO";
            this.checkBoxMoquillo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnActualizarLista);
            this.groupBox2.Controls.Add(this.btnCliente);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.listCliente);
            this.groupBox2.Location = new System.Drawing.Point(56, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 174);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rdbActivo
            // 
            this.rdbActivo.AutoSize = true;
            this.rdbActivo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActivo.Location = new System.Drawing.Point(5, 22);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(51, 19);
            this.rdbActivo.TabIndex = 37;
            this.rdbActivo.TabStop = true;
            this.rdbActivo.Text = "ACT";
            this.rdbActivo.UseVisualStyleBackColor = true;
            this.rdbActivo.CheckedChanged += new System.EventHandler(this.rdbActivo_CheckedChanged);
            // 
            // rdbInactivo
            // 
            this.rdbInactivo.AutoSize = true;
            this.rdbInactivo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInactivo.Location = new System.Drawing.Point(62, 22);
            this.rdbInactivo.Name = "rdbInactivo";
            this.rdbInactivo.Size = new System.Drawing.Size(56, 19);
            this.rdbInactivo.TabIndex = 38;
            this.rdbInactivo.TabStop = true;
            this.rdbInactivo.Text = "INAC";
            this.rdbInactivo.UseVisualStyleBackColor = true;
            this.rdbInactivo.CheckedChanged += new System.EventHandler(this.rdbInactivo_CheckedChanged);
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodos.Location = new System.Drawing.Point(124, 22);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(67, 19);
            this.rdbTodos.TabIndex = 39;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "TODOS";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.rdbTodos_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbActivo);
            this.groupBox3.Controls.Add(this.rdbTodos);
            this.groupBox3.Controls.Add(this.rdbInactivo);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(559, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(193, 46);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FILTRO";
            // 
            // checkBoxActivo
            // 
            this.checkBoxActivo.AutoSize = true;
            this.checkBoxActivo.Location = new System.Drawing.Point(323, 97);
            this.checkBoxActivo.Name = "checkBoxActivo";
            this.checkBoxActivo.Size = new System.Drawing.Size(65, 17);
            this.checkBoxActivo.TabIndex = 9;
            this.checkBoxActivo.Text = "ACTIVO";
            this.checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // CargarMascotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(764, 371);
            this.Controls.Add(this.checkBoxActivo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.listMascotas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rdbHembra);
            this.Controls.Add(this.rdbMacho);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(780, 410);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(780, 410);
            this.Name = "CargarMascotaForm";
            this.Text = "CARGAR MASCOTA";
            this.TransparencyKey = System.Drawing.Color.Beige;
            this.Load += new System.EventHandler(this.CargarMascotaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnActualizarLista;
        private System.Windows.Forms.RadioButton rdbMacho;
        private System.Windows.Forms.RadioButton rdbHembra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listMascotas;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxPanleucopenia;
        private System.Windows.Forms.CheckBox checkBoxRabia;
        private System.Windows.Forms.CheckBox checkBoxParvovirosis;
        private System.Windows.Forms.CheckBox checkBoxLeptospirosis;
        private System.Windows.Forms.CheckBox checkBoxHepatitis;
        private System.Windows.Forms.CheckBox checkBoxMoquillo;
        private System.Windows.Forms.CheckBox checkBoxClamidiosis;
        private System.Windows.Forms.CheckBox checkBoxLeucemia;
        private System.Windows.Forms.CheckBox checkBoxInfluenza;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbActivo;
        private System.Windows.Forms.RadioButton rdbInactivo;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxActivo;
    }
}