internal class Program
{
    private static void Main(string[] args)
    {
        string[,] donas = new string[2, 4];
        donas[0, 1] = "chocolate";

        donas[0, 2] = "fresa";

        donas[0, 3] = "vainilla";

        donas[0, 4] = "glaseado";

        donas[1, 1] = "caramelo";

        donas[1, 2] = "cafe";

        donas[1, 3] = "limon";

        donas[1, 4] = "canela";
        for (int fila = 0; fila < 2; fila++)
        {
            for (int columnas = 0; columnas < 4; columnas++)
            {
                Console.WriteLine(donas[fila, columnas] + " | ");
            }
            Console.WriteLine();
        }

    }
}