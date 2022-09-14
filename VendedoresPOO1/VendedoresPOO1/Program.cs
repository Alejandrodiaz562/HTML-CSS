using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendedoresPOO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Concesionaria concesionaria = new Concesionaria();
           
            
            while (true)
            {
                Console.WriteLine("---INVENTARIO---");
                Console.WriteLine("");
                Console.WriteLine(concesionaria.VerProductos());
                Console.WriteLine("---VENDEDORES---");
                Console.WriteLine("");
                Console.WriteLine(concesionaria.VerVendedores());

                Console.WriteLine("---MENU---");
                Console.WriteLine("1.AGREGAR ARTICULO");
                Console.WriteLine("2.AGREGAR VENDEDOR");
                Console.WriteLine("3.HACER UNA VENTA");
                Console.WriteLine("4.VER VENTAS POR VENDEDOR");
                try
                {
                    int opcion = int.Parse(Console.ReadLine());
  
                    switch (opcion)
                    {
                        case 1:
                            Producto producto = new Producto();
                            Console.WriteLine("---AGREGAR UN PRODUCTO---");
                            Console.WriteLine("");
                            Console.WriteLine("MODELO");
                            producto.modelo = Console.ReadLine();
                            Console.WriteLine("PRECIO");
                            producto.precio = int.Parse(Console.ReadLine());
                            Console.WriteLine("CANTIDAD");
                            producto.cantidad = int.Parse(Console.ReadLine());
                            concesionaria.RegistrarProducto(producto);
                            break;

                        case 2:
                            Vendedor vendedor = new Vendedor();
                            Console.WriteLine("---AGREGAR VENDEDOR---");
                            Console.WriteLine("");
                            Console.WriteLine("CEDULA");
                            vendedor.cedula = int.Parse(Console.ReadLine());
                            Console.WriteLine("NOMBRE");
                            vendedor.Nombre = Console.ReadLine();
                            concesionaria.RegistrarVendedor(vendedor);
                            break;

                        case 3:
                            Console.WriteLine("---REALIZAR VENTA---");
                            Console.WriteLine("CEDULA VENDEDOR");
                            int cedula = int.Parse(Console.ReadLine());
                            Console.WriteLine("MODELO A VENDER");
                            string modelo = Console.ReadLine();
                            Console.WriteLine("CANTIDAD DESEADA");
                            int cantidad = int.Parse(Console.ReadLine());
                            concesionaria.RealizarVenta(cedula, modelo, cantidad);
                         

                            break;

                        case 4:
                            Console.WriteLine("---CONSULATAR VENTAS POR VENDEDOR---");
                            Console.WriteLine("CEDULA");
                            int cedula1 = int.Parse(Console.ReadLine());
                            concesionaria.Consultar(cedula1);
                            Console.WriteLine("PRESIONA ENTER PARA VOLVER AL MENU");
                            Console.ReadKey();
                            break;
                    }
                  
                }
                catch (FormatException ex) { }
                Console.Clear();


            }


        }
    }
}
