using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementosdeunacocina
{
    class Articulosdecocina
    {
        public string tamaño;
        public string marca;
        public string material;
        public bool en_uso;

        public void cocinar()
        {
            en_uso = true;
        }
    }
}
