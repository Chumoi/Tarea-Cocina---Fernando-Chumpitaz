using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementosdeunacocina
{
    class bateriacocina: Articulosdecocina
    {
        public void sancochar()
        {
            en_uso = true;
        }
        public void freir()
        {
            en_uso = true;
        }

    }
}
