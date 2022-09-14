using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendedoresPOO1
{
    public class Producto
    {
        public string modelo;
        public int precio;
        public int cantidad;

        public void SumarCantidad(int cantidad)
        {
            this.cantidad += cantidad;
        }

        public void ActualizarPrecio(int precio)
        {
            this.precio = precio;
        }

        public bool ComprobarCantidad(int cantidad)
        {
            bool comprobar = false;
            if (this.cantidad >= cantidad)
            {
                this.cantidad -= cantidad;
                comprobar = true;
            }
            return comprobar;
        }
    }
}
