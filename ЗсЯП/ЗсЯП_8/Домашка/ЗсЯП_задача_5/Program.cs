
int[,] array = NewMatrix ();
PrintMatrix (array);



int [,] NewMatrix ()
{
    int[,] array = new int[4, 4];
    Random random = new Random();
    int n = 0;
    for (int i = 0; i < 4; i++)
    {
        array[0,i] = n;
        n++;
    }

    for (int i = 1; i < 4; i++)
    {
        array[i,3] = n;
        n++;
    }

    for (int i = 2; i >= 0; i--)
    {
        array[3,i] = n;
        n++;
    }

    for (int i = 2; i >= 1; i--)
    {
        array[i,0] = n;
        n++;
    }

    for (int i = 1; i < 3; i++)
    {
        array[1,i] = n;
        n++;
    }

    for (int i = 2; i > 0; i--)
    {
        array[2,i] = n;
        n++;
    }

    return array;
}

void PrintMatrix (int[,] array)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write($"0{array[i, j]}" + " ");
            }
            else
            { 
            Console.Write(array[i, j] + " "); 
            }
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}

