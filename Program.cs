using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Ejercicio 1: Sistema de Inventario
                Crea una clase Producto con las propiedades Nombre, Categoria y Precio. ****
                Luego, en tu programa principal, crea una lista de Producto.
                Permite al usuario agregar varios productos a la lista, ingresando los valores por teclado.
                Crea una función para mostrar todos los productos en la lista.
                Sumar el total por compra
            */

            List<Productos> ListaProductos = new List<Productos>();
            int CantidadProductos, opcion;

            Console.WriteLine("Ingrese la cantidad de productos: ");
            CantidadProductos = int.Parse(Console.ReadLine());


            Console.WriteLine("\n");
            Console.WriteLine("Opcion de Menu para lista de productos");
            Console.WriteLine("1)Carga de productos");
            Console.WriteLine("2)Visualizacion de los productos cargados");
            Console.WriteLine("3)Busqueda por codigo de producto");
            Console.WriteLine("4)Total de la compra");
            Console.WriteLine("5)Eliminar articulos de la lista");
            Console.WriteLine("6)Salir");
            Console.WriteLine("Seleccione una opcion: ");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");


            //Comienzo de ciclo do while
            while (opcion != 6)
            {

                switch (opcion)
                {
                    case 1:
                        for (int i = 0; i < CantidadProductos; i++)
                        {
                            Productos productos = new Productos();
                            Console.WriteLine("\n");
                            Console.WriteLine("Ingrese el codigo del producto: ");
                            productos.CodProducto = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el Nombre del producto: ");
                            productos.Nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese la categoria del producto: ");
                            productos.Categoria = Console.ReadLine();
                            Console.WriteLine("Ingrese el precio del producto: ");
                            productos.Precio = double.Parse(Console.ReadLine());

                            ListaProductos.Add(productos);
                        }
                        break;
                    case 2:
                        foreach (var items in ListaProductos)
                        {
                            items.MostrarDatos();
                        }

                        break;
                    case 3:
                        Productos.busquedaPorCodigo(ListaProductos);

                        break;
                    case 4:
                        Console.WriteLine("La suma de los productos es de: " + Productos.SumaTotalProductos(ListaProductos));

                        break;
                    case 5:
                        Productos.Eliminar(ListaProductos);
                        break;
                    case 6:
                        Console.WriteLine("\n");
                        Console.WriteLine("Fin del programa");
                        
                        break;
                    default:
                        Console.WriteLine("\n");
                        Console.WriteLine("Opcion invalida");
                        
                    break;
                }

                Console.WriteLine("\n");
                Console.WriteLine("1)Carga de productos");
                Console.WriteLine("2)Visualizacion de los productos cargados");
                Console.WriteLine("3)Busqueda por codigo de producto");
                Console.WriteLine("4)Total de la compra");
                Console.WriteLine("5)Eliminar articulos de la lista");
                Console.WriteLine("6)Salir");
                Console.WriteLine("Desea seleccionar otra opcion??: ");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

            }

            Console.ReadLine();
            
            















    }
    }
}
