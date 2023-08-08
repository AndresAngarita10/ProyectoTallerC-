
namespace ProyectoTallerC_.Clases;

    public class OrdenAprobacion
    {
        public string id;
        public string idOrden;
        public List<string> idEmpleados = new();
        public DateTime fechaCreado;
        public List<Repuesto> repuestos = new();

        public string IdOrden { get => this.idOrden; set => this.idOrden = value; }
        public List<string> IdEmpleados { get => this.idEmpleados; set => this.idEmpleados = value; }
        public DateTime FechaCreado { get => this.fechaCreado; set => this.fechaCreado = value; }
        public List<Repuesto> Repuestos { get => this.repuestos; set => this.repuestos = value; }

        public OrdenAprobacion(){}
        public OrdenAprobacion(string _idOrden, DateTime _fechaCreado)
        {
            this.id = Guid.NewGuid().ToString("N")[..10];
            this.idOrden = _idOrden;
            this.fechaCreado= _fechaCreado;
        }

        public void MostrarOrden(OrdenAprobacion orden){
            Console.WriteLine("Numero de Orden: " + idOrden);
            Console.WriteLine("Empleados asignados a la orden");
            foreach (var empleado in orden.idEmpleados)
            {
                
            }
        }

        
    }
