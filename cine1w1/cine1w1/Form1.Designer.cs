namespace cine1w1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgwCine = new System.Windows.Forms.DataGridView();
            this.btnConsulta1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsulta2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConsulta3 = new System.Windows.Forms.Button();
            this.txtqui = new System.Windows.Forms.TextBox();
            this.txtdosm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConsulta4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConsulta5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmayo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtjunio = new System.Windows.Forms.TextBox();
            this.txtDos = new System.Windows.Forms.TextBox();
            this.txtCuatro = new System.Windows.Forms.TextBox();
            this.txtSiete = new System.Windows.Forms.TextBox();
            this.txtUno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnConsulta6 = new System.Windows.Forms.Button();
            this.lstCliente = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.dtpFecNac = new System.Windows.Forms.DateTimePicker();
            this.cboTipoCliente = new System.Windows.Forms.ComboBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtObservatorio = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.cboDias = new System.Windows.Forms.ComboBox();
            this.btnSiete = new System.Windows.Forms.Button();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAño2019 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnConsulta8 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCine)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCine
            // 
            this.dgwCine.AllowUserToOrderColumns = true;
            this.dgwCine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCine.Location = new System.Drawing.Point(1, 1);
            this.dgwCine.Name = "dgwCine";
            this.dgwCine.Size = new System.Drawing.Size(450, 290);
            this.dgwCine.TabIndex = 0;
            // 
            // btnConsulta1
            // 
            this.btnConsulta1.Location = new System.Drawing.Point(1, 351);
            this.btnConsulta1.Name = "btnConsulta1";
            this.btnConsulta1.Size = new System.Drawing.Size(71, 27);
            this.btnConsulta1.TabIndex = 14;
            this.btnConsulta1.Text = "Consulta 1";
            this.btnConsulta1.UseVisualStyleBackColor = true;
            this.btnConsulta1.Click += new System.EventHandler(this.btnConsulta1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(539, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "En esta consulta vamos a listar la cantidad de facturas o ventas por cliente por " +
    "año, agrupados por año y cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aquí en esta consulta vamos a listar las peliculas del dia viernes y funcion (inc" +
    "luso para aquellas que no tienen funcion)";
            // 
            // btnConsulta2
            // 
            this.btnConsulta2.Location = new System.Drawing.Point(-3, 422);
            this.btnConsulta2.Name = "btnConsulta2";
            this.btnConsulta2.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta2.TabIndex = 15;
            this.btnConsulta2.Text = "Consulta 2";
            this.btnConsulta2.UseVisualStyleBackColor = true;
            this.btnConsulta2.Click += new System.EventHandler(this.btnConsulta2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1094, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // btnConsulta3
            // 
            this.btnConsulta3.Location = new System.Drawing.Point(-3, 464);
            this.btnConsulta3.Name = "btnConsulta3";
            this.btnConsulta3.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta3.TabIndex = 17;
            this.btnConsulta3.Text = "Consulta 3";
            this.btnConsulta3.UseVisualStyleBackColor = true;
            this.btnConsulta3.Click += new System.EventHandler(this.btnConsulta3_Click);
            // 
            // txtqui
            // 
            this.txtqui.Location = new System.Drawing.Point(101, 466);
            this.txtqui.Name = "txtqui";
            this.txtqui.Size = new System.Drawing.Size(100, 20);
            this.txtqui.TabIndex = 18;
            // 
            // txtdosm
            // 
            this.txtdosm.Location = new System.Drawing.Point(249, 467);
            this.txtdosm.Name = "txtdosm";
            this.txtdosm.Size = new System.Drawing.Size(100, 20);
            this.txtdosm.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 494);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1077, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // btnConsulta4
            // 
            this.btnConsulta4.Location = new System.Drawing.Point(1, 510);
            this.btnConsulta4.Name = "btnConsulta4";
            this.btnConsulta4.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta4.TabIndex = 20;
            this.btnConsulta4.Text = "Consulta 4";
            this.btnConsulta4.UseVisualStyleBackColor = true;
            this.btnConsulta4.Click += new System.EventHandler(this.btnConsulta4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 536);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(903, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Aqui listamos los clientes (no repetidos) que hayan adquirido entradas con un mon" +
    "to mayor a 200 durante el segundo trimestre del año en curso. Y que su forma de " +
    "pago haya sido en efectivo";
            // 
            // btnConsulta5
            // 
            this.btnConsulta5.Location = new System.Drawing.Point(1, 552);
            this.btnConsulta5.Name = "btnConsulta5";
            this.btnConsulta5.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta5.TabIndex = 24;
            this.btnConsulta5.Text = "Consulta 5";
            this.btnConsulta5.UseVisualStyleBackColor = true;
            this.btnConsulta5.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 515);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Meses Entre";
            // 
            // txtmayo
            // 
            this.txtmayo.Location = new System.Drawing.Point(171, 510);
            this.txtmayo.Name = "txtmayo";
            this.txtmayo.Size = new System.Drawing.Size(47, 20);
            this.txtmayo.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 515);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Y";
            // 
            // txtjunio
            // 
            this.txtjunio.Location = new System.Drawing.Point(244, 510);
            this.txtjunio.Name = "txtjunio";
            this.txtjunio.Size = new System.Drawing.Size(47, 20);
            this.txtjunio.TabIndex = 22;
            // 
            // txtDos
            // 
            this.txtDos.Location = new System.Drawing.Point(101, 555);
            this.txtDos.Name = "txtDos";
            this.txtDos.Size = new System.Drawing.Size(63, 20);
            this.txtDos.TabIndex = 25;
            // 
            // txtCuatro
            // 
            this.txtCuatro.Location = new System.Drawing.Point(192, 555);
            this.txtCuatro.Name = "txtCuatro";
            this.txtCuatro.Size = new System.Drawing.Size(63, 20);
            this.txtCuatro.TabIndex = 26;
            // 
            // txtSiete
            // 
            this.txtSiete.Location = new System.Drawing.Point(286, 554);
            this.txtSiete.Name = "txtSiete";
            this.txtSiete.Size = new System.Drawing.Size(63, 20);
            this.txtSiete.TabIndex = 27;
            // 
            // txtUno
            // 
            this.txtUno.Location = new System.Drawing.Point(372, 555);
            this.txtUno.Name = "txtUno";
            this.txtUno.Size = new System.Drawing.Size(63, 20);
            this.txtUno.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-2, 578);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1141, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // btnConsulta6
            // 
            this.btnConsulta6.Location = new System.Drawing.Point(1, 594);
            this.btnConsulta6.Name = "btnConsulta6";
            this.btnConsulta6.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta6.TabIndex = 29;
            this.btnConsulta6.Text = "Consulta 6";
            this.btnConsulta6.UseVisualStyleBackColor = true;
            this.btnConsulta6.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstCliente
            // 
            this.lstCliente.FormattingEnabled = true;
            this.lstCliente.Location = new System.Drawing.Point(849, 1);
            this.lstCliente.Name = "lstCliente";
            this.lstCliente.Size = new System.Drawing.Size(342, 303);
            this.lstCliente.TabIndex = 28;
            this.lstCliente.SelectedIndexChanged += new System.EventHandler(this.lstCliente_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(535, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Codigo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(534, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Codigo Barrio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(533, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Direccion";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(533, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Fecha Nacimiento";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(534, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Documento";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(534, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Apellido";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(534, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Nombre";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(533, 278);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Tipo Cliente";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(643, 1);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(643, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(643, 81);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(643, 121);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtDocumento.TabIndex = 3;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(643, 164);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 4;
            // 
            // dtpFecNac
            // 
            this.dtpFecNac.Location = new System.Drawing.Point(643, 201);
            this.dtpFecNac.Name = "dtpFecNac";
            this.dtpFecNac.Size = new System.Drawing.Size(200, 20);
            this.dtpFecNac.TabIndex = 5;
            // 
            // cboTipoCliente
            // 
            this.cboTipoCliente.FormattingEnabled = true;
            this.cboTipoCliente.Location = new System.Drawing.Point(643, 278);
            this.cboTipoCliente.Name = "cboTipoCliente";
            this.cboTipoCliente.Size = new System.Drawing.Size(121, 21);
            this.cboTipoCliente.TabIndex = 7;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(849, 325);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(52, 23);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(907, 326);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(52, 23);
            this.btnGrabar.TabIndex = 9;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1081, 326);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(52, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1139, 326);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(52, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cboBarrio
            // 
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(643, 239);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(121, 21);
            this.cboBarrio.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(114, 599);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 13);
            this.label19.TabIndex = 50;
            this.label19.Text = "Barrio";
            // 
            // txtObservatorio
            // 
            this.txtObservatorio.Location = new System.Drawing.Point(191, 594);
            this.txtObservatorio.Name = "txtObservatorio";
            this.txtObservatorio.Size = new System.Drawing.Size(64, 20);
            this.txtObservatorio.TabIndex = 30;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(965, 326);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(52, 23);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(1023, 326);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(52, 23);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // cboDias
            // 
            this.cboDias.FormattingEnabled = true;
            this.cboDias.Location = new System.Drawing.Point(664, 357);
            this.cboDias.Name = "cboDias";
            this.cboDias.Size = new System.Drawing.Size(100, 21);
            this.cboDias.TabIndex = 54;
            // 
            // btnSiete
            // 
            this.btnSiete.Location = new System.Drawing.Point(-3, 682);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(75, 23);
            this.btnSiete.TabIndex = 55;
            this.btnSiete.Text = "Consulta 7";
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.Click += new System.EventHandler(this.btnSiete_Click);
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(227, 682);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(121, 21);
            this.cboGenero.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(336, 517);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Año en curso";
            // 
            // txtAño2019
            // 
            this.txtAño2019.Location = new System.Drawing.Point(413, 511);
            this.txtAño2019.Name = "txtAño2019";
            this.txtAño2019.Size = new System.Drawing.Size(100, 20);
            this.txtAño2019.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 682);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 59;
            // 
            // btnConsulta8
            // 
            this.btnConsulta8.Location = new System.Drawing.Point(-3, 721);
            this.btnConsulta8.Name = "btnConsulta8";
            this.btnConsulta8.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta8.TabIndex = 60;
            this.btnConsulta8.Text = "Consulta 8";
            this.btnConsulta8.UseVisualStyleBackColor = true;
            this.btnConsulta8.Click += new System.EventHandler(this.btnConsulta8_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 721);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 61;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(101, 425);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 16;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 772);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnConsulta8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtAño2019);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.cboDias);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtObservatorio);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cboBarrio);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.cboTipoCliente);
            this.Controls.Add(this.dtpFecNac);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lstCliente);
            this.Controls.Add(this.btnConsulta6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUno);
            this.Controls.Add(this.txtSiete);
            this.Controls.Add(this.txtCuatro);
            this.Controls.Add(this.txtDos);
            this.Controls.Add(this.txtjunio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtmayo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnConsulta5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnConsulta4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdosm);
            this.Controls.Add(this.txtqui);
            this.Controls.Add(this.btnConsulta3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConsulta2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsulta1);
            this.Controls.Add(this.dgwCine);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCine;
        private System.Windows.Forms.Button btnConsulta1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsulta2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConsulta3;
        private System.Windows.Forms.TextBox txtqui;
        private System.Windows.Forms.TextBox txtdosm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConsulta4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConsulta5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmayo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtjunio;
        private System.Windows.Forms.TextBox txtDos;
        private System.Windows.Forms.TextBox txtCuatro;
        private System.Windows.Forms.TextBox txtSiete;
        private System.Windows.Forms.TextBox txtUno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnConsulta6;
        private System.Windows.Forms.ListBox lstCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.DateTimePicker dtpFecNac;
        private System.Windows.Forms.ComboBox cboTipoCliente;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cboBarrio;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtObservatorio;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox cboDias;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAño2019;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnConsulta8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

