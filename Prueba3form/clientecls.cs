using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba3form
{
    class Clientecls:Personacls
    {
        private string _direccion;
        private int _nro;
        private string _barrio;
        private int _codfijo;
        private int _fijo;
        private int _clienteID;
        //constructores
        public Clientecls() : base()
        {
            _direccion = "";
            _nro = 0;
            _barrio = "";
            _codfijo = 0;
            _fijo = 0;
        }
        public Clientecls(int IDCLIENTE, string nombre, string apellido, int documento, bool sexo, string direccion, int nro, string barrio, int codfijo, int fijo, int codmovil, int movil):base( nombre, apellido, documento, sexo, direccion, nro, barrio, codfijo,fijo, codmovil, movil)
        {
            _clienteID = IDCLIENTE;
            _direccion = direccion;
            _nro = nro;
            _barrio = barrio;
            _codfijo = codfijo;
            _fijo = fijo;
        }

        public string Direccion1 { get => _direccion; set => _direccion = value; }
        public int Nro1 { get => _nro; set => _nro = value; }
        public string Barrio1 { get => _barrio; set => _barrio = value; }
        public int Codfijo1 { get => _codfijo; set => _codfijo = value; }
        public int Fijo1 { get => _fijo; set => _fijo = value; }
        public int ClienteID { get => _clienteID; set => _clienteID = value; }

        public string toStringCliente()
        {
            return base.ToStringPersona() +
                     "\nDireccion: " + _direccion + _nro +
                     "\nBarrio: " + _barrio +
                     "\nTelefono Fijo: " + _codfijo + "-" + _fijo;
        }
    }
}
