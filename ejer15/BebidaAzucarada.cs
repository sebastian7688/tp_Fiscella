using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer15
{
    class BebidaAzucarada : Producto
    {
        public string Marca { get; set; }
        public int PorcentajeAzucar { get; set; }
        public bool TienePromocion { get; set; }

        public BebidaAzucarada(string id, string nombre, double litros, double precio, string marca, int porcentajeAzucar, bool tienePromocion)
            : base(id, nombre, litros, precio)
        {
            Marca = marca;
            PorcentajeAzucar = porcentajeAzucar;
            TienePromocion = tienePromocion;
            Estanteria = 2;
        }

        public override double CalcularPrecio()
        {
            double precio = Precio;
            if (TienePromocion)
            {
                precio *= 0.9;
            }
            return precio;
        }

        public override string ToString()
        {
            return base.ToString() + $", Marca: {Marca}, Porcentaje de Azúcar: {PorcentajeAzucar}%, Promoción: {(TienePromocion ? "Sí" : "No")}";
        }
    }
}
