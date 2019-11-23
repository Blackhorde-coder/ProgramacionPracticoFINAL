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
        private double _peso;
        private string _descripcion;
        private int _id;
        private bool _moquillo;
        private bool _hepatitis;
        private bool _leptospirosis;
        private bool _parvovirus;
        private bool _rabica;
        private bool _panleucopenia;
        private bool _influenza;
        private bool _leucemia;
        private bool _clamidiosis;
        private bool _activo;

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
            _peso = 0;
            _moquillo = false;
            _hepatitis = false;
            _leptospirosis = false;
            _parvovirus = false;
            _rabica = false;
            _panleucopenia = false;
            _influenza = false;
            _leucemia = false;
            _clamidiosis = false;
            _activo = true;
    }
        public Mascotacls(int id,string nombre,DateTime fecNac,int tipo,bool sexo,string descripcion,Clientecls c,double peso,bool a,bool b,bool c2,bool d, bool e, bool f, bool g,bool h,bool i, bool j)
        {
            _id = id;
            _nombre = nombre;
            _fecNac = fecNac;
            _tipo = tipo;
            _sexo = sexo;
            _descripcion = descripcion;
            _cliente = c;
            _peso = peso;
            _moquillo = a;
            _hepatitis = b;
            _leptospirosis = c2;
            _parvovirus = d;
            _rabica = e;
            _panleucopenia = f;
            _influenza = g;
            _leucemia = h;
            _clamidiosis = i;
            _activo = j;
        }

        public string Nombre1 { get => _nombre; set => _nombre = value; }
        public DateTime FecNac { get => _fecNac; set => _fecNac = value; }
        public int Tipo { get => _tipo; set => _tipo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public Clientecls Cliente { get => _cliente; set => _cliente = value; }
        public int Id { get => _id; set => _id = value; }
        public bool Sexo { get => _sexo; set => _sexo = value; }
        public double Peso { get => _peso; set => _peso = value; }
        public bool Moquillo { get => _moquillo; set => _moquillo = value; }
        public bool Hepatitis { get => _hepatitis; set => _hepatitis = value; }
        public bool Leptospirosis { get => _leptospirosis; set => _leptospirosis = value; }
        public bool Parvovirus { get => _parvovirus; set => _parvovirus = value; }
        public bool Rabica { get => _rabica; set => _rabica = value; }
        public bool Panleucopenia { get => _panleucopenia; set => _panleucopenia = value; }
        public bool Influenza { get => _influenza; set => _influenza = value; }
        public bool Leucemia { get => _leucemia; set => _leucemia = value; }
        public bool Clamidiosis { get => _clamidiosis; set => _clamidiosis = value; }
        public bool Activo { get => _activo; set => _activo = value; }

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
