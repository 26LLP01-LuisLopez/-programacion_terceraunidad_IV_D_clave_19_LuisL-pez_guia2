internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matriz = new int[4, 4];
        int mayor = 0;
        int filaMayor = 0;
        int columnaMayor = 0;

        for (int fila = 0; fila < 4; fila++)
        {
            for (int columna = 0; columna < 4; columna++)
            {
                matriz[fila, columna] = Convert.ToInt32(Console.ReadLine());

                if (fila == 0 && columna == 0)
                {
                    mayor = matriz[fila, columna];
                }
                else if (matriz[fila, columna] > mayor)
                {
                    mayor = matriz[fila, columna];
                    filaMayor = fila + 1;
                    columnaMayor = columna + 1;
                }
            }
        }
        Console.WriteLine("Mayor: " + mayor);
        Console.WriteLine("Fila: " + filaMayor);
        Console.WriteLine("Columna: " + columnaMayor);
    }
}