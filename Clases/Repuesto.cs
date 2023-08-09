
namespace ProyectoTallerC_.Clases;

    public class Repuesto
    {
        public string id;
        public string idOrdenAprovacion;
        public string idEmpleado;
        public string nombre;
        public float valorUnitario;
        public int cantidad;
        public bool estado;
        public DateTime fechaAgregado;

        public string Id { get => this.id; set => this.id = value;}
        public string IdOrdenAprovacion { get => this.idOrdenAprovacion; set => this.idOrdenAprovacion = value;}

        public string IdEmpleado { get => this.idEmpleado; set => this.idEmpleado = value;}

        public string Nombre { get => this.nombre; set => this.nombre = value;}

        public float ValorUnitario { get => this.valorUnitario; set => this.valorUnitario = value;}
        public int Cantidad { get => this.cantidad; set => this.cantidad = value;}
        public bool Estado { get => this.estado; set => this.estado = value;}
        public DateTime FechaAgregado { get => this.fechaAgregado; set => this.fechaAgregado = value;}

        public Repuesto (){}

        public Repuesto(string _idOrdenAprovacion, string _idEmpleado, string _nombre, float _valorUnitario, int _cantidad)
        {
            this.id = Guid.NewGuid().ToString("N")[..10];
            this.idOrdenAprovacion = _idOrdenAprovacion;
            this.idEmpleado = _idEmpleado;
            this.nombre = _nombre;
            this.valorUnitario = _valorUnitario;
            this.cantidad = _cantidad;
            this.estado = false;
            this.fechaAgregado = DateTime.Today;
        }
        public Repuesto CrearRepuesto(string idOrdenAprovacion, string idEmpleado){
            Console.Clear();
            Console.WriteLine("Añadiendo nuevo repuesto");
            Console.WriteLine("Ingrese el nombre del repuesto");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el valor unitario");
            float valorUnit = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad necesaria");
            int cantidad = int.Parse(Console.ReadLine());
            if (cantidad >0){
                Repuesto repuesto = new(idOrdenAprovacion, idEmpleado, nombre, valorUnit, cantidad);
                return repuesto;
            }else {
                return CrearRepuesto(idOrdenAprovacion, idEmpleado);
            }

        }

        public List<Repuesto> AprobarRepuestos(List<Repuesto> repuestos) {
            int contador = 1;
            foreach (var repuesto in repuestos)
            {
                Console.Clear();
                Console.WriteLine("Aprobacion de repuestos");
                Console.WriteLine($"#{contador}, Nombre: {repuesto.Nombre}, ValorUnit: {repuesto.ValorUnitario}, Cantidad: {repuesto.Cantidad}");
                Console.WriteLine("\t\t ------");
                Console.WriteLine("Para aprobar ingrese 1, Para no aprobar ingrese 0");
                int validador = int.Parse(Console.ReadLine());
                if(validador >= 0 && validador <= 1){
                    if(validador == 1){
                        Console.WriteLine("Repuesto aprobado");
                        repuesto.Estado = true;
                        Console.ReadKey();
                    }else if(validador == 0){
                        Console.WriteLine("Repuesto no aprobado");
                        repuesto.Estado=false;
                        Console.ReadKey();
                    }
                }else{
                    Console.WriteLine("Valor invalido, repuesto no aprobado");
                    repuesto.Estado=false;
                    Console.ReadKey();
                }
            }
            return repuestos;

        }
        
    }
