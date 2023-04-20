static class Ticketera{
    private static Dictionary<int, Cliente> dicClientes;
    private static int ultimoIDEntrada = 0;
    static int DevolverUltimoID(){
        return ultimoIDEntrada;
    }
    static int AgregarCliente(Cliente cliente){
        ultimoIDEntrada++;
        dicClientes.Add(ultimoIDEntrada, cliente);
        return ultimoIDEntrada;
    }
    static Cliente BuscarCliente(int idEntrada){
        if (dicClientes[idEntrada])
    }
    static bool CambiarEntrada(int Id, int tipo, int total){
        
    }
    static List<string> EstadisticasTicketera(){

    }
}