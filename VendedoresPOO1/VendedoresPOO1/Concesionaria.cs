using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendedoresPOO1
{
    public class Concesionaria
    {
        List<Producto> inventario = new List<Producto>();
        List<Vendedor> vendedores = new List<Vendedor>();

        //  METODO QUE COMPRUEBA SI EXISTE UN PRODUCTO
        //  EN LA LISTA INVENTARIO

        public int ComprobarProducto(string modelo)
        {
            int encontro = -1;
            for (int i = 0; i < inventario.Count; i++)
            {
                if (inventario[i].modelo == modelo)
                {
                    encontro = i;
                }
            }
            return encontro;
        }

        //  METODO QUE COMPRUEBA SI EXISTE UN VENDEDOR
        //  EN LA LISTA VENDEDORES

        public int ComprobarVendedor(int cedula)
        {
            int encontro = -1;
            for (int i = 0; i < vendedores.Count; i++)
            {
                if (this.vendedores[i].cedula == cedula)
                {
                    encontro = i;
                }
            }
            return encontro;
        }

        //  REGISTRAR UN PRODUCTO
        public void RegistrarProducto(Producto producto)
        {
            int a = this.ComprobarProducto(producto.modelo);
            if (a >= 0)
            {
                this.inventario[a].SumarCantidad(producto.cantidad);
                this.inventario[a].ActualizarPrecio(producto.precio);
            }
            else
            {
                inventario.Add(producto);
            }
        }

        //  REGISTRO DE LOS VENDEDORES
        public void RegistrarVendedor(Vendedor vendedor)
        {
            int a = this.ComprobarVendedor(vendedor.cedula);
            if (a == -1)
            {
                vendedores.Add(vendedor);
            }
        }

        // VER INVENTARIO
        public string VerProductos()
        {
            string lista = "";
            foreach (Producto item in inventario)
            {
                lista += "MODELO: " + item.modelo + "  PRECIO: " + item.precio + "  CANTIDAD: " + item.cantidad + '\n';
            }
            return lista;
        }

        // VER VENDEDORES
        public string VerVendedores()
        {
            string lista = "";

            foreach (Vendedor item in vendedores)
            {
                lista += "CEDULA: " + item.cedula + "  NOMBRE: " + item.Nombre + "  TOTAL VENDIDO: " + item.totalVendido + '\n';
            }

            return lista;
        }

        public void RealizarVenta(int cedula,string modelo, int cantidad)
        {
            int a = this.ComprobarVendedor(cedula);
            int b = this.ComprobarProducto(modelo);
            if (a >= 0)
            {
                
                if(b >= 0)
                {
                    bool validar = inventario[b].ComprobarCantidad(cantidad);
                    if(validar == true)
                    {
                        int total = inventario[b].precio * cantidad;
                        vendedores[a].AcumularTotal(total);
                        vendedores[a].AgregarVenta(modelo,inventario[b].precio,cantidad);
                    }
                    else if(validar == false)
                    {
                        Console.WriteLine("ERROR! NO HAY UNIDADES REQUERIDAS");
                    }
                }
                else if(b == -1)
                {
                    Console.WriteLine("ERROR! EL MODELO NO ESTA REGISTRADO");
                }
            }else if(a == -1)
            {
                Console.WriteLine("ERROR! EL VENDEDOR NO EXISTE");
            }
            
            
        }

        public void Consultar(int cedula)
        {
            int a = vendedores.FindIndex(v => v.cedula == cedula);

            if (a == -1)
            {
                Console.WriteLine("ERROR! EL VENDEDOR NO EXISTE");
            }
            else if (a >= 0)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("VENTAS DE: " + vendedores[a].Nombre);
                if (vendedores[a].ventas.Count == 0)
                {
                    Console.WriteLine( vendedores[a].Nombre + "  NO TIENE VENTAS :C ");
                }
                else
                {
                    foreach (Producto venta in vendedores[a].ventas)
                    {
                        string lista = "";
                        int tot = venta.precio * venta.cantidad;
                        lista += "MODELO: " + venta.modelo + "  VALOR: " + venta.precio + "  CANTIDAD:" + venta.cantidad + "  TOTAL VENTA:" + tot + '\n';
                        Console.WriteLine(lista);
                    }
                }
            }
        }

    }
}
