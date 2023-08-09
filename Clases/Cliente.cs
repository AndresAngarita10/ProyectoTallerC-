

namespace ProyectoTallerC_.Clases;

    public class Cliente : Persona
    {
        public DateTime fechaRegistro;
        public bool habilitado;
        //public List<Vehiculo> listaVehiculos = new List<Vehiculo> ();
        //public List<Factura> listaFacturas = new List<Factura> ();
        public List<Vehiculo> listaVehiculos;
        public List<Factura> listaFacturas;
        public List<OrdenServicio> ordenesServicio;

        public List<Vehiculo> ListaVehiculos{get => this.listaVehiculos; set => this.listaVehiculos = value;}
        public List<Factura> ListaFacturas{get => this.listaFacturas; set => this.listaFacturas = value;}
        public List<OrdenServicio> OrdenesServicio{get => this.ordenesServicio; set => this.ordenesServicio = value;}
        public DateTime FechaRegistro{get => this.fechaRegistro; set => this.fechaRegistro = value;}

        public Cliente(string _id, string _cedula, string _nombres, string _apellidos, string _nroMovil, string _email,
                        DateTime _fechaRegistro)
                : base(_id: _id, _cedula: _cedula, _nombres: _nombres, _apellidos: _apellidos, _nroMovil: _nroMovil, _email: _email)
        {
            this.fechaRegistro = _fechaRegistro;
            this.listaVehiculos = new List<Vehiculo>();
            this.listaFacturas = new List<Factura>();
            this.ordenesServicio = new List<OrdenServicio>();
            this.habilitado = true;
        }
        public Cliente() {
            this.listaVehiculos = new List<Vehiculo>();
            this.listaFacturas = new List<Factura>();
            this.ordenesServicio = new List<OrdenServicio>();
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

        public void MostrarClientes(List<Cliente> clientes, bool estado){
            Console.Clear();
            Console.WriteLine("Listado de Clientes registrados en el sistema");
            int contador = 1 ;
            foreach (var cliente in clientes)
            {
                if ( estado == cliente.habilitado){
                    Console.WriteLine($"#{contador}  Nombres: {cliente.nombres}");
                    Console.WriteLine($"Apellidos: {cliente.apellidos}");
                    Console.WriteLine($"\tId: {cliente.id}");
                    Console.WriteLine($"\tCedula: {cliente.cedula}");
                    Console.WriteLine($"\tCelular: {cliente.nroMovil}");
                    Console.WriteLine($"\tEmail: {cliente.email}");
                    Console.WriteLine($"\tFecha Registro: {cliente.fechaRegistro}");
                    Console.WriteLine($"\tEstado: {cliente.habilitado}");
                    Console.WriteLine("-----------------------------------------");
                }
                contador++;
            }
        }

        public Cliente BuscarCliente(List<Cliente> clientes){
            MostrarClientes(clientes, true);
            Console.WriteLine("Ingrese el numero del cliente a seleccionar o ingrese '0' para salir");
            int opcion = int.Parse(Console.ReadLine());
            if(opcion > 0 && opcion <= clientes.Count){
                //Console.WriteLine("Este es el objeto a retornar");
                //Console.WriteLine(clientes[opcion-1]);
                return clientes[opcion-1];
            }else if (opcion == 0){
                Console.WriteLine("Saliendo.... ");
                Console.ReadKey();
                return null;
            }
            else {
                return BuscarCliente(clientes);
            }
        }
        
        public void EliminarCliente(List<Cliente> clientes){
            MostrarClientes(clientes, true);
            Console.WriteLine("Ingrese el numero del cliente a eliminar o ingrese '0' para salir");
            int opcion = int.Parse(Console.ReadLine());
            if(opcion > 0 && opcion <= clientes.Count){
                Cliente emple = clientes[opcion-1];
                Console.WriteLine($"Eliminando el cliente {emple.nombres}");
                clientes.RemoveAt(opcion-1);
                Console.ReadKey();
            }else if (opcion == 0){
                Console.WriteLine("Saliendo.... ");
                Console.ReadKey();
            }
            else {
                EliminarCliente(clientes);
            }
        }

        
        public void DesabilitarCliente(List<Cliente> clientes){
            MostrarClientes(clientes, true);
            Console.WriteLine("Ingrese el numero del cliente a desabilitar o ingrese '0' para salir");
            int opcion = int.Parse(Console.ReadLine());
            if(opcion > 0 && opcion <= clientes.Count){
                Cliente cli = clientes[opcion-1];
                Console.WriteLine($"Desabilitando el cliente {cli.nombres}");
                clientes[opcion-1].habilitado = false;
            }else if (opcion == 0){
                Console.WriteLine("Saliendo.... ");
                Console.ReadKey();
            }
            else {
                DesabilitarCliente(clientes);
            }
        }
        
        public void HabilitarCliente(List<Cliente> clientes){
            MostrarClientes(clientes, true);
            Console.WriteLine("Ingrese el numero del cliente a habilitar o ingrese '0' para salir");
            int opcion = int.Parse(Console.ReadLine());
            if(opcion > 0 && opcion <= clientes.Count){
                Cliente cli = clientes[opcion-1];
                Console.WriteLine($"Habilitando el cliente {cli.nombres}");
                clientes[opcion-1].habilitado = false;
            }else if (opcion == 0){
                Console.WriteLine("Saliendo.... ");
                Console.ReadKey();
            }
            else {
                HabilitarCliente(clientes);
            }
        }

        public Cliente BuscarClienteXCC(List<Cliente> clientes){
            Console.WriteLine("Ingrese la cedula del cliente");
            string cedula = Console.ReadLine();
            foreach (var cliente in clientes)
            {
                if(cedula.Equals(cliente.cedula)){
                    return cliente;
                }
            }
            return null;
        }

        public Cliente BuscarClienteXId(List<Cliente> clientes, string Id){
            foreach (var cliente in clientes)
            {
                if(Id.Equals(cliente.Id)){
                    return cliente;
                }
            }
            return null;
        }
/* 
        public int BuscarIndiceCliente(){
            Console.WriteLine("Primero seleccionar cliente ");
            Cliente clienteOp = new();
            Cliente clienteSelec = clienteOp.BuscarClienteXCC(listaTallers[codigoTaller].listaClientes);
            return listaTallers[0].listaClientes.FindIndex(x => x.id.Equals(clienteSelec.Id));
        } */

    }
