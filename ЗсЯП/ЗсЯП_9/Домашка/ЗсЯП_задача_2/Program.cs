Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());

int sum = 0;
NaturalRecursionSum(n, m, sum);

void NaturalRecursionSum(int n, int m, int sum)
{
    if(n == m)
    {
        sum = sum + n;
        Console.WriteLine(sum);
        return;
    }
    sum = sum + n;
    n++;
    NaturalRecursionSum(n, m, sum);
}