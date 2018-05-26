using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementosdeunacocina
{
    class Comestibles
    {
        public string nombre;
        public int cantidad;
        public string tamaño;
        public string sabor;
        public bool en_plato;

        public void llenar_plato()
        {
         en_plato =true;
        }
        public Comestibles(string nombre1, int cantidad1)
        {
            nombre = nombre1;
            cantidad = cantidad1;

        }
    }
}
