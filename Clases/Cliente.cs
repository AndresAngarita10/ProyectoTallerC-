

namespace ProyectoTallerC_.Clases;

    public class Cliente : Persona
    {
        public DateTime fechaRegistro;
        //public List<Vehiculo> listaVehiculos = new List<Vehiculo> ();
        //public List<Factura> listaFacturas = new List<Factura> ();
        public List<Vehiculo> listaVehiculos;
        public List<Factura> listaFacturas;
        public List<Vehiculo> ListaVehiculos{get => this.listaVehiculos; set => this.listaVehiculos = value;}
        public List<Factura> ListaFacturas{get => this.listaFacturas; set => this.listaFacturas = value;}
        public DateTime FechaRegistro{get => this.fechaRegistro; set => this.fechaRegistro = value;}

        public Cliente(string _id, string _cedula, string _nombres, string _apellidos, string _nroMovil, string _email,
                        DateTime _fechaRegistro)
                : base(_id: _id, _cedula: _cedula, _nombres: _nombres, _apellidos: _apellidos, _nroMovil: _nroMovil, _email: _email)
        {
            this.fechaRegistro = _fechaRegistro;
            this.listaVehiculos = new List<Vehiculo>();
            this.listaFacturas = new List<Factura>();
        }
        public Cliente() {
            this.listaVehiculos = new List<Vehiculo>();
            this.listaFacturas = new List<Factura>();
        }



        public Cliente CrearCliente(){
            Console.Clear();
            string id = Guid.NewGuid().ToString("N")[..10];// .Substring(0, 10); el sistema me cambio esto
            Console.WriteLine("Ingrese la cedula del cliente");
            string cedula = Console.ReadLine();
            Console.WriteLine("Ingrese los nombres del cliente");
            string nombres = Console.ReadLine();
            Console.WriteLine("Ingrese los apellidos del cliente");
            string apellidos = Console.ReadLine();
            Console.WriteLine("Ingrese el numero del cliente");
            string nroMovil = Console.ReadLine();
            Console.WriteLine("Ingrese el email del cliente");
            string email = Console.ReadLine();
            
            Cliente cliente = new(id, cedula, nombres, apellidos, nroMovil,email,DateTime.Today);
            return cliente;
        }

        public void MostrarClientes(List<Cliente> clientes){
            Console.Clear();
            Console.WriteLine("Listado de Clientes registrados en el sistema");
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"Nombres: {cliente.nombres}");
                Console.WriteLine($"Apellidos: {cliente.apellidos}");
                Console.WriteLine($"\tId: {cliente.id}");
                Console.WriteLine($"\tCedula: {cliente.cedula}");
                Console.WriteLine($"\tCelular: {cliente.nroMovil}");
                Console.WriteLine($"\tEmail: {cliente.email}");
                Console.WriteLine("-----------------------------------------");
            }
        }
    }
