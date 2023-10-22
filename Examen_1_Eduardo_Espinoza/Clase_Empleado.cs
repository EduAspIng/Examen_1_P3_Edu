using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1_Eduardo_Espinoza
{
    internal class Clase_Empleado
    {
        static int buscador;
        static int Cantidad_Empleados = 5;
        //Atributos

        static int[] Cedula = new int[Cantidad_Empleados];
        static String[] Nombre = new String[Cantidad_Empleados];
        static String[] Direccion = new String[Cantidad_Empleados];
        static String[] Telefono = new String[Cantidad_Empleados];
        static int[] Salario = new int[Cantidad_Empleados];

        //Constructor
        public Clase_Empleado()
        {

        }
        //Metodos y funciones
        public static void Agregar_Empleado()
        {
            for (int i = 0; i < Cantidad_Empleados; i++)
            {


                Console.Write("Digite la cedula del empleado: ");
                int.TryParse(Console.ReadLine(), out Cedula[i]);
                Console.Write("Digite el nombre del empleado: ");
                Nombre[i] = Console.ReadLine();
                Console.Write("Digite la dirección del empleado: ");
                Direccion[i] = Console.ReadLine();
                Console.Write("Digite el teléfono del empleado: ");
                Telefono[i] = Console.ReadLine();
                Console.Write("Digite el salario del empleado: ");
                int.TryParse(Console.ReadLine(), out Salario[i]);
                Console.Clear();

            }
            Console.WriteLine("Presiona Enter para salir de Agregar");
            Console.ReadLine();
        }
        public static void Consultar_Empleado(Boolean Encontrado)
        {
            Console.Write("Digite la cedula del empleado: ");
            buscador = int.Parse(Console.ReadLine());

            for (int i = 0; i < Cantidad_Empleados; i++)
            {
                if (buscador.Equals(Cedula[i]))
                {
                    Encontrado = true;
                     if (Encontrado == true)
                {
                    Console.WriteLine($"Nombre: {Nombre[i]} |  Dirección: {Direccion[i]} |  Teléfono: {Telefono[i]} |  Salario: {Salario[i]} |  ");

                }

                }
                
                if (Cedula[i] == 0) { 
                    Console.WriteLine("No existe el empleado");
                    Console.WriteLine("Presiona Enter para salir de Consultar");
                    Console.ReadLine();
                    Clase_Menu.Desplegar_Menu();
                }
           }

            if (Encontrado == false)
            {
                Console.WriteLine($"No existe el empleado");
                Console.WriteLine("Presiona Enter para salir de Consultar");
                Console.ReadLine();
                Clase_Menu.Desplegar_Menu();
                }
            Console.WriteLine("Presiona Enter para salir de Consultar");
            Console.ReadLine();
            
        }
        

        public static void Borrar_Empleado()
        {
            Consultar_Empleado(false);
            for (int i = 0; i < Cantidad_Empleados; i++)
            {

                if (buscador.Equals(Cedula[i]))
                {
                    Cedula[i] = 0;
                    Nombre[i] = "";
                    Direccion[i] = "";
                    Telefono[i] = "";
                    Salario[i] = 0;

                }

            }
            Console.WriteLine("Se elimino el empleado"+"\n"+"Presiona Enter para salir de Borrar");
            Console.ReadLine();
        }

        public static void Modificar_Empleado()
        {
            Consultar_Empleado(false);
            for (int i = 0; i < Cantidad_Empleados; i++)
            {
                if (buscador.Equals(Cedula[i]))
                {
                    Console.Write("Modifique la cedula del empleado: ");
                    Cedula[i] = int.Parse(Console.ReadLine());

                    Console.Write("Modifique el nombre del empleado: ");
                    Nombre[i] = Console.ReadLine();

                    Console.Write("Modifique la dirección del empleado: ");
                    Direccion[i] = Console.ReadLine();

                    Console.Write("Modifique el teléfono del empleado: ");
                    Telefono[i] = Console.ReadLine();

                    Console.Write("Modifique el salario del empleado: ");
                    Salario[i] = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("Presiona Enter para salir de Modificar");
            Console.ReadLine();
        }
        public static void Inicializar_Arreglos()
        {
            Cedula = Enumerable.Repeat(0, Cantidad_Empleados).ToArray();
            Nombre = Enumerable.Repeat("", Cantidad_Empleados).ToArray();
            Direccion = Enumerable.Repeat("", Cantidad_Empleados).ToArray();
            Telefono = Enumerable.Repeat("", Cantidad_Empleados).ToArray();
            Salario = Enumerable.Repeat(0, Cantidad_Empleados).ToArray();
            Console.WriteLine("Se inicializaron los arreglos" + "\n" + "Presiona Enter para salir de inicializar");
            Console.ReadLine();
        }

        public static string Lista_de_empleados(int indice)
        {

            while (indice < Cantidad_Empleados)
            {
                Console.WriteLine($"Cedula: {Cedula[indice]} |  Nombre: {Nombre[indice]} |  Dirección: {Direccion[indice]} |  Teléfono: {Telefono[indice]} |  Salario: {Salario[indice]} |  ");
                indice++;
                }
            var orden_nombre = Nombre.OrderByDescending(Nombre => Nombre);
            foreach(var f in orden_nombre)//orden por nombre
            {
                Console.WriteLine(f);
            }

            if (indice == Cantidad_Empleados)
            {
                Console.WriteLine("Presiona Enter para salir de la lista");
                Console.ReadLine();
                Clase_Menu.Desplegar_Reportes();
            }
            return Lista_de_empleados(indice);
        }

        public static string Promedio_de_salarios(double Promedio) {

                Promedio = Salario.Average();
            
            Console.WriteLine($"El promedio de los salarios es: { Promedio.ToString()} \n Presiona Enter para salir del promedio");
            Console.ReadLine();
            return "";
            Console.ReadLine();
            Clase_Menu.Desplegar_Reportes();
        }
        public static string Top_de_salarios()
        {
            Console.WriteLine($"El salario más alto es {Salario.Max()}\n El salario más bajo es {Salario.Min()}\n Presiona Enter para salir del top de salarios");
            Console.ReadLine();
            return "";
            Console.ReadLine();
            Clase_Menu.Desplegar_Reportes();
        }

    }

    }

