Console.WriteLine("Сколько чисел в массиве будет?");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите числа");

int[] array = NewArray (a);
GreaterThanZero (array, a);

void GreaterThanZero (int[] x, int a)
{
    int n = 0;
    for (int i = 0; i < a; i++)
    {
       if (x[i] > 0)
       {
            n = n + 1;
       }
    }
    Console.WriteLine();
    Console.WriteLine(n);
}

int[] NewArray (int x)
{
    int[] array = new int [x];
    for (int i = 0; i < x; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}