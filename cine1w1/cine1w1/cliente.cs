using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine1w1
{
    class cliente
    {
        int codigo;
        string nombre;
        string apellido;
        int documento;
        DateTime fec_nac;
        string direccion;
        int barrio;
        int tipocliente;


        public cliente()
        {
            codigo = 0;
            nombre = "";
            apellido = "";
            documento = 0;
            fec_nac = DateTime.Today;
            direccion = "";
            barrio = 0;
            tipocliente = 0;
        }

        public cliente(int codigo,string nombre,string apellido,int documento,DateTime fec_nac,string direccion,int barrio,int tipocliente)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
            this.fec_nac = fec_nac;
            this.direccion = direccion;
            this.barrio = barrio;
            this.tipocliente = tipocliente;
        }

        public int pCodigo { get {return codigo; } set {codigo=value; } }
        public string pNombre { get { return nombre; } set { nombre = value; } }
        public string pApellido { get { return apellido; } set { apellido = value; } }
        public int pDocumento { get { return documento; } set { documento = value; } }
        public DateTime pFec_Nac { get { return fec_nac; } set { fec_nac = value; } }
        public string pDireccion{ get { return direccion; } set { direccion = value; } }
        public int pBarrio { get { return barrio; } set { barrio = value; } }
        public int pTipoCiente { get { return tipocliente; } set { tipocliente = value; } }


        public string tostring()
        {
            return codigo + ". " + nombre + ", " + apellido + ", " + documento;
        }


    }
}
