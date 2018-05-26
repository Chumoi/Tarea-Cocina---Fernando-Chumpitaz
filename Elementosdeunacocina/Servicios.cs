using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementosdeunacocina
{
    class Servicios
    {
        public int cantidad;
        public string tamaño;
        public string material;
        public bool servidos;


        public void modificar_comida()
        {
            servidos = true;
        }
    }
}
