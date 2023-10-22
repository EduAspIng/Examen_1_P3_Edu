using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1_Eduardo_Espinoza
{
    internal class Clase_Menu
    {
        static int opcion = 0;
      public  static void Desplegar_Menu()//Mostrar menú
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al menú, seleccione una opcion por favor\n");
                Console.WriteLine("(1): Agregar Empleados");
                Console.WriteLine("(2): Consultar Empleados");
                Console.WriteLine("(3): Modificar Empleados");
                Console.WriteLine("(4): Borrar Empleados");
                Console.WriteLine("(5): Inicializar Arreglos");
                Console.WriteLine("(6): Menú de Reportes");
                Console.WriteLine("(7): Salir");
                int.TryParse(Console.ReadLine(), out opcion);
                Console.Clear();
                switch (opcion)
                {
                     case 1:Clase_Empleado.Agregar_Empleado(); break; 
                    case 2:Clase_Empleado.Consultar_Empleado(false); break;
                    case 3:Clase_Empleado.Modificar_Empleado(); break; 
                    case 4:Clase_Empleado.Borrar_Empleado(); break; 
                    case 5:Clase_Empleado.Inicializar_Arreglos(); break; 
                     case 6:Desplegar_Reportes(); break; 
                    case 7:; break;
                    default:
                        Console.WriteLine("Opcion invalida.\nPresiona Enter por favor");
                        Console.ReadLine();
                        break;
                }
            } while (opcion != 7);

        }
          public  static void Desplegar_Reportes() //Menu de reportes
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Menú de reportes, seleccione una opcion por favor\n");
                Console.WriteLine("(1): Consultar Empleados");
                Console.WriteLine("(2): Lista de Empleados");//hacerla funcion
                Console.WriteLine("(3): Promedio de salarios");//hacerla funcion
                Console.WriteLine("(4): Top de salarios");//hacerla funcion
                Console.WriteLine("(5): Salir del menu de reportes");
                int.TryParse(Console.ReadLine(), out opcion);
                Console.Clear();
                switch (opcion)
                {
                    case 1: Clase_Empleado.Consultar_Empleado(false); break;
                    case 2: Clase_Empleado.Lista_de_empleados(0); break; 
                    case 3:Clase_Empleado.Promedio_de_salarios(0); break; 
                    case 4:Clase_Empleado.Top_de_salarios(); break; 
                    case 5:Desplegar_Menu(); break;
                        Console.Clear();
                    default:
                        Console.WriteLine("Opcion invalida.\nPresiona Enter por favor");
                        Console.ReadLine();
                      ; break; 
                }
            } while (opcion != 5);

        }
    }
}
