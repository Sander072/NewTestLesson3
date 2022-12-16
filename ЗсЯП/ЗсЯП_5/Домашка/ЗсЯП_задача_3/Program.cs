Console.WriteLine("Сколько чисел в массиве будет?");
int a = int.Parse(Console.ReadLine());

FillingTheArray (a);

void FillingTheArray (int x)
{
    Random random = new Random();
    int[] array = new int [x];
    int n = 0;
    for (int i = 0; i < x; i++)
    {
        array [i] = random.Next(0,100);
    }
    int max = MaxArray (array);
    int min = MinArray (array);
    n = max - min;
    PrintArray (array);
    Console.WriteLine(n);
}

int MaxArray (int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

int MinArray (int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
} 