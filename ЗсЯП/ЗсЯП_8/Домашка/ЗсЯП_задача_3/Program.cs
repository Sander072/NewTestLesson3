Console.WriteLine("Введите количество строк первой матрицы");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы");
int m1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество строк второй матрицы");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы");
int m2 = int.Parse(Console.ReadLine());

if (m1 == n2)
{
    int[,] array1 = NewMatrix (n1, m1);
    PrintMatrix (array1, n1, m1);
    int[,] array2 = NewMatrix (n2, m2);
    PrintMatrix (array2, n2, m2);

    arrayMultip (array1, array2);
}
else
{
    Console.WriteLine("Произведения не существует");
}

int [,] NewMatrix (int n, int m)
{
    int[,] array = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = random.Next(1,10);
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

void arrayMultip(int[,] array1, int[,] array2)
{
    int[,] arrayFinal = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                arrayFinal[i,j] = arrayFinal[i,j] + (array1[i,k] * array2[k,j]);
                //Поэтапная проверка
                /*
                Console.WriteLine("промежуточное " + arrayFinal[i,j]);
                Console.WriteLine(array1[i,k] + " * " + array2[k,j]);
                Console.WriteLine(" + " + (array1[i,k] * array2[k,j]));
                */
            }
            //Поэтапная проверка
            /*
            Console.WriteLine(" = " + arrayFinal[i,j]);
            */
        }
    }

    PrintMatrix (arrayFinal, arrayFinal.GetLength(0), arrayFinal.GetLength(1));
}