using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTallerC_.Clases
{
    public class OrdenServicio
    {
        public string id;
        public List<Diagnostico> diagnostico;
        public string idCliente;
        public string idVehiculo;
        public List<string> idEmpleado;
        public DateTime fechaOrden;
        public bool terminado;
        public string kilometraje;
        public OrdenAprobacion ordenAprobacion;
        
        public string Id{ get => this.id; set => this.id = value;}
        public List<Diagnostico> Diagnostico{get => this.diagnostico; set => this.diagnostico = value;}
        public string IdCliente{ get => this.idCliente; set => this.idCliente = value; }
        public string IdVehiculo { get => this.idVehiculo; set => this.idVehiculo = value; }
        public List<string> IdEmpleado { get => this.idEmpleado; set => this.idEmpleado = value; }
        public DateTime FechaOrden{get => this.fechaOrden; set => this.fechaOrden = value;}
        public bool Termiando { get => this.terminado; set => this.terminado = value; }
        public string Kilometraje { get => this.kilometraje; set => this.kilometraje = value; }
        public OrdenAprobacion OrdenAprobacion { get => this.ordenAprobacion; set => this.ordenAprobacion = value; }

        public OrdenServicio(){}

        public OrdenServicio(string _idCliente, string _idVehiculo, List<Diagnostico> listaDiagnostico, string _kilometraje/*  OrdenAprobacion _ordenAprobacion */ ){
            this.id = Guid.NewGuid().ToString("N")[..10];
            this.diagnostico = listaDiagnostico;
            this.idCliente = _idCliente;
            this.idVehiculo = _idVehiculo;
            this.idEmpleado = new List<string>();
            this.terminado = false;
            this.fechaOrden = DateTime.Today;
            this.kilometraje = _kilometraje;
            //this.ordenAprobacion = _ordenAprobacion;
        }

        public void MostrarOrdenesSinTerminar(List<OrdenServicio> ordenes){
            Console.WriteLine("Ordenes Sin termianr");
            int contador = 1;
            foreach (var orden in ordenes)
            {
                if(orden.terminado == false){
                    Console.WriteLine($"#{contador} - Placa: {orden.idVehiculo}, Fecha: {orden.fechaOrden}");
                    contador++;
                }
            }
            Console.ReadLine();
        }


        public void MostrarOrdenesTerminadas(List<OrdenServicio> ordenes){
            Console.WriteLine("Ordenes Terminadas");
            int contador = 1;
            foreach (var orden in ordenes)
            {
                if(orden.terminado == true){
                    Console.WriteLine($"#{contador} - Placa: {orden.idVehiculo}, Fecha: {orden.fechaOrden}");
                    contador++;
                }
            }
            Console.ReadLine();
        }

        public OrdenServicio SeleccionarOrden(List<OrdenServicio> ordenes){
            MostrarOrdenesSinTerminar(ordenes);
            Console.WriteLine("Ingrese el # de orden a seleccionar");
            int seleccion = int.Parse(Console.ReadLine());
            if(seleccion > 0 && seleccion <= ordenes.Count){
                return ordenes[seleccion-1];
            }else{
                return SeleccionarOrden(ordenes);
            }

        }

        

    }
}