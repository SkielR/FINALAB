using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cine1w1
{
    public partial class Form1 : Form
    {
        AccesoDatos ac = new AccesoDatos(@"Data Source=DESKTOP-9KL61KT;Initial Catalog=Cine1w1r;Integrated Security=True");
        const int tam = 100;
        cliente[] arreglo = new cliente[tam];
        int contador;
        bool bandera;

        public Form1()
        {
            InitializeComponent();
            contador = 0;
            bandera = false;
            for (int i = 0; i < tam; i++)
            {
                arreglo[i] = null;
            }
        }

        private void btnConsulta1_Click(object sender, EventArgs e)
        {
            string consulta1 = "select count(*)'cantidad',year(fecha) año, cli.cod_cliente 'codigo',nombre+''+apellido 'nombre completo' From comprobantes c join clientes cli on c.cod_cliente = cli.cod_cliente Group by year(fecha),cli.cod_cliente,nombre + '' + apellido";
            dgwCine.DataSource = ac.consultar(consulta1);
        }

        private void btnConsulta2_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                string consulta2 = "Select id_funcion,dia,p.cod_pelicula,nombre 'pelicula',funcion From peliculas p join funciones f on p.cod_pelicula = f.cod_pelicula right join dias d on d.id_dia = f.id_dia Where dia='" + textBox3.Text + "'";
                dgwCine.DataSource = ac.consultar(consulta2);

            }

        }

        private void btnConsulta3_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                string consulta3 = "Select c.cod_cliente 'codigo', nombre+''+apellido 'nombre', sum (monto) 'monto total', min(monto) 'monto minimo', max (monto) 'monto maximo' From clientes c join comprobantes co on c.cod_cliente = co.cod_cliente join detalles_comprobantes d on d.cod_comprobante = co.cod_comprobante Group by c.cod_cliente, nombre + '' + apellido Having sum (monto) between'" + txtqui.Text + "'and'" + txtdosm.Text + "'";
                dgwCine.DataSource = ac.consultar(consulta3);
            }
        }

        private void btnConsulta4_Click(object sender, EventArgs e)
        {
            string consulta4 = "Select c.cod_cliente 'codigo', nombre+''+apellido 'nombre','compradores' tipo From clientes c, comprobantes co Where c.cod_cliente = co.cod_cliente and month (fecha) between '" + txtmayo.Text + "'and'" +txtjunio.Text +"'and year(fecha) =" + txtAño2019.Text + "union Select cod_cliente, nombre + '' + apellido, 'clientes' tipo From clientes Order by 3 asc";
            dgwCine.DataSource = ac.consultar(consulta4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string consulta5 = "Select distinct c.cod_cliente codigo, c.nombre+' '+c.apellido 'Cliente', co.fecha, dc.monto, fp.forma   From clientes c join comprobantes co on c.cod_cliente = co.cod_cliente join detalles_comprobantes dc on co.cod_comprobante = dc.cod_comprobante join FORMAS_PAGOS fp on fp.id_pago = co.id_pago Where'" + txtDos.Text + "'< (Select sum(monto) From detalles_comprobantes dc1 join comprobantes co1 on dc1.cod_comprobante = co1.cod_comprobante join formas_pagos fp1 on fp1.id_pago = co1.id_pago Where co.cod_comprobante = dc1.cod_comprobante and month(fecha)between'" + txtCuatro.Text + "'and'" + txtSiete.Text + "' and year(fecha) = year(getdate())) and co.id_pago='" + txtUno.Text + "'";
            dgwCine.DataSource = ac.consultar(consulta5);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string consulta6 = "Select c.cod_cliente codigo, c.nombre+' '+c.apellido 'Cliente', b.barrio,sum(dc.monto) monto From clientes c join comprobantes co on c.cod_cliente = co.cod_cliente join detalles_comprobantes dc on co.cod_comprobante = dc.cod_comprobante join barrios b on b.id_barrio = c.id_barrio Where b.barrio = '" + txtObservatorio.Text + "'Group by c.cod_cliente, c.nombre + ' ' + c.apellido, b.barrio Having avg(monto) > (Select avg(monto) From detalles_comprobantes)";
            dgwCine.DataSource = ac.consultar(consulta6);
        }

        private void lstCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCampo(lstCliente.SelectedIndex);
        }

        public bool existe(int pk)
        {
            for (int i = 0; i < contador; i++)
            {
                if (arreglo[i].pCodigo == pk)
                    return true;
            }
            return false;
        }

        public void cargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable tabla = new DataTable();
            tabla = ac.consultarTabla(nombreTabla);
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedValue = -1;
        }

        public void cargarLista(string nombreTabla)
        {
            contador = 0;
            ac.leerTabla(nombreTabla);
            while (ac.pLector.Read())
            {
                cliente v = new cliente();
                if (!ac.pLector.IsDBNull(0))
                    v.pCodigo = ac.pLector.GetInt32(0);
                if (!ac.pLector.IsDBNull(1))
                    v.pNombre = ac.pLector.GetString(1);
                if (!ac.pLector.IsDBNull(2))
                    v.pApellido = ac.pLector.GetString(2);
                if (!ac.pLector.IsDBNull(3))
                    v.pDocumento = ac.pLector.GetInt32(3);
                if (!ac.pLector.IsDBNull(4))
                    v.pFec_Nac = ac.pLector.GetDateTime(4);
                if (!ac.pLector.IsDBNull(5))
                    v.pDireccion = ac.pLector.GetString(5);
                if (!ac.pLector.IsDBNull(6))
                    v.pTipoCiente = ac.pLector.GetInt32(6);
                if (!ac.pLector.IsDBNull(7))
                    v.pBarrio = ac.pLector.GetInt32(7);
                arreglo[contador] = v;
                contador++;
            }
            ac.pLector.Close();
            ac.desconectar();
            lstCliente.Items.Clear();
            for (int i = 0; i < contador; i++)
            {
                lstCliente.Items.Add(arreglo[i].tostring());
            }
            lstCliente.SelectedIndex = lstCliente.Items.Count - 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            habilitar(false);
            cargarLista("CLIENTES");
            cargarCombo(cboTipoCliente, "TIPOS_CLIENTES");
            cargarCombo(cboBarrio, "BARRIOS");
            cargarCombo(cboDias, "DIAS");
            cargarCombo(cboGenero, "GENEROS");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir"
        , "SALIR"
        , MessageBoxButtons.YesNo
        , MessageBoxIcon.Question
        , MessageBoxDefaultButton.Button2)
    == DialogResult.No)
                e.Cancel = true;
        }

        public void cargarCampo(int pos)
        {
            txtCodigo.Text = arreglo[pos].pCodigo.ToString();
            txtNombre.Text = arreglo[pos].pNombre;
            txtApellido.Text = arreglo[pos].pApellido;
            txtDocumento.Text = arreglo[pos].pDireccion.ToString();
            dtpFecNac.Value = arreglo[pos].pFec_Nac;
            txtDireccion.Text = arreglo[pos].pDireccion;
            cboTipoCliente.SelectedValue = arreglo[pos].pTipoCiente;
            cboBarrio.SelectedValue = arreglo[pos].pBarrio;
        }

        public void habilitar(bool h)
        {
            btnNuevo.Enabled = !h;
            btnSalir.Enabled = !h;
            lstCliente.Enabled = !h;
            btnEditar.Enabled = !h;
            btnBorrar.Enabled = !h;


            btnCancelar.Enabled = h;
            btnGrabar.Enabled = h;
            txtCodigo.Enabled = h;
            txtNombre.Enabled = h;
            txtApellido.Enabled = h;
            txtDocumento.Enabled = h;
            txtDireccion.Enabled = h;
            dtpFecNac.Enabled = h;
            cboBarrio.Enabled = h;
            cboTipoCliente.Enabled = h;
        }


        public void limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDocumento.Clear();
            txtDireccion.Clear();
            dtpFecNac.Value = DateTime.Today;
            cboBarrio.SelectedValue = -1;
            cboTipoCliente.SelectedValue = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitar(false);
            bandera = false;
            cargarCampo(lstCliente.SelectedIndex);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitar(true);
            bandera = true;
            txtCodigo.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                string consultaSQL = "";
                cliente v = new cliente();
                v.pCodigo = Convert.ToInt32(txtCodigo.Text);
                v.pNombre = txtNombre.Text;
                v.pApellido = txtApellido.Text;
                v.pDocumento = Convert.ToInt32(txtDocumento.Text);
                v.pFec_Nac = dtpFecNac.Value;
                v.pDireccion = txtDireccion.Text;
                v.pBarrio = Convert.ToInt32(cboBarrio.SelectedValue);
                v.pTipoCiente = Convert.ToInt32(cboTipoCliente.SelectedValue);

                if (bandera)
                    if (!existe(v.pCodigo))
                    {
                        consultaSQL = "insert into CLIENTES (cod_cliente,nombre,apellido,nro_dni,fec_nac,direccion,cod_tipo_cliente,id_barrio) values (" +
                            v.pCodigo + ",'" +
                            v.pNombre + "','" +
                            v.pApellido + "'," +
                            v.pDocumento + ",'" +
                            v.pFec_Nac + "','" +
                            v.pDireccion + "'," +
                            v.pTipoCiente + "," +
                            v.pBarrio + ")";

                        ac.actualizarBD(consultaSQL);
                        cargarLista("CLIENTES");

                        MessageBox.Show("La carga ha sido exitosa");
                    }
                    else
                    { MessageBox.Show("Ya existe ese codigo"); }
                else
                {
                    consultaSQL = "update CLIENTES set nombre='" + v.pNombre + "',"
                        + "apellido='" + v.pApellido + "',"
                        + "nro_dni=" + v.pDocumento + ","
                        + "fec_nac='" + v.pFec_Nac + "',"
                        + "direccion='" + v.pDireccion + "',"
                        + "cod_tipo_cliente=" + v.pTipoCiente + ","
                        + "id_barrio=" + v.pBarrio + " "
                        + "where cod_cliente=" + v.pCodigo;
                    ac.actualizarBD(consultaSQL);
                    cargarLista("CLIENTES");

                    MessageBox.Show("La edicion ha sido correcta");
                }

                bandera = false;
                habilitar(false);
            }
        }

        public bool validar()
        {
            if(string.IsNullOrEmpty(txtqui.Text))
            {
                MessageBox.Show("Ingrese 500");
                txtqui.Focus();
                return false;
            }

            //else
            //{
            //    try
            //    {
            //        Convert.ToInt32(txtqui.Text);
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Debe ser un numero de codigo valido"
            //            , "ERROR"
            //            , MessageBoxButtons.OK
            //            , MessageBoxIcon.Error);
            //        txtqui.Focus();
            //        return false;
            //    }
            //}

            if (string.IsNullOrEmpty(txtdosm.Text))
            {
                MessageBox.Show("Ingrese 2000");
                txtdosm.Focus();
                return false;
            }

            //else
            //{
            //    try
            //    {
            //        Convert.ToInt32(txtdosm.Text);
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Debe ser un numero de codigo valido"
            //            , "ERROR"
            //            , MessageBoxButtons.OK
            //            , MessageBoxIcon.Error);
            //        txtdosm.Focus();
            //        return false;
            //    }
            //}

            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Ingrese un dia en formato alfabetico");
                textBox3.Focus();
                return false;
            }

            //if (string.IsNullOrEmpty(txtCodigo.Text))
            //{
            //    MessageBox.Show("Ingrese un numero de codigo valido");
            //    txtCodigo.Focus();
            //    return false;
            //}
            //else
            //{
            //    try
            //    {
            //        Convert.ToInt32(txtCodigo.Text);
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Debe ser un numero de codigo valido"
            //            , "ERROR"
            //            , MessageBoxButtons.OK
            //            , MessageBoxIcon.Error);
            //        txtCodigo.Focus();
            //        return false;
            //    }
            //}

            //if (string.IsNullOrEmpty(txtNombre.Text))
            //{
            //    MessageBox.Show("Coloque su nombre");
            //    txtNombre.Focus();
            //    return false;
            //}
            ////else
            ////{
            ////    try
            ////    {
            ////        Convert.ToChar(txtNombre.Text);
            ////    }

            ////    catch
            ////    {
            ////        MessageBox.Show("Debe ingresar letras solamente en su nombre"
            ////            , "ERROR"
            ////            , MessageBoxButtons.OK
            ////            , MessageBoxIcon.Error);
            ////          txtNombre.Focus();
            ////          return false;
            ////    }
            ////}

            //if (txtApellido.Text=="")
            //{
            //    MessageBox.Show("Coloque su apellido");
            //    txtApellido.Focus();
            //    return false;
            //}
            ////else
            ////{
            ////    try
            ////    {
            ////        Convert.ToChar(txtApellido.Text);
            ////    }

            ////    catch
            ////    {
            ////        MessageBox.Show("Debe ingresar letras solamente en apellido"
            ////            , "ERROR"
            ////            , MessageBoxButtons.OK
            ////            , MessageBoxIcon.Error);
            ////        txtApellido.Focus();
            ////        return false;
            ////    }
            ////}

            //if (string.IsNullOrEmpty(txtDocumento.Text))
            //{
            //    MessageBox.Show("Ingrese un numero de documento valido");
            //    txtDocumento.Focus();
            //    return false;
            //}
            //else
            //{
            //    try
            //    {
            //        Convert.ToInt32(txtDocumento.Text);
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Debe ser un numero de documento valido"
            //            , "ERROR"
            //            , MessageBoxButtons.OK
            //            , MessageBoxIcon.Error);
            //        txtDocumento.Focus();
            //        return false;
            //    }
            //}

            //if (dtpFecNac.Value > DateTime.Now)
            //{
            //    MessageBox.Show("Ingrese una fecha no posterior a hoy");
            //    dtpFecNac.Focus();
            //    return false;
            //}

            //if (txtDireccion.Text == "")
            //{
            //    MessageBox.Show("Coloque direccion mas numero");
            //    txtDireccion.Focus();
            //    return false;
            //}

            //if (cboBarrio.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Seleccione un  barrio");
            //    cboBarrio.Focus();
            //    return false;
            //}

            //if (cboTipoCliente.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Seleccione un tipo de cliente");
            //    cboTipoCliente.Focus();
            //    return false;
            //}

            return true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            bandera = false;
            txtCodigo.Enabled = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea borra"
                    , "BORRAR"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Warning
                    , MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                string consultaSQL = "delete from CLIENTES where cod_cliente="
                    + arreglo[lstCliente.SelectedIndex].pCodigo;
                ac.actualizarBD(consultaSQL);
                cargarLista("CLIENTES");

                MessageBox.Show("Se ha borrado correctamente");
                   
            }
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            string consulta7 = null;
            consulta7 = "Select cod_pelicula,nombre, 'pelicula' tipo From peliculas Where nombre like'[" + textBox1.Text +"]%' Union Select id_genero, genero, 'genero' From generos Order by 3 desc";
            dgwCine.DataSource = ac.consultar(consulta7);

            //EJERCICIO 8
        }

        private void btnConsulta8_Click(object sender, EventArgs e)
        {
            string consultaSQL = null;
            consultaSQL = "Select c.cod_cliente 'código de cliente', nombre +' '+ apellido 'cliente', avg (monto) 'promedio total', min (fecha) 'fecha primer comprobante', max(fecha)'fecha ultimo comprobante' From clientes c, detalles_comprobantes d, comprobantes co Where c.cod_cliente = co.cod_cliente and d.cod_comprobante = co.cod_comprobante Group by c.cod_cliente, nombre + ' ' + apellido 	Having avg(monto) >'" + textBox2.Text +"'";
            dgwCine.DataSource = ac.consultar(consultaSQL);

            //EJERCICIO 12
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }



    }
}
