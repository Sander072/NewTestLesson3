Console.WriteLine("Введите b1");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите k1");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = double.Parse(Console.ReadLine());

IntersectionPoint (b1, k1, b2, k2);

void IntersectionPoint (double b1, double k1, double b2, double k2)
{
    double x;
    double y;

    //k1*x+b1=k2*x+b2
    //k1*x-k2*x=b2-b1
    //x(k1-k2)=b2-b1
    //x=(b2-b1)/(k1-k2)

    if (k1-k2 != 0)
    {
        x = (b2-b1)/(k1-k2);
        y = k1*x + b1;
        Console.WriteLine();
        Console.WriteLine("(" + x + ");(" + y + ")");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Прямые с такими значениями не пересекаются"); 
    }
}
