static class Ticketera{
    private static Dictionary<int, Cliente> dicClientes = new Dictionary<int, Cliente>();
    //clave int --> idEntrada       
    private static int ultimoIDEntrada = 0;
    public static int DevolverUltimoID(){
        return ultimoIDEntrada;
    }
    public static int AgregarCliente(Cliente cliente){
        ultimoIDEntrada++;
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
                System.Console.WriteLine("Cambio de tipo de entrada del tipo " + dicClientes[idEntrada].tipoEntrada + "al " + tipo + "Exitoso.");
                System.Console.WriteLine("Monto agregado: $" + (total - dicClientes[idEntrada].totalAbonado));
                dicClientes[idEntrada].tipoEntrada = tipo;
                dicClientes[idEntrada].totalAbonado = total;

            }
            else Console.WriteLine("No se pudo hacer el cambio porque el monto del tipo de entrada al que desea cambiar no es mayor al anterior");
        }
        else Console.WriteLine("No se pudo realizar el cambio porque el ID de la entrada no existe");
        return cambio;
    }
    public static List<string> EstadisticasTicketera(){
        List<string> estadisticas = new List<string>();
        estadisticas.Add("Hay " + dicClientes.Count() + " clientes inscriptos");
        int[] cantEntradaXTipo = {0,0,0,0,0};
        int[] recaudacionXTipo = {0,0,0,0,0};
        foreach (int id in dicClientes.Keys)
        {
            cantEntradaXTipo[dicClientes[id].tipoEntrada]++;
            recaudacionXTipo[dicClientes[id].tipoEntrada] += dicClientes[id].totalAbonado;
        }
        int recaudacionTotal = 0;
        double cantClientes = dicClientes.Count;
        for (int i = 1; i < recaudacionXTipo.Length; i++)
        {
            recaudacionTotal += recaudacionXTipo[i];
            estadisticas.Add ("El porcentaje de entradas del tipo " + i + " es " + (cantEntradaXTipo[i]*100 / cantClientes).ToString()+ "%");
            estadisticas.Add("La recudacion del tipo " + i + " es "+ recaudacionXTipo[i]);
        }
        estadisticas.Add("La recaudación total fue de $" + recaudacionTotal);
        return estadisticas;
    }
}