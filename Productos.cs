using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario
{
    internal class Productos
    {
        public int CodProducto { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }


        //Funcion para visualizacion de datos
        public void MostrarDatos()
        {

            Console.WriteLine("\n");
            Console.WriteLine("Codigo Producto: " + CodProducto);
            Console.WriteLine("Nombre del producto: " + Nombre);
            Console.WriteLine("Categoria del producto: " + Categoria);
            Console.WriteLine("Precio del producto: " + Precio);
        }

        //Funcion de busqueda
        //Este método se declara como estático (static) para ser llamado sin crear una instancia de Productos.
        public static void busquedaPorCodigo(List<Productos> listaProductos)
        {
            int Codigo;

            Console.WriteLine("Ingrese el codigo que desea buscar: ");
            Codigo = int.Parse(Console.ReadLine());

            var productoEncontrado = listaProductos.FirstOrDefault(p => p.CodProducto == Codigo);

            if (productoEncontrado != null)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Producto Encontrado");
                productoEncontrado.MostrarDatos();


            }
            else
            {
                Console.WriteLine("Atencion, No se encontraron resultados!!!!");
            }
        }


        //Funcion para calcular el total

        public static double SumaTotalProductos(List<Productos> listaProductos)
        {
            double suma = 0;

            foreach (var prod in listaProductos)
            {
                suma += prod.Precio; 
            }


            return suma;
        }

        //Remover elementos de la lista

        public static void Eliminar(List<Productos> listaProductos)
        {
            int Codigo;

            Console.WriteLine("Ingrese el codigo que desea buscar: ");
            Codigo = int.Parse(Console.ReadLine());

            var EliminarproductoEncontrado = listaProductos.FirstOrDefault(p => p.CodProducto == Codigo);

            if (EliminarproductoEncontrado != null)
            {

                listaProductos.Remove(EliminarproductoEncontrado);

            }
            else
            {
                Console.WriteLine("Atencion, No se encontraron resultados!!!!");
            }
        }


    }
}
