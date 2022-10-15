using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


/*Profe, honestamente no se que me paso en este examen, si viste mi tarea del peaje a mi se me da muy bien programar, pero por alguna razon en este trabajo
no me salen las ideas y el orden de como tengo que hacer las cosas. Intente hacer lo que pude seguir del word*/
namespace VentaDeArticulos
{
    internal class Program
    {
        static int contador = -1;
        static string opcion = "";
        static int consulta = 0;

        static void Main(string[] args)
        {
        }

        class Menu
        {
            static void Menuu()
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("*****Menu*****");
                    Console.WriteLine("A. Articulos");
                    Console.WriteLine("B. Facturacion");
                    Console.WriteLine("C. Reporte");
                    Console.WriteLine("D. Salir");
                    opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "A":
                            Articulos.MenuArticulos();
                            break;
                        case "B":
                            
                            break;
                        case "C":
                            break;
                        case "D":
                            foreach (var vendedor in Vendedores.Vendors)
                            {
                                Console.WriteLine(Vendedores.Vendors);
                            }
                            break;
                    }
                } while (opcion != "D");
            }//menuu
        }//class Menu

        class Articulos
        {
            protected static int[] Codigo = new int[5];
            protected static string[] Nombre = new string[5];
            protected static int[] Precio = new int[5];

            public static void MenuArticulos()
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("*****Articulos*****");
                    Console.WriteLine("A. Agregar");
                    Console.WriteLine("B. Borrar");
                    Console.WriteLine("C. Consultar");
                    Console.WriteLine("D. Salir");
                    opcion = Console.ReadLine();
                }while(opcion != "D");
            }//menuarticulos

            public int[] Codigo1 { get; set; }
            public string[] Nombre1 { get; set; }
            public int[] Precio1 { get; set; }

            public static void CrearArticulo()
            {
                contador++;
                if (contador < 5) 
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese el codigo del articulo: ");
                    Codigo[contador] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nombre del articulo: ");
                    Nombre[contador] = Console.ReadLine();
                    Console.WriteLine("Ingrese el precio del articulo: ");
                    Precio[contador] = int.Parse(Console.ReadLine());
                    
                }
                else
                {
                    Console.WriteLine("No se pueden ingresar mas articulos");
                    Console.ReadLine();
                }
            }//crear

            public static void BorrarArticulo()
            {
                Console.WriteLine("Ingrese el codigo del articulo a eliminar: ");
                consulta = int.Parse(Console.ReadLine());
                for (int i = 0; i < Codigo.Length; i++)
                {
                    if (Codigo[i] == consulta)
                    {
                        Codigo[i] = 0;
                        Nombre[i] = "";
                        Precio[i] = 0;
                        Console.Clear();
                        Console.WriteLine("El articulo a sido eliminado");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("El articulo que solicito no existe");
                        Console.ReadLine();
                    }
                }
            }//borrararticulo

            public static void consultarArticulo()
            {
                Console.WriteLine("Ingrese el codigo del articulo a consultar: ");
                consulta = int.Parse(Console.ReadLine());
                for (int i = 0; i < Codigo.Length; i++)
                {
                    if (Codigo[i] == consulta)
                    {
                        Console.WriteLine("Codigo: " + Codigo[i]);
                        Console.WriteLine("Nombre: " + Nombre[i]);
                        Console.WriteLine("Precio: " + Precio[i]);
                        Console.ReadLine();
                        
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("El articulo que solicito no existe");
                        Console.ReadLine();
                    }
                }
            }



        }//class Vendedores

        class Categorias
        {
            Boolean existe = false;
            public static void promocion()
            {
                Console.WriteLine("Descuentos y promociones");
            }

            List<string> lista = new List<string>()
            {
                "Categoria 1",
                "Categoria 2",
                "Categoria 3"
            };

            public static void ListadoCategorias(List<string> lista)
            {
            }
        }//Class Categorias

        class Categoria1 : Categorias
        {
            static void promocion()
            {
                Console.WriteLine("Descuento de 15%");
            }
        }

        class Categoria2 : Categorias
        {
            static void promocion()
            {
                Console.WriteLine("Promocion 2x1");
            }
        }

        class Categoria3 : Categorias 
        {
            static void promocion()
            {
                Console.WriteLine("Todo a mitad de precio");
            }
        }

        class Vendedores
        {
            public static Dictionary<int, String> Vendors = new Dictionary<int, String>()
            {
                {1, "Vendedor 1" },
                {2, "Vendedor 2" }
            };
            public static void ListadoVendedores()
            {
                string resultado = "";
                if (Vendors.TryGetValue(2, out resultado))
                {
                    Console.WriteLine(resultado);
                }
            }
            public static string Devolver (int code)
            {
                string resultado = "";
                if (Vendors.TryGetValue(2, out resultado));
                return resultado;
            }
        }//Class Vendedores

        class Interface
        {
            interface Ivendedor1
            {
               
            }

            interface Ivendedor2
            {
            
             
            }
        }// Class Interface

    }
}
