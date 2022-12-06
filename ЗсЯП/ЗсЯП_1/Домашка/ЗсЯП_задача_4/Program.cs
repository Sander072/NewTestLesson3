int x = int.Parse(Console.ReadLine());

for (int i = 1; i < x + 1; i++)
{
    if (i == 2)  
    {
        Console.Write(i);
    }
    if (i % 2 == 0 && i > 2) 
    {
        Console.Write(", " + i);
    } 
}