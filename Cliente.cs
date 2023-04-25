class Cliente{
    public int DNI {get; private set;}
    public string apellido {get;private set;}
    public string nombre {get;private set;}
    public DateTime fechaInscripcion {get;set;}
    public int tipoEntrada{get; set;}
    public int totalAbonado{get; set;}

    public Cliente () {

    }

    public Cliente(int DNI, string apellido, string nombre, DateTime fechaInscripcion, int tipoEntrada, int totalAbonado){
        this.DNI = DNI;
        this.apellido = apellido;
        this.nombre = nombre;
        this.fechaInscripcion = fechaInscripcion;
        this.tipoEntrada = tipoEntrada;
        this.totalAbonado = totalAbonado;
    }
}