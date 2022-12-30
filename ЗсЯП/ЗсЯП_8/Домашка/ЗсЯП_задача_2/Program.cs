Console.WriteLine("Введите количество строк");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int m = int.Parse(Console.ReadLine());

int[,] array = NewMatrix (n, m);
PrintMatrix (array, n, m);
MinSum (array, n, m);


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

void MinSum(int[,] array, int n, int m)
{
    int num = 0;
    int sumMin = 0;
    for (int i = 0; i < n; i++)
    {
        int sum = 0;
        for (int j = 0; j < m; j++)
        {
            sum = sum + array[i,j];
        }

        if (i == 0)
        {
            sumMin = sum;
            num = i;
        }

        if (sum < sumMin)
        {
            sumMin = sum;
            num = i;
        }
    }
    Console.WriteLine("Строка с наименьшей суммой - " + (num+1));
}