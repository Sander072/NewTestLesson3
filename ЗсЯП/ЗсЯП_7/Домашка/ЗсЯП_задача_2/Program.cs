Console.WriteLine("Введите количество строк");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите позицию эллемента в массиве");
int n1 = int.Parse(Console.ReadLine());
int m1 = int.Parse(Console.ReadLine());

int[,] array = NewMatrix (n, m);
SearchInMatrix (array, n, m, n1, m1);


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

void SearchInMatrix (int[,] array, int n, int m, int n1, int m1)
{
    if ((n > n1) && (m > m1) && (m1 >= 0) && (n1 >= 0)) 
    {
       Console.WriteLine(array[n1, m1]);
    }
    else
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
}