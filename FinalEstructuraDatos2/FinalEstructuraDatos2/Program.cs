using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEstructuraDatos2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Vendedor vendedor = new Vendedor(); // CREAMOS EL OBJETO VENDEDOR, EL CUAL CREAMOS PARA PODER USAR LOS METODOS QUE ESTE CONTINE

            while (true)
            {
                Console.Clear();
                Console.WriteLine("---INVENTARIO---");
                Console.WriteLine(vendedor.listarProducto());
                Console.WriteLine("---MENU---");
                Console.WriteLine("1.AGREGAR PRODUCTO");
                Console.WriteLine("2.REGISTRAR VENTA");
               
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                            
                         Producto producto = new Producto();   // SI EL CASO ES 1 TENGO QUE AGREGAR EL METODO DE REGISTRAR PRODUCTO QUE RECIBE UN OBJETO DE TIPO PRODUCTO
                                                               //ENTONCES TENGO QUE INSTANCIAR/CREAR EL PRODUCTO,
                         Console.WriteLine("CODIGO");
                         producto.codigo = int.Parse(Console.ReadLine());
                        if (producto.codigo > 999)
                        {
                            Console.WriteLine("ERROR! CODIGO NO VALIDO!");
                            Console.WriteLine("INTENTA DE NUEVO:");
                            Console.WriteLine("CODIGO");
                            producto.codigo = int.Parse(Console.ReadLine());
                            Console.WriteLine("NOMBRE");
                            producto.Nombre =  Console.ReadLine();
                            Console.WriteLine("CANTIDAD");
                            producto.cantidad = int.Parse(Console.ReadLine());
                            Console.WriteLine("PRECIO");
                            producto.precio = int.Parse(Console.ReadLine());  //DESPUES DE PEDIRLE LOS DATOS AL USUARIO, A TRAVEZ DEL OBJETO(vendedor) DE TIPO Vendedor QUE CREAMOS AL INICIO
                            vendedor.registrarProducto(producto);             //LLAMAMOS AL METODO AGREGAR PRODUCTO QUE CREAMOS EN LA CLASE VENDEDOR
                        }else {
                           
                            Console.WriteLine("NOMBRE");
                            producto.Nombre = Console.ReadLine();
                            Console.WriteLine("CANTIDAD");
                            producto.cantidad = int.Parse(Console.ReadLine());
                            Console.WriteLine("PRECIO");
                            producto.precio = int.Parse(Console.ReadLine());
                            vendedor.registrarProducto(producto);
                        }

                            break;
                        
                        case "2":

                        /*COMO EL METODO REGISTAR VENTA DE LA CLASE VENDEDOR DEVUELVE UN PRODUCTO
                        EN UNA VARIABLE DE TIPO PRODUCTO ALMACENEME LO QUE ME DEVUELVE EL METODO
                        REGISTAR VENTA*/

                        Console.WriteLine("CODIGO");
                        int codigo = int.Parse(Console.ReadLine());
                        Console.WriteLine("CANTIDAD");
                        int cantidad = int.Parse(Console.ReadLine());
                        Producto venta = vendedor.registrarVenta(codigo,cantidad); 
                        break;                  
                }

                Console.WriteLine("CONTINUAR?");
                if(Console.ReadLine() == "NO")
                {
                    break ;
                }             
            }            
           
        }
    }
}
