using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEstructuraDatos2
{
    public class Producto
    {
        public string nombre;       
        public int codigo;
        public int cantidad;
        public int precio;

        public string Nombre { get { return this.nombre; } set { this.nombre = value.ToUpper(); } }

        public void sumarCantidad(int cantidad)
        {
            this.cantidad += cantidad;
        }

        public void actualizarPrecio(int precio)
        {
            this.precio = precio;   
        }

        public bool validarCantidad(int cantidad)
        {
            bool validado = false;
            if(cantidad <= this.cantidad)
            {              
                 this.cantidad -= cantidad;
                 validado = true;
            }
            return validado;
           
        }

       
    }
}
