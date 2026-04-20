int filas ()
{
    int fila;
    bool vFila;
    while (true)
    {
        Console.WriteLine("Ingrese numero de filas: ");
        vFila=int.TryParse(Console.ReadLine(), out fila);
        if (vFila && fila>0)
        {
            return fila;
        }
        else
        {
            Console.WriteLine("Invalido");
            Console.WriteLine("Presione cualquier tecla para volver a intentar");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
int resultadoFilas = filas();

int columnas()
{
    int columna;
    bool vColumna;
    while (true)
    {
        Console.WriteLine("Ingrese numero de columnas: ");
        vColumna = int.TryParse(Console.ReadLine(), out columna);
        if (vColumna &&columna > 0)
        {
            return columna;
        }
        else
        {
            Console.WriteLine("Invalido");
            Console.WriteLine("Presione cualquier tecla para volver a intentar");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
int resultadoColumnas = columnas();

int[,] matriz = new int[resultadoFilas, resultadoColumnas];

for (int i = 0; i < resultadoFilas; i++)
{
    for (int j = 0; j < resultadoColumnas; j++)
    {
        int valor;

        while (true)
        {
            Console.Write($"Ingrese valor para la posicion indicada [{i},{j}]: ");

            if (int.TryParse(Console.ReadLine(), out valor))
            {
                matriz[i, j] = valor;
                break;
            }
            else
            {
                Console.WriteLine("Invalido");
                Console.WriteLine("Presione cualquier tecla para volver a intentar");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Matriz:");
Console.WriteLine();
for (int i = 0; i < resultadoFilas; i++)
{
    for (int j = 0; j < resultadoColumnas; j++)
    {
        Console.Write($"{matriz[i, j]} ");
    }
    Console.WriteLine();
}