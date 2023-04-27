using System.Collections.Generic;
int opcion;

int[] precioEntradas = {0,15000,30000,10000,40000};

do
{
    opcion = Funciones.IngresarEnteroEnRango("ingrese la opcion (1, 2, 3, 4 o 5) ",1,5);
    switch (opcion)
    {
    case 1:
        ingresarCliente();
    break;
    case 2:
        ObtenerEstadisticas();
    break;
    case 3:
        int idBuscado = Funciones.IngresarEntero("Ingrese el ID del cliente a buscar: ");
        Cliente clienteBuscado = Ticketera.BuscarCliente(idBuscado);
        if (clienteBuscado.DNI > 0){
            Console.WriteLine("El nombre del cliente es " + clienteBuscado.nombre);
            Console.WriteLine("El apellido del cliente es " + clienteBuscado.apellido);
            Console.WriteLine("El DNI del cliente es " + clienteBuscado.DNI);
            Console.WriteLine("La fecha de inscripción del cliente fue " + clienteBuscado.fechaInscripcion);
            Console.WriteLine("El tipo de entrada del cliente es el tipo" + clienteBuscado.tipoEntrada);
            Console.WriteLine("El total abonado del cliente fue de $" + clienteBuscado.totalAbonado);
            }
        else System.Console.WriteLine("El cliente no existe");
    break;
    case 4:
        int idCambiar = Funciones.IngresarEntero("Ingrese el ID del cliente que quiere cambiar su entrada: ");
        int tipoEntradaCambio = Funciones.IngresarEntero("Ingrese el tipo de entrada al que desea cambiar: ");
        Ticketera.CambiarEntrada(idCambiar, tipoEntradaCambio, precioEntradas[tipoEntradaCambio]);
    break;
    case 5:
    break;
}
}while(opcion != 5);

void ObtenerEstadisticas(){
    List<string> estadisticas = new List<string>();
    estadisticas = Ticketera.EstadisticasTicketera();
    foreach (string msj in estadisticas)
    {
        Console.WriteLine(msj);
    }
}
void ingresarCliente(){
    int DNI, tipoEntrada,totalAbonado;
    string apellido, nombre;

    DateTime fechaInscripcion = DateTime.Today;

    DNI = Funciones.IngresarEntero("Ingrese DNI del cliente: ");
    apellido = Funciones.IngresarTexto("Ingrese apellido de la persona: ");
    nombre = Funciones.IngresarTexto("Ingrese el nombre del ciente: ");
    tipoEntrada = Funciones.IngresarEnteroEnRango("Ingrese la opcion de la entrada: 1 ($15000),2 ($30000),3 ($10000),4 ($40000): ",1,4);
    totalAbonado = precioEntradas[tipoEntrada];
    Ticketera.AgregarCliente(new Cliente(DNI,apellido,nombre,fechaInscripcion,tipoEntrada,totalAbonado));
    System.Console.WriteLine("El ID de entrada del nuevo cliente es " + Ticketera.DevolverUltimoID());
}
