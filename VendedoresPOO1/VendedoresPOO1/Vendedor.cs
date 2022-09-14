using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendedoresPOO1
{
    public class Vendedor
    {
        public int cedula;
        private string nombre;
        public string Nombre { get { return nombre; } set { nombre = value.ToUpper(); } }
        public int totalVendido;
        public List<Producto> ventas = new List<Producto> ();
        
        public void AcumularTotal(int venta)
        {
            totalVendido += venta;
        }
        public void AgregarVenta(string modelo, int precio, int cantidad)
        {
            ventas.Add(new Producto() { modelo = modelo, precio = precio, cantidad = cantidad });
        }
    }
}
