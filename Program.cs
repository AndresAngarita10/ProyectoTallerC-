using ProyectoTallerC_.Clases;
using ProyectoTallerC_.View;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Taller> listaTallers = new( ); 
        Taller taller = new("1010asd",  "Taller Mi laton",  "Andres");
        listaTallers.Add(taller);
        MainMenu menu = new();
        int opcion;
        do
        {
            opcion = menu.Menu();
            switch (opcion)
            {
                case 1:
                //////Menu Clientes
                    int opcionCliente;
                    MenuClientes menuClientes = new();
                    do
                    {
                        opcionCliente = menuClientes.MenuPrincipal();
                        switch (opcionCliente)
                        {
                            case 1:
                                //? Creando cliente
                                Cliente cliente = new();
                                Cliente clienteNuevo = cliente.CrearCliente();
                                listaTallers[0].ListaClientes.Add(clienteNuevo);
                                cliente.MostrarClientes(listaTallers[0].listaClientes);
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.WriteLine("Mostrando todos los clientes del sistema");
                                Cliente clienteMostrar = new();
                                clienteMostrar.MostrarClientes(listaTallers[0].listaClientes);
                                Console.ReadKey();
                                break;
                            case 3:
                                Cliente clienteAddVehiculo = new();
                                Cliente clienteEncontrado = clienteAddVehiculo.BuscarCliente(listaTallers[0].listaClientes);
                                Console.WriteLine("Cliente seleccionado: "+clienteEncontrado.nombres);
                                Vehiculo nuevoVehiculo = new();
                                Vehiculo nuevoV = nuevoVehiculo.CrearVehiculo();
                                Console.WriteLine("Cliente seleccionado: "+clienteEncontrado.nombres);
                                clienteEncontrado.ListaVehiculos.Add(nuevoV);
                                nuevoV.MostrarVehiculosNombreModelo(clienteEncontrado.listaVehiculos);
                                Console.ReadKey();
                                break;
                            default:
                                break;
                        }
                    } while (opcionCliente != 5);
                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        } while (opcion != 4);
    }
}