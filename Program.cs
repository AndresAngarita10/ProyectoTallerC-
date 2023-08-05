using ProyectoTallerC_.Clases;
using ProyectoTallerC_.View;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Taller> listaTallers = new List<Taller>( ); 
        Taller taller = new Taller("1010asd",  "Taller Mi laton",  "Andres");
        listaTallers.Add(taller);
        MainMenu menu = new MainMenu();
        int opcion = 0;
        do
        {
            opcion = menu.Menu();
            switch (opcion)
            {
                case 1:
                //////Menu Clientes
                    int opcionCliente = 0;
                    MenuClientes menuClientes = new MenuClientes();
                    do
                    {
                        opcionCliente = menuClientes.MenuPrincipal();
                        switch (opcionCliente)
                        {
                            case 1:
                                Cliente cliente = new Cliente();
                                Cliente clienteNuevo = cliente.CrearCliente();
                                listaTallers[0].ListaClientes.Add(clienteNuevo);
                                cliente.MostrarClientes(listaTallers[0].listaClientes);
                                Console.ReadKey();
                                break;
                            case 2:
                                
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