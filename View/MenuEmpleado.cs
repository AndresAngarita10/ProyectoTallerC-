

namespace ProyectoTallerC_.View;

    public class MenuEmpleado
    {
         public MenuEmpleado() {}

        public int MenuPrincipalEmpleado()
        {
                Console.Clear();
                Console.WriteLine("\t ***** Seccion Empleados *****");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Mostrar Empleados");
                Console.WriteLine("3. Asignar Empleado a Orden ----- Revisar si es mejor ponerla en el menu de la orden");
                Console.WriteLine("4. Ordenes");
                Console.WriteLine("5.Salir");
                return int.Parse(Console.ReadLine());
        } 
    }
