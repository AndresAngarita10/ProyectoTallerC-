
namespace ProyectoTallerC_.Clases;

public class Persona
{
    public string id;
    public string cedula;
    public string nombres;
    public string apellidos;
    public string nroMovil;
    public string email;

    public Persona(string _id, string _cedula, string _nombres, string _apellidos, string _nroMovil, string _email){
        this.id = _id;
        this.cedula = _cedula;
        this.nombres = _nombres;
        this.apellidos = _apellidos;
        this.nroMovil = _nroMovil;
        this.email = _email;
    }
    public Persona(){}
    public string Id {get => this.id; set => this.id = value;}
    public string Cedula {get => this.cedula; set => this.cedula = value;}
    public string Nombres {get => this.nombres; set => this.nombres = value;}
    public string Apellidos {get => this.apellidos; set => this.apellidos = value;}
    public string NroMovil {get => this.nroMovil; set => this.nroMovil = value;}
    public string Email {get => this.email; set => this.email = value;}

}
