
namespace ProyectoTallerC_.Clases;

    public class Taller
    {
        public string id;
        public string nombre;
        public string nombrePropietario;
        //public List<Cliente> listaClientes = new List<Cliente> ();
        //public List<Empleado> listaEmpleado = new List<Empleado>();

        public List<Cliente> listaClientes;
        public List<Empleado> listaEmpleado;
        public List<Cliente> ListaClientes{get => this.listaClientes; set => this.listaClientes = value;}
        public List<Empleado> ListaEmpleado{get => this.listaEmpleado; set => this.listaEmpleado = value;}


        public Taller(string id, string nombre, string nombrePropietario) {
            this.id = id;
            this.nombre = nombre;
            this.nombrePropietario = nombrePropietario;
            this.listaClientes = new List<Cliente>();
            this.listaEmpleado = new List<Empleado>();
        }
        public Taller (){
            this.listaClientes = new List<Cliente>();
            this.listaEmpleado = new List<Empleado>();
        }

        public Taller CrearTaller(){
            Console.Clear();
            string id = Guid.NewGuid().ToString("N").Substring(0, 10);
            Console.WriteLine("Ingrese el Nombre del taller");
            string nombreTaller = Console.ReadLine();
            Console.WriteLine("Ingrese el Nombre del propietario del taller");
            string nombrePropietario = Console.ReadLine();
            Taller taller = new Taller(id, nombreTaller, nombrePropietario);
            return taller;

        }
    }
