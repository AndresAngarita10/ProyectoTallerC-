

namespace ProyectoTallerC_.Clases;

    public class Vehiculo
    {
        public string placaId;
        public string nombre;
        public string modelo;
        public string marca;
        public string color;
        //public List<string> historialKilometraje;
        public int totalOrdenes;
        public List<string> historialKilometraje = new();

        public string PLacaId{get => this.placaId; set => this.placaId = value;}
        public string Nombre{get => this.nombre; set => this.nombre = value;}
        public string Modelo{get => this.modelo; set => this.modelo = value;}
        public string Marca{get => this.marca; set => this.marca = value;}
        public string Color{get => this.color; set => this.color = value;}
        public int TotalOrdenes{get => this.totalOrdenes; set => this.totalOrdenes = value;}
        public Vehiculo() {
            //this.historialKilometraje = new List<string>();
            this.totalOrdenes = 0;
        }
        public Vehiculo(string _placaId, string _nombre, string _modelo, string _marca, string _color, string _historialKilometraje) {
            this.placaId = _placaId;
            this.nombre = _nombre;
            this.modelo = _modelo;
            this.marca = _marca;
            this.color = _color;
            this.historialKilometraje.Add(_historialKilometraje);
            this.totalOrdenes = 0;
        }

        public Vehiculo CrearVehiculo (){
            Console.Clear();
            Console.WriteLine("Creando Vehiculo ");
            Console.WriteLine("Ingrese la placa del vehiculo: ");
            string placa = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el modelo: ");
            string modelo = Console.ReadLine();
            Console.WriteLine("Ingrese la marca del vehiculo: ");
            string marca = Console.ReadLine();
            Console.WriteLine("ingrese el color: ");
            string color = Console.ReadLine();
            Console.WriteLine("Ingrese el kilometraje");
            string km = Console.ReadLine();
            string kmDate =  km+" - KM -- "+Convert.ToString(DateTime.Today);
            Vehiculo vehiculo = new (placa, nombre, modelo, marca, color, kmDate);
            return vehiculo;

        }

        public void MostrarVehiculosNombreModelo(List<Vehiculo> vehiculos){
            Console.WriteLine("Estos son los vehiculos del cliente ");
            int contador = 1;
            foreach (var vehiculo in vehiculos)
            {
                Console.WriteLine($"\t#{contador}, Nombre: {vehiculo.nombre}, Modelo: {vehiculo.modelo}, Placa: {vehiculo.placaId}");
                Console.WriteLine("Historial de Kilometraje");
                foreach (var km in vehiculo.historialKilometraje)
                {
                    Console.WriteLine($"\t\t {km} ");
                }
                contador++;
            }
        }
    }
