internal class Program
{
    private static void Main(string[] args)
    {
        int[,] edades = new int[3, 3];
        for (int fila = 0; fila < 3; fila++)
        {
            for (int columna = 0; columna < 3; columna++)
            {
                Console.Write($"Ingrese la edad [{fila},{columna}]: ");
                edades[fila, columna] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("\nResultado:");

        for (int fila = 0; fila < 3; fila++)
        {
            for (int columna = 0; columna < 3; columna++)
            {
                if (edades[fila, columna] >= 18)
                    Console.Write(edades[fila, columna] + " - mayor\t");
                else
                    Console.Write(edades[fila, columna] + " - menor\t");
            }
            Console.WriteLine();
        }
    }
}
