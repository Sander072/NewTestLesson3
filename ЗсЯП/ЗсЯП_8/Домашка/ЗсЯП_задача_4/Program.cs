Console.WriteLine("Введите количество строк");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите глубину");
int z = int.Parse(Console.ReadLine());

int[,,] array = NewMatrix (n, m, z);
PrintMatrix (array, n, m, z);


int [,,] NewMatrix (int n, int m, int z)
{
    int[,,] array = new int[n, m, z];
    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < z; k++)
            {
                int x = 0; //Проверка
                array[i,j,k] = random.Next(10,100);
                while (x == 0)
                {
                    int c = 0; //Проверка 2
                    for (int v = 0; v < n; v++)
                    {
                        for (int b = 0; b < m; b++)
                        {
                            for (int l = 0; l < z; l++)
                            {
                                if ((i == v) && (j == b) && (k == l))
                                {
                                    //что бы цикл не трогал изменяемый эллемент
                                }
                                else
                                {
                                    if (array[i,j,k] == array[v,b,l])
                                    {
                                        array[i,j,k] = random.Next(10,100); 
                                        c = c + 1;
                                        //Console.WriteLine("смена");
                                    }
                                }
                            }
                        }
                    }
                    if (c == 0)
                    {
                        x = 1;
                    }
                }
            }
        }
    }
    return array;
}

void PrintMatrix (int[,,] array, int n, int m, int z)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < m; k++)
            {
                Console.WriteLine(array[i, j, k] + "(" + i + "," + j + "," + k + ")"); 
            }
        }
    }
}
