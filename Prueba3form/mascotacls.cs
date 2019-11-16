using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba3form
{
    class Mascotacls
    {
        private Clientecls _cliente;
        private string _nombre;
        private DateTime _fecNac;
        private int _tipo;
        private bool _sexo;
        private string _descripcion;
        private int _id;
        //constructores 
        public Mascotacls()
        {
            _id = 0;
            _nombre = "";
            _fecNac = DateTime.Today;
            _tipo = 0;
            _sexo = true;
            _descripcion = "";
            _cliente = null;
        }
        public Mascotacls(int id, string nombre, DateTime fecNac, int tipo, bool sexo, string descripcion, Clientecls c)
        {
            _id = id;
            _nombre = nombre;
            _fecNac = fecNac;
            _tipo = tipo;
            _sexo = sexo;
            _descripcion = descripcion;
            _cliente = c;
        }

        public string Nombre1 { get => _nombre; set => _nombre = value; }
        public DateTime FecNac { get => _fecNac; set => _fecNac = value; }
        public int Tipo { get => _tipo; set => _tipo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public Clientecls Cliente { get => _cliente; set => _cliente = value; }
        public int Id { get => _id; set => _id = value; }
        public bool Sexo { get => _sexo; set => _sexo = value; }

        //to string mascotas
        public string toStringMascota()
        {
            return "Nombre: " + _nombre +
                   "\nFecha de Nacimiento: " + _fecNac +
                   "\nTipo: " + tipoanimal() +
                   "\nDescripcion: " + _descripcion +
                   "\nDatos del Cliente(Dueño): " + _cliente.toStringCliente();
        }

        public string tipoanimal()
        {
            string a = "";
            switch(_tipo)
            {
                case 1: a = "Perro";
                    break;
                case 2: a = "Gato";
                    break;
                case 3: a = "Lombriz";
                        break;
                case 4: a = "Pez";
                    break;
                case 5: a = "Ave";
                    break;
            }
            return a;
        }
    }
}
