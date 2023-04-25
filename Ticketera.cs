static class Ticketera{
    private static Dictionary<int, Cliente> dicClientes;
    //clave int --> idEntrada       
    private static int ultimoIDEntrada = 1;
    public static int DevolverUltimoID(){
        return ultimoIDEntrada;
    }
    public static int AgregarCliente(Cliente cliente){
        if (ultimoIDEntrada != 1) ultimoIDEntrada++;
        dicClientes.Add(ultimoIDEntrada, cliente);
        return ultimoIDEntrada;
    }
    public static Cliente BuscarCliente(int idEntrada){
        if (dicClientes.ContainsKey(idEntrada)) {
            return dicClientes[idEntrada];
        }
        return new Cliente();
    }

    public static bool CambiarEntrada(int idEntrada, int tipo, int total){
        bool cambio = false;
        if (dicClientes.ContainsKey(idEntrada)) {
            if (dicClientes[idEntrada].totalAbonado < total) {
                cambio = true;
                dicClientes[idEntrada].tipoEntrada = tipo;
            }
            else Console.WriteLine("No se pudo hacer el cambio porque el monto del tipo de entrada al que desea cambiar no es mayor al anterior");
        }
        else Console.WriteLine("No se pudo realizar el cambio porque el ID de la entrada no existe");
        return cambio;
    }
    public static List<string> EstadisticasTicketera(){
        List<string> estadisticas = new List<string>();
        estadisticas.Add(dicClientes.Count().ToString());
        return estadisticas;
    }
}