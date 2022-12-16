Console.WriteLine("Сколько чисел в массиве будет?");
int a = int.Parse(Console.ReadLine());

FillingAndCheckTheArray (a);

void FillingAndCheckTheArray (int x)
{
    Random random = new Random();
    int[] array = new int [x];
    int n = 0;
    for (int i = 0; i < x; i++)
    {
        array [i] = random.Next(-100,100);
        if (i % 2 == 1)
        {
            n = n + array [i];
        }
    }
    PrintArray (array);
    Console.WriteLine(n);
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