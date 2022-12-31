Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

NaturalRecursion(n);

void NaturalRecursion(int n)
{
    if(n == 1)
    {
        Console.WriteLine(n);
        return;
    }
    Console.WriteLine(n);
    n--;
    NaturalRecursion(n);
}