namespace tarea1
{
    class program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("Area de un Cuadrado");
        int resp = calcularAreaCuadrado(10);
        Console.WriteLine(resp);
    }
    static int calcularAreaCuadrado(int L){
        int resultado = L*L;
        return resultado;
    }
    }
}

