﻿using ProyectoTallerC_.Clases;
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


        Diagnostico diagnostico1 = new ("1095Aasad", "Carro no prende motor");
        Diagnostico diagnostico2 = new ("10555Aasad", "Carro no prende luces de freno");
        List<Diagnostico> listaDiagnostico = new()
        {
            diagnostico1,
            diagnostico2
        };
        OrdenServicio ordenServicio1 = new("100asd","IPR520", listaDiagnostico,"60000");
        ordenServicio1.idEmpleado.Add("1095Aasad");
        ordenServicio1.idEmpleado.Add("10555Aasad");
        OrdenAprobacion ordenAprobacion1 = new(ordenServicio1.Id, DateTime.Today);
        Repuesto repuesto1 = new(ordenAprobacion1.Id, "1095Aasad", "Culata", 1250000, 1);
        Repuesto repuesto2 = new(ordenAprobacion1.Id, "1095Aasad", "Valvulas", 250000, 4);
        Repuesto repuesto3 = new(ordenAprobacion1.Id, "1095Aasad", "Piston", 450000, 2);

        Repuesto repuesto4 = new(ordenAprobacion1.Id, "10555Aasad", "Bombillo LED", 250000, 2);
        Repuesto repuesto5 = new(ordenAprobacion1.Id, "10555Aasad", "Cableado puerta piloto", 500000, 1);
        Repuesto repuesto6 = new(ordenAprobacion1.Id, "10555Aasad", "Bombillo stop", 25000, 2);

        ordenAprobacion1.Repuestos.Add(repuesto1);
        ordenAprobacion1.Repuestos.Add(repuesto2);
        ordenAprobacion1.Repuestos.Add(repuesto3);
        ordenAprobacion1.Repuestos.Add(repuesto4);
        ordenAprobacion1.Repuestos.Add(repuesto5);
        ordenAprobacion1.Repuestos.Add(repuesto6);

        ordenServicio1.ordenAprobacion = ordenAprobacion1;
        listaTallers[codigoTaller].listaClientes[0].OrdenesServicio.Add(ordenServicio1);

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
                    do
                    {
                        MenuClientes menuClientes = new();
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
                            case 3: //? Asignar vehiculo al cliente
                                Cliente clienteAddVehiculo = new();
                                Cliente clienteEncontrado = clienteAddVehiculo.BuscarCliente(listaTallers[codigoTaller].listaClientes);
                               // int indiceCliente = listaTallers[0].listaClientes.FindIndex(x => x.id.Equals(clienteEncontrado.Id));
                              //  Console.WriteLine($"Este el el indice del cliente {indiceCliente}");
                                Console.WriteLine("Cliente seleccionado: "+clienteEncontrado.nombres);
                                Console.ReadKey();
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
                    do
                    {
                        MenuEmpleado menuEmpleado = new();
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
                    do
                    {
                        
                        MenuOrdenes menuOrden = new();
                        opcionOrden = menuOrden.MenuPrincipalOrden();
                        switch (opcionOrden)
                        {
                            case 1: //? Crear Orden
                                Console.Clear();
                                Console.WriteLine("Creando Orden");
                                Console.WriteLine("Primero seleccionar cliente ");
                                Cliente cliente = new();
                                Cliente clienteSeleccionado = cliente.BuscarClienteXCC(listaTallers[codigoTaller].listaClientes);
                                int indiceCliente = listaTallers[0].listaClientes.FindIndex(x => x.id.Equals(clienteSeleccionado.Id));
                                Console.Clear();
                                Console.WriteLine($"Cliente seleccionado -> {clienteSeleccionado.nombres}");
                                Console.WriteLine("Seleccione el vehiculo a adicionar a la orden de servicio");
                                Vehiculo vehiculo = new();
                                Vehiculo vehiculoSeleccionado = vehiculo.SeleccionVehiculo(clienteSeleccionado);
                                int indiceVehiculo = listaTallers[0].listaClientes[indiceCliente].listaVehiculos.FindIndex(x => x.placaId.Equals(vehiculoSeleccionado.placaId));
                                Console.Clear();
                                Console.WriteLine($"Cliente seleccionado -> {clienteSeleccionado.nombres}");
                                Console.WriteLine($"Vehiculo seleccionado -> {vehiculoSeleccionado.marca} - {vehiculoSeleccionado.nombre} - {vehiculoSeleccionado.modelo}");
                               
                                Console.WriteLine("\t\t -----------------");
                               
                                Console.Clear();
                                Console.WriteLine("\t\t -----------------");
                                Console.WriteLine("Ingrese el kilometraje actual del vehiculo");
                                string km = Console.ReadLine();
                                listaTallers[0].listaClientes[indiceCliente].listaVehiculos[indiceVehiculo].historialKilometraje.Add($"{km} - KM - {DateTime.Today}");
                                Console.WriteLine("Crear los diagnosticos");
                                List<Diagnostico> diagnosticos = new();
                                Empleado empleado = new();
                                int cerrarDoDiagnosticos;
                                Console.WriteLine("Importante agregar minimo un diagnostico");
                                do
                                {
                                    Diagnostico diagnostico = new();
                                    Empleado empSeleccionado = empleado.BuscarEmpleadoHabilitado(listaTallers[0].listaEmpleado);
                                    Diagnostico nuevoDiagnostico = diagnostico.CrearDiagnostico(empSeleccionado.Id);
                                    diagnosticos.Add(nuevoDiagnostico);
                                    Console.WriteLine("Para agregar otro diagnostico ingrese 1, para salir ingrese 0");
                                    cerrarDoDiagnosticos = int.Parse(Console.ReadLine());
                                } while (cerrarDoDiagnosticos!=0);
                                Console.Clear();
                                Console.WriteLine($"Cliente seleccionado -> {clienteSeleccionado.nombres}");
                                Console.WriteLine($"Vehiculo seleccionado -> {vehiculoSeleccionado.marca} - {vehiculoSeleccionado.nombre} - {vehiculoSeleccionado.modelo}");
                                Console.WriteLine($"Cantidad de diagnosticos creados: {diagnosticos.Count}");
                                Console.ReadKey();
                                OrdenServicio ordenS = new(clienteSeleccionado.Id, vehiculoSeleccionado.PLacaId, diagnosticos, km);
                                // list.FindIndex(x => x.Equals(target)) != -1;
                                //Console.WriteLine($"Este el el indice del cliente {indiceCliente}");
                                OrdenAprobacion ordenAprobacion = new(ordenS.id,DateTime.Today);
                                ordenS.OrdenAprobacion = ordenAprobacion;
                                listaTallers[0].listaClientes[indiceCliente].ordenesServicio.Add(ordenS);
                                break;
                            case 2:
                                MenuOrdenes menuOrdenSer = new();
                                Console.Clear();
                                Console.WriteLine("Opcione de orden");
                                Console.WriteLine("Primero seleccionar cliente ");
                                Cliente clienteOp = new();
                                Cliente clienteSelec = clienteOp.BuscarClienteXCC(listaTallers[codigoTaller].listaClientes);
                                int indiceClie = listaTallers[0].listaClientes.FindIndex(x => x.id.Equals(clienteSelec.Id));
                                Console.Clear();
                                Console.WriteLine("Seleccione la orden a trabajar");
                                OrdenServicio ordenSel = new();
                                int opcionesSegundoMenu;
                                do
                                {
                                    OrdenServicio ordenSelect = ordenSel.SeleccionarOrden(listaTallers[0].listaClientes[indiceClie].ordenesServicio);
                                    Console.Clear();
                                    Console.WriteLine($"Selecciono la orden del vehiculo placa: {ordenSelect.idVehiculo}");
                                    Console.WriteLine("\t\t ---------");
                                    opcionesSegundoMenu = menuOrdenSer.MenuOIpcionesOrden();
                                    switch (opcionesSegundoMenu)
                                    {
                                        case 1:

                                            break;
                                        case 2:
                                            int opcAddEmpleado;
                                            do
                                            {
                                                Console.WriteLine("Añadir empleado a la orden");
                                                Empleado empleado0 = new();
                                                Empleado seleccionado1 = empleado0.BuscarEmpleado(listaTallers[codigoTaller].listaEmpleado);
                                                ordenSelect.IdEmpleado.Add(seleccionado1.Id);
                                                Console.WriteLine("Para agregar otro empleado ingrese 1, para salir ingrese 0");
                                                opcAddEmpleado = int.Parse(Console.ReadLine());
                                            } while (opcAddEmpleado!=0);
                                            break;
                                        case 3:

                                            break;
                                        case 4:

                                            break;
                                        case 5:
                                            Console.WriteLine("Agregar Repuestos a la orden");
                                            Empleado empleado1 = new();
                                            Empleado seleccionado = empleado1.BuscarEmpleado(listaTallers[codigoTaller].listaEmpleado);
                                            int opcMasRepuestos;
                                            do
                                            {
                                                Repuesto r = new();
                                                Repuesto respuestoNuevo = r.CrearRepuesto(ordenSelect.Id, seleccionado.Id);
                                                ordenSelect.ordenAprobacion.repuestos.Add(respuestoNuevo);
                                                Console.WriteLine("Para agregar otro repuesto ingrese 1, para salir ingrese 0");
                                                opcMasRepuestos = int.Parse(Console.ReadLine());
                                            } while (opcMasRepuestos != 0);
                                            break;
                                        case 6:
                                            //!Aprbar Repuestos
                                            if(ordenSelect.ordenAprobacion.repuestos.Count > 0){
                                                Repuesto repuesto = new();
                                                repuesto.AprobarRepuestos(ordenSelect.ordenAprobacion.repuestos);
                                                Console.WriteLine("Terminado");
                                                Console.ReadKey();
                                            }else {
                                                Console.WriteLine("No hay repuestos");
                                                Console.ReadKey();
                                            }
                                            break;
                                        case 7:
                                            OrdenAprobacion ord = new();
                                            ord.MostrarOrden(ordenSelect, listaTallers[0].listaEmpleado);
                                            Console.ReadKey();
                                            break;
                                        case 8:
                                            //? Mostrar Orden Completa
                                            Console.Clear();
                                            OrdenServicio orda = new(); 
                                            orda.MostrarOrdenCompleta(ordenSelect,listaTallers[0].listaClientes,listaTallers[0].listaEmpleado);
                                            break;
                                        default:
                                            break;
                                    }
                                } while (opcionesSegundoMenu != 9);
                                break;
                            case 3: 
                                Console.Clear();
                                Console.WriteLine("Mostrando ordenes activas");
                                Console.WriteLine("Primero seleccionar cliente ");
                                Cliente clienteOpp = new();
                                Cliente clienteSelect = clienteOpp.BuscarClienteXCC(listaTallers[codigoTaller].listaClientes);
                                int indiceClien = listaTallers[0].listaClientes.FindIndex(x => x.Cedula.Equals(clienteSelect.Cedula));
                                OrdenServicio ordencita = new();
                                ordencita.MostrarOrdenesSinTerminar(listaTallers[0].listaClientes[indiceClien].OrdenesServicio);
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Mostrando ordenes terminadas");
                                Console.WriteLine("Primero seleccionar cliente ");
                                Cliente clienteOpp2 = new();
                                Cliente clienteSelect2 = clienteOpp2.BuscarClienteXCC(listaTallers[codigoTaller].listaClientes);
                                int indiceClien2 = listaTallers[0].listaClientes.FindIndex(x => x.id.Equals(clienteSelect2.Id));
                                OrdenServicio ordencita2 = new();
                                ordencita2.MostrarOrdenesTerminadas(listaTallers[0].listaClientes[indiceClien2].OrdenesServicio);
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