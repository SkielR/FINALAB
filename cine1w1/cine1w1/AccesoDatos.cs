using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace cine1w1
{
    class AccesoDatos
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;
        DataTable tabla;
        string cadenaConexion;

        public AccesoDatos()
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            lector = null;
            tabla = new DataTable();
            cadenaConexion = "";

        }

        public AccesoDatos(string cadenaConexion)
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            lector = null;
            tabla = new DataTable();
            this.cadenaConexion = cadenaConexion;
        }

        public string pCadenaConexion { get { return cadenaConexion; } set { cadenaConexion = value; } }
        public SqlDataReader pLector { get { return lector; } set { lector = value; } }

        public void conectar()
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        public void desconectar()
        {
            conexion.Close();
            conexion.Dispose();
        }

        public DataTable consultarTabla(string nombreTabla)
        {
            tabla = new DataTable();
            conectar();
            comando.CommandText = "select * from " + nombreTabla;
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }

        public DataTable consultar(string sql)
        {
            tabla = new DataTable();
            conectar();
            comando.CommandText = sql;
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }

        public void leerTabla(string nombreTabla)
        {
            conectar();
            comando.CommandText = "select * from " + nombreTabla;
            lector = comando.ExecuteReader();
        }

        public void actualizarBD(string consultaSQL)
        {
            conectar();
            comando.CommandText = consultaSQL;
            comando.ExecuteNonQuery();
            desconectar();
        }

    }
}
