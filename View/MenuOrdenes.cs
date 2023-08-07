using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTallerC_.View;

    public class MenuOrdenes
    {
         public MenuOrdenes() {}

        public int MenuPrincipalOrden()
        {
            Console.Clear();
            Console.WriteLine("\t ***** Seccion Ordenes *****");
            Console.WriteLine("1. Agregar");
            Console.WriteLine("2. Opciones de orden");
            Console.WriteLine("3. Mostrar Ordenes activas");
            Console.WriteLine("4. Mostrar Ordenes Terminadas");
            Console.WriteLine("5.Salir");
            return int.Parse(Console.ReadLine());
        }

        public int MenuOIpcionesOrden(){
            Console.Clear();
            Console.WriteLine("\t ***** Opciones de orden *****");
            Console.WriteLine("1. Modificar Orden");
            Console.WriteLine("2. Añadir empleado");
            Console.WriteLine("2. Retirar empleado");
            Console.WriteLine("3. Mostrar Ordenes Terminadas ---------Falta revisarla");
            Console.WriteLine("5.Salir");
            return int.Parse(Console.ReadLine());
        } 
    }
