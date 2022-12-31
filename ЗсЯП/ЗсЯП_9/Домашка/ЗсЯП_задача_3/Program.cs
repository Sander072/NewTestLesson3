Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());

int x = AckermanIsNotFromTheAttackOfTheTitans(n, m);
Console.WriteLine(x);

int AckermanIsNotFromTheAttackOfTheTitans(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else
    {
        if ((n != 0) && (m == 0))
        {
            return AckermanIsNotFromTheAttackOfTheTitans(n - 1, 1);
        }
        else
        {
            return AckermanIsNotFromTheAttackOfTheTitans(n - 1, AckermanIsNotFromTheAttackOfTheTitans(n, m - 1));
        }
    }
}