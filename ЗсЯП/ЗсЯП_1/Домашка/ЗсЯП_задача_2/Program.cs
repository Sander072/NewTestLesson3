int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int z = int.Parse(Console.ReadLine());

if (x > y)
{
    if (z > x)
    {
        Console.WriteLine("max = " + z);
    }
    else
    {
        Console.WriteLine("max = " + x); 
    }
}
else
{
    if (z > y)
    {
        Console.WriteLine("max = " + z);
    }
    else
    {
        Console.WriteLine("max = " + y); 
    }
}
