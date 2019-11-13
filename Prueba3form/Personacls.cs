using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba3form
{
    abstract class Personacls
    {
        private string _nombre;
        private string _apellido;
        private int _documento;
        private bool _sexo;
        private int _codmovil;
        private int _movil;

        //constructores

        public Personacls()
        {
            _nombre = "";
            _apellido = "";
            _documento = 0;
            _sexo = true;
            _codmovil = 0;
            _movil = 0;
        }
        public Personacls(string nombre, string apellido, int documento, bool sexo, string direccion, int nro, string barrio, int codfijo,int fijo, int codmovil, int movil)
        {
            _nombre = nombre;
            _apellido = apellido;
            _documento = documento;
            _sexo = sexo;
            _codmovil = codmovil;
            _movil = movil;
        }

        //propiedades
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Documento { get => _documento; set => _documento = value; }
        public bool Sexo { get => _sexo; set => _sexo = value; }
        public int Codmovil { get => _codmovil; set => _codmovil = value; }
        public int Movil { get => _movil; set => _movil = value; }

        //toString Persona
        public string ToStringPersona()
        {
            string mistring = "";
            string mipersona = "";
            if (_sexo == true)
                mipersona = "Masculino";
            else
                mipersona = "Femenino";

            mistring = "Nombre: " + _nombre +
                     "\nApellido: " + _apellido +
                     "\nDocumento: " + _documento +
                     "\nSexo: " + mipersona +
                     "\nTelefono Movil: " + _codmovil + "-" + _movil;

            return mistring;
        }
    }
}
