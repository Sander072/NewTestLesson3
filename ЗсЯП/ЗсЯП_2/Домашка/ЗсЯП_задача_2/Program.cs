int x = int.Parse(Console.ReadLine());
int y = x;
int n = 1;

while (y > 9)
{
    n = n + 1;
    y = y / 10;
}

if (n > 2)
{
    for (int i = 1; i < n+1-3; i++)
    {
        x = x / 10;
    }
    x = x % 10;

    Console.WriteLine(x);
}
else
{
    Console.WriteLine("третьей цифры нет");
}