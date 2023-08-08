
namespace ProyectoTallerC_.Clases;

public class Empleado : Persona
{
    public string especialidad;
    public bool habilitado;

    public Empleado(string _id, string _cedula, string _nombres, string _apellidos, string _nroMovil, string _email,
                    string _especialidad): base(_id,_cedula,_nombres,_apellidos,_nroMovil,_email)
    {
        this.especialidad = _especialidad;
        this.habilitado = true;
    }
    public string Especialidad{get => this.especialidad; set => this.especialidad = value;}
    public Empleado() {}

    public Empleado AgregarEmpleado(){
            Console.Clear();
            string id = Guid.NewGuid().ToString("N")[..10];// .Substring(0, 10); el sistema me cambio esto
            Console.WriteLine("Ingrese la cedula del Empleado");
            string cedula = Console.ReadLine();
            Console.WriteLine("Ingrese los nombres del Empleado");
            string nombres = Console.ReadLine();
            Console.WriteLine("Ingrese los apellidos del Empleado");
            string apellidos = Console.ReadLine();
            Console.WriteLine("Ingrese el numero del Empleado");
            string nroMovil = Console.ReadLine();
            Console.WriteLine("Ingrese el email del Empleado");
            string email = Console.ReadLine();
            Console.WriteLine("Ingrese la especialidad");
            string especialidad = Console.ReadLine();
            
            Empleado empleado = new(id, cedula, nombres, apellidos, nroMovil,email,especialidad);
            return empleado;
    }

    
        public void MostrarEmpleados(List<Empleado> empleados){
            Console.Clear();
            Console.WriteLine("Listado de empleados registrados en el sistema");
            int contador = 1 ;
            foreach (var empleado in empleados)
            {
                Console.WriteLine($"#{contador}  Nombres: {empleado.nombres}, Apellidos: {empleado.apellidos}, Especialidad: {empleado.especialidad}, Estado: {empleado.habilitado}");
                Console.WriteLine("\t\t----------------------------------------------------------");
                contador++;
            }
            Console.ReadKey();
        }
        
        public void MostrarEmpleadosEstado(List<Empleado> empleados, bool activo){
            Console.Clear();
            Console.WriteLine("Listado de empleados registrados en el sistema");
            int contador = 1 ;
            foreach (var empleado in empleados)
            {
                if(activo == empleado.habilitado){
                    Console.WriteLine($"#{contador}  Nombres: {empleado.nombres}, Apellidos: {empleado.apellidos}, Especialidad: {empleado.especialidad}, Estado: {empleado.habilitado}");
                    Console.WriteLine("\t\t----------------------------------------------------------");
                    contador++;
                }
            }
        }
        
        public Empleado BuscarEmpleado(List<Empleado> empleados){
            MostrarEmpleados(empleados);
            Console.WriteLine("Ingrese el numero del empleado a seleccionar o ingrese '0' para salir");
            int opcion = int.Parse(Console.ReadLine());
            if(opcion > 0 && opcion <= empleados.Count){
                //Console.WriteLine("Este es el objeto a retornar");
                //Console.WriteLine(clientes[opcion-1]);
                return empleados[opcion-1];
            }else if (opcion == 0){
                Console.WriteLine("Saliendo.... ");
                Console.ReadKey();
                return null;
            }else {
                return BuscarEmpleado(empleados);
            }
        }
        
        public Empleado BuscarEmpleadoHabilitado(List<Empleado> empleados){
            MostrarEmpleadosEstado(empleados, true);
            Console.WriteLine("Ingrese el numero del empleado a seleccionar o ingrese '0' para salir");
            int opcion = int.Parse(Console.ReadLine());
            if(opcion > 0 && opcion <= empleados.Count){
                //Console.WriteLine("Este es el objeto a retornar");
                //Console.WriteLine(clientes[opcion-1]);
                return empleados[opcion-1];
            }else if (opcion == 0){
                Console.WriteLine("Saliendo.... ");
                Console.ReadKey();
                return null;
            }else {
                return BuscarEmpleadoHabilitado(empleados);
            }
        }
        
        public void EliminarEmpleado(List<Empleado> empleados){
            MostrarEmpleados(empleados);
            Console.WriteLine("Ingrese el numero del empleado a eliminar o ingrese '0' para salir");
            int opcion = int.Parse(Console.ReadLine());
            if(opcion > 0 && opcion <= empleados.Count){
                Empleado emple = empleados[opcion-1];
                Console.WriteLine($"Eliminando el empleado {emple.nombres}");
                empleados.RemoveAt(opcion-1);
                Console.ReadKey();
            }else if (opcion == 0){
                Console.WriteLine("Saliendo.... ");
                Console.ReadKey();
            }
            else {
                EliminarEmpleado(empleados);
            }
        }

        

        public void DesabilitarEmpleado(List<Empleado> empleados){
            MostrarEmpleados(empleados);
            Console.WriteLine("Ingrese el numero del empleado a desabilitar o ingrese '0' para salir");
            int opcion = int.Parse(Console.ReadLine());
            if(opcion > 0 && opcion <= empleados.Count){
                Empleado emple = empleados[opcion-1];
                Console.WriteLine($"Desabilitando el empleado {emple.nombres}");
                empleados[opcion-1].habilitado = false;
                Console.ReadKey();
            }else if (opcion == 0){
                Console.WriteLine("Saliendo.... ");
                Console.ReadKey();
            }
            else {
                DesabilitarEmpleado(empleados);
            }
        }

        
        public void HabilitarEmpleado(List<Empleado> empleados){
            MostrarEmpleados(empleados);
            Console.WriteLine("Ingrese el numero del empleado a habilitar o ingrese '0' para salir");
            int opcion = int.Parse(Console.ReadLine());
            if(opcion > 0 && opcion <= empleados.Count){
                Empleado emple = empleados[opcion-1];
                Console.WriteLine($"Desabilitando el empleado {emple.nombres}");
                empleados[opcion-1].habilitado = true;
                Console.ReadKey();
            }else if (opcion == 0){
                Console.WriteLine("Saliendo.... ");
                Console.ReadKey();
            }
            else {
                DesabilitarEmpleado(empleados);
            }
        }
}
