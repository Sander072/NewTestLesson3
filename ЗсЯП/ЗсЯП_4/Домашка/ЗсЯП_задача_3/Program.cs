Console.WriteLine("Сколько чисел в массиве будет?");
int a = int.Parse(Console.ReadLine());
int[] result = new int [a];
Console.WriteLine("Заполняйте)");

FillingTheArray (a, result);
PrintArray (result);

int[] FillingTheArray (int x, int[] array)
{
    for (int i = 0; i < x; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
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