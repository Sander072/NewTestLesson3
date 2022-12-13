double EnterNumber(string text)
{
    bool isParsed = false;
    double number = 0;

    while (!isParsed)
    {
        Console.Write(text);
        isParsed = double.TryParse(Console.ReadLine(), out number);
    }
    return number;
}

double x1 = EnterNumber("Введите x1: ");
double y1 = EnterNumber("Введите y1: ");
double z1 = EnterNumber("Введите z1: ");
double x2 = EnterNumber("Введите x2: ");
double y2 = EnterNumber("Введите y2: ");
double z2 = EnterNumber("Введите z2: ");

double result = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));

Console.WriteLine(result);