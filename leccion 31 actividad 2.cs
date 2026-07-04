internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matriz = new int[4, 4];
        for (int fila = 0; fila < 4; fila++)
        {
            for (int columna = 0; columna < 4; columna++)
            {
                if (fila == columna)
                    matriz[fila, columna] = 1;
                else
                    matriz[fila, columna] = 0;
            }
        }
        Console.WriteLine("Matriz:");
        for (int fila = 0; fila < 4; fila++)
        {
            for (int columna = 0; columna < 4; columna++)
            {
                Console.Write(matriz[fila, columna] + " ");
            }
            Console.WriteLine();
        }
    }
}