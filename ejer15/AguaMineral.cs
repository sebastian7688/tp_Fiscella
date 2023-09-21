using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer15
{
    class AguaMineral : Producto
    {
        public string Origen { get; set; }

        public AguaMineral(string id, string nombre, double litros, double precio, string origen)
            : base(id, nombre, litros, precio)
        {
            Origen = origen;
            Estanteria = 1;
        }
    }
}
