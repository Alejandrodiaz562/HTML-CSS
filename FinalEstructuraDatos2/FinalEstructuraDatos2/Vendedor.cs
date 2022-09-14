using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEstructuraDatos2
{
    public class Vendedor
    {   
        List<Producto> inventario = new List<Producto>();
        List<int> ventas = new List<int>();
      

        public int validarProducto(int codigo)
        {
            int encontro = -1;
            for(int i = 0; i < inventario.Count; i++)
            {
                if(this.inventario[i].codigo == codigo)
                {
                    encontro = i;
                }
            }
            return encontro;
        }
        public void registrarProducto(Producto producto)
        {   
            int a = this.validarProducto(producto.codigo); 
            
            if(a >= 0)
            {
                this.inventario[a].sumarCantidad(producto.cantidad);
                this.inventario[a].actualizarPrecio(producto.precio);
               
            }
            else if(this.inventario.Count < 3)
            {
                inventario.Add(producto);
            }     
        }

        public Producto registrarVenta(int codigo, int cantidad)
        {
           int a = this.validarProducto(codigo);
            if(a >= 0)
            {
              
                int b = 0;
                string nombreProducto;
                bool validar = this.inventario[a].validarCantidad(cantidad);
                if(validar == true)
                {
                    b = this.inventario[a].precio * cantidad;
                    nombreProducto = this.inventario[a].Nombre;
                    Console.WriteLine("---------------");
                    Console.WriteLine("FACTURA");
                    Console.WriteLine("Producto: " + nombreProducto + "  Cantidad: " + cantidad);
                    Console.WriteLine("TOTAL:" + b + " PESOS");
                    Console.WriteLine("---------------");
                }else if(validar == false)
                {
                   Console.WriteLine("NO HAY EN STOCK"); 
                }
                
                ventas.Add(b);
                int total = 0;
                foreach (int item in ventas)
                {                  
                    total += item;                 
                }
                Console.WriteLine("LAS VENTAS HASTA EL MOMENTO SON DE: " + total + " PESOS");                
                Console.WriteLine("---------------");
                return this.inventario[a];

            }
            else { Console.WriteLine("¡CODIGO NO ENCONTRADO!"); }
            return null;
        }      
                     
        public string listarProducto()
        {
            string lista = "";

            foreach (Producto item in this.inventario)
            {
                lista +="CODIGO:" +item.codigo + "  NOMBRE: " + item.Nombre + "  CANTIDAD: "  + item.cantidad + "  PRECIO " + item.precio + '\n';
            }

            return lista;
        }

    }
}
