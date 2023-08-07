using ProyectoTallerC_.Clases;
using ProyectoTallerC_.View;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Taller> listaTallers = new( ); 
        Taller taller = new("1010asd",  "Taller Mi laton",  "Andres");
        int codigoTaller = 0;
        listaTallers.Add(taller);
        Cliente clienteadd1 = new("100asd", "1095", "Andres", "Agnarita","200325","Andres@", DateTime.Today);
        listaTallers[codigoTaller].listaClientes.Add(clienteadd1);
        Vehiculo vehiculoadd1 = new("IPR520","picanto","2017","kia","gris","2000 KM --"+DateTime.Today);
        listaTallers[codigoTaller].listaClientes[0].listaVehiculos.Add(vehiculoadd1);
        Empleado empleadoadd1 = new("1095Aasad","1095","david","becerra","3012345432","diego@","Motores");
        listaTallers[0].listaEmpleado.Add(empleadoadd1);
        Empleado empleadoadd2 = new("10555Aasad","1095","diego","andrade","54545","davidddd@","Electricista");
        listaTallers[0].listaEmpleado.Add(empleadoadd2);
        MainMenu menu = new();
        int opcion;
        do
        {
            opcion = menu.Menu();
            switch (opcion)
            {
                case 1:
                //! Menu Clientes
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
                                listaTallers[codigoTaller].ListaClientes.Add(clienteNuevo);
                                cliente.MostrarClientes(listaTallers[codigoTaller].listaClientes, true);
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.WriteLine("Mostrando todos los clientes del sistema");
                                Cliente clienteMostrar = new();
                                clienteMostrar.MostrarClientes(listaTallers[codigoTaller].listaClientes, true);
                                Console.ReadKey();
                                break;
                            case 3:
                                Cliente clienteAddVehiculo = new();
                                Cliente clienteEncontrado = clienteAddVehiculo.BuscarCliente(listaTallers[codigoTaller].listaClientes);
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
                    //! Menu Empleados
                    int opcionEmpleado;
                    MenuEmpleado menuEmpleado = new();
                    do
                    {
                        opcionEmpleado = menuEmpleado.MenuPrincipalEmpleado();
                        switch (opcionEmpleado)
                        {
                            case 1: //? Agregar el Empleado
                                Empleado empleado = new();
                                Empleado nuevoEmpleado = empleado.AgregarEmpleado();
                                listaTallers[codigoTaller].ListaEmpleado.Add(nuevoEmpleado);
                                break;
                            case 2: 
                                Empleado empleadoTodos = new();
                                empleadoTodos.MostrarEmpleados(listaTallers[0].listaEmpleado);
                                break;
                            default:
                                break;
                        }
                    }while(opcionEmpleado != 4);
                    break;
                case 3:
                    //! Menu Ordenes
                    int opcionOrden;
                    MenuOrdenes menuOrden = new();
                    do
                    {
                        
                        opcionOrden = menuOrden.MenuPrincipalOrden();
                        switch (opcionOrden)
                        {
                            case 1: //? Crear Orden
                                Empleado empleado = new();
                                Empleado nuevoEmpleado = empleado.AgregarEmpleado();
                                listaTallers[codigoTaller].ListaEmpleado.Add(nuevoEmpleado);
                                break;
                            
                            default:
                                break;
                        }
                    }while(opcionOrden != 4);

                    break;
                case 4:
                    break;
                default:
                    break;
            }
        } while (opcion != 4);
    }
}