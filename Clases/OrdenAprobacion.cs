
namespace ProyectoTallerC_.Clases;

    public class OrdenAprobacion
    {
        public string id;
        public string idOrden;
        public List<string> idEmpleados = new();
        public DateTime fechaCreado;
        public List<Repuesto> repuestos = new();

        public string Id { get => this.id; set => this.id = value; }
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

        public void MostrarOrden(OrdenServicio orden, List<Empleado> _empleados){
            Console.WriteLine("Numero de Orden: " + idOrden);
            Console.WriteLine("Empleados asignados a la orden");
            //Console.WriteLine($"{orden.idEmpleados[0]}");
            foreach (var empleado in orden.IdEmpleado)
            {
                //Console.WriteLine(empleado);
                Empleado empleado1 = new ();
                Empleado emple = empleado1.BuscarEmpleadoXId(_empleados,empleado);
                Console.WriteLine($"\t - {emple.Nombres}, CC:{emple.Cedula}");
                //Console.WriteLine("---- alv");
            }
            Console.WriteLine("\t================================================================");
            Console.WriteLine("Detalle de Aprobacion :");
            int con =1;
            foreach (var rep in orden.ordenAprobacion.Repuestos)
            {
                Console.WriteLine($"#{con} - Nombre: {rep.Nombre} - Aprobacion: {rep.Estado}");
                Console.WriteLine($"\t\t Valor: {rep.ValorUnitario} - Cantidad: {rep.Cantidad} - Total: {rep.ValorUnitario*rep.Cantidad}");
                Console.WriteLine("\t\t\t================================================");
                con ++;
            }
        }

        
    }
