using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTallerC_.Clases;

    public class Diagnostico
    {
        public string id;
        public string idEmpleado;
        public string diagnosticoEmpleado;
        public DateTime fechaDiagnostico;

        public string Id { get => this.id; set => this.id = value; }
        public string IdEmpleado { get => this.idEmpleado; set => this.idEmpleado = value; }
        public string DiagnosticoEmpleado { get => this.diagnosticoEmpleado; set => this.diagnosticoEmpleado = value; }
        public DateTime FechaDiagnostico { get => this.fechaDiagnostico; set => this.fechaDiagnostico = value; }

        public Diagnostico(){}
        public Diagnostico(string _id, string _idEmpleado, string _diagnosticoEmpleado)
        {
            this.id = _id;
            this.idEmpleado = _idEmpleado;
            this.diagnosticoEmpleado = _diagnosticoEmpleado;
            this.fechaDiagnostico = DateTime.Today;
        }

        public Diagnostico CrearDiagnostico(string idEmpleado){
            Console.Clear();
            string id = Guid.NewGuid().ToString("N")[..10];// .Substring(0, 10); el sistema me cambio esto
            Console.WriteLine("Ingrese el diagnostico dado por el empleado");
            string diagnosticoEmple = Console.ReadLine();
            Diagnostico diagnostico = new(id, idEmpleado, diagnosticoEmple);
            return diagnostico;

        }
    }
