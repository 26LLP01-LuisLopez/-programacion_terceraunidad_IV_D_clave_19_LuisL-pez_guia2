internal class Program
{
    private static void Main(string[] args)
    {
        int[,] tabla = new int[4, 4];
        for (int fila = 0; fila < 4; fila++)
        {
            for (int columna = 0; columna < 4; columna++)
            {
                if (fila == columna)
                    tabla[fila, columna] = 1;
                else
                    tabla[fila, columna] = 0;
            }
        }
    }
}