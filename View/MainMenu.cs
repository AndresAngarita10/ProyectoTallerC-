
namespace ProyectoTallerC_.View;

    public class MainMenu
    {
        public MainMenu() {}

        public int Menu()
        {
                //Console.Clear();
                Console.WriteLine("1. Clientes");
                Console.WriteLine("2. Empleados");
                Console.WriteLine("3. Ordenes");
                Console.WriteLine("4.Salir");
                return int.Parse(Console.ReadLine());
        }  
    }
