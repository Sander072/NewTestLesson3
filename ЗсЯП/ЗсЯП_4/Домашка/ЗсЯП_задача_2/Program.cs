int a = int.Parse(Console.ReadLine());

Console.Write(SumOfFigure(a));

int SumOfFigure (int x)
{
    int z = 0;
    while (x>0)
    {
        z = z + x%10;
        x = x/10;
    }
    return z;
}