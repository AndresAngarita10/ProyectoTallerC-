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
        public string nroOrden;
        public DateTime fechaOrden;
        public bool terminado;
        
        public string Id{ get => this.id; set => this.id = value;}
        public List<Diagnostico> Diagnostico{get => this.diagnostico; set => this.diagnostico = value;}
        public string IdCliente{ get => this.idCliente; set => this.idCliente = value; }
        public string IdVehiculo { get => this.idVehiculo; set => this.idVehiculo = value; }
        public List<string> IdEmpleado { get => this.idEmpleado; set => this.idEmpleado = value; }
        public string NroOrden { get => this.nroOrden; set => this.nroOrden =  value; }
        public DateTime FechaOrden{get => this.fechaOrden; set => this.fechaOrden = value;}
        public bool Termiando { get => this.terminado; set => this.terminado = value; }

        public OrdenServicio(){}

        public OrdenServicio(string _id, string _idCliente, string _idVehiculo, string _nroOrden, bool _terminado){
            this.id = _id;
            this.diagnostico = new List<Diagnostico>();
            this.idCliente = _idCliente;
            this.idVehiculo = _idVehiculo;
            this.idEmpleado = new List<string>();
            this.nroOrden = _nroOrden;
            this.terminado = _terminado;
        }
        
    }
}