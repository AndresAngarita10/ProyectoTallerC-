using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTallerC_.View
{
    public class MenuClientes
    {
        public MenuClientes() {}

        public int MenuPrincipal()
        {
                Console.Clear();
                Console.WriteLine("\t ***** Seccion Clientes *****");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Mostrar Clientes");
                Console.WriteLine("3. Asignar Vehiculo a Cliente");
                Console.WriteLine("4. Ordenes");
                Console.WriteLine("5.Salir");
                return int.Parse(Console.ReadLine());
        } 
    }
}