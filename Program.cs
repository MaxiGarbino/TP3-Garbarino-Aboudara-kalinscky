using System.Collections.Generic;
int opcion;
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
