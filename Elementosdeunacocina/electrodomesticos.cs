using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementosdeunacocina
{
    class electrodomesticos: Articulosdecocina
    {
        public float energia_electrica;
        public bool encendido;

        public void arrancar()
        {
            encendido = true;
        }
    }
}
