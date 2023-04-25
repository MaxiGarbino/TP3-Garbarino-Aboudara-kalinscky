using System.Collections.Generic;
int opcion;
List<Cliente> listaClientes= new List<Cliente>();
do
{
    opcion = Funciones.IngresarEnteroEnRango("ingrese la opcion (1, 2, 3 o 4) ",1,4);
    switch (opcion)
    {
    case 1:
        int DNI, tipoEntrada,totalAbonado;
        string apellido, nombre;

        DateTime fechaInscripcion;
        DNI = Funciones.IngresarEntero("Ingrese DNI del cliente: ");
        apellido = Funciones.IngresarTexto("Ingrese apellido de la persona: ");
        nombre = Funciones.IngresarTexto("Ingrese el nombre del ciente: ");
        fechaInscripcion = Funciones.IngresarFecha("Ingrese la fecha de inscripcion");
        tipoEntrada = Funciones.IngresarEnteroEnRango("Ingrese la opcion de la entrada: 1 ($15000),2 ($30000),1 ($10000),1 ($40000)",1,4);
        int[] precioEntradas = {0,15000,30000,10000,40000};
        totalAbonado = precioEntradas[tipoEntrada];
        listaClientes.Add(new Cliente(DNI,apellido,nombre,fechaInscripcion,tipoEntrada,totalAbonado));

    break;
    case 2:
    break;
    case 3:
        Funciones.IngresarEntero("Ingrese el ID del cliente a buscar: ");
    break;
    case 4:
    break;
    case 5:
    break;
}
}while(opcion != 5);
