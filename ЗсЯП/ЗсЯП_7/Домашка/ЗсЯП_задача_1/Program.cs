Console.WriteLine("Введите количество строк");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int m = int.Parse(Console.ReadLine());


double[,] array = NewDoubleMatrix (n, m);
PrintMatrix (array);


double [,] NewDoubleMatrix (int n, int m)
{
    double[,] array = new double[n, m];
    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = (random.NextDouble()*100) - 50;
        }
    }
    return array;
}

void PrintMatrix (double[,] array)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write(array[i, j] + " "); 
        }
        Console.WriteLine("");
    }
}
