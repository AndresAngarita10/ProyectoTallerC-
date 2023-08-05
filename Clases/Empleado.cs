
namespace ProyectoTallerC_.Clases;

public class Empleado : Persona
{
    public string especialidad;

    public Empleado(string _id, string _cedula, string _nombres, string _apellidos, string _nroMovil, string _email,
                    string _especialidad): base(_id,_cedula,_nombres,_apellidos,_nroMovil,_email){
        this.especialidad = _especialidad;
    }
    public string Especialidad{get => this.especialidad; set => this.especialidad = value;}
    public Empleado() {}

}
