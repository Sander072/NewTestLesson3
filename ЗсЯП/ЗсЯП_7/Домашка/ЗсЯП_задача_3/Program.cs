Console.WriteLine("Введите количество строк");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int m = int.Parse(Console.ReadLine());


int[,] array = NewMatrix (n, m);
PrintMatrix (array, n, m);
PrintSRMatrix (array, n, m);


int [,] NewMatrix (int n, int m)
{
    int[,] array = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = random.Next(10,100);
        }
    }
    return array;
}

void PrintMatrix (int[,] array, int n, int m)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write(array[i, j] + " "); 
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}

void PrintSRMatrix (int[,] array, int n, int m)
{
    for (int i = 0; i < m; i++)
    {
        int sum = 0;
        int kol = 0;
        for (int j = 0; j < n; j++)
        {
            sum = sum + array[j,i];
            kol = kol + 1;
        }
        Console.Write(sum/kol + " ");
    }
}