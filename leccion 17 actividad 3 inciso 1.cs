internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matriz = new int[4, 3];
        for (int fila = 0; fila < 4; fila++)
        {
            int suma = 0;
            for (int columna = 0; columna < 3; columna++)
            {
                matriz[fila, columna] = Convert.ToInt32(Console.ReadLine());
                suma += matriz[fila, columna];
            }
            Console.WriteLine("Suma fila " + (fila + 1) + ": " + suma);
        }
    }
}