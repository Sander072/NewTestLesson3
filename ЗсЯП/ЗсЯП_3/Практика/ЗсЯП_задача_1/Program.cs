int number = int.Parse(Console.ReadLine());
Console.WriteLine(GetRangeByNumberQarder(number));

string GetRangeByNumberQarder (int number)
{
    if (number == 1)
    {
        return "x > 0; y > 0";
    }
    else if (number == 2)
    {
        return "x > 0; y < 0";
    }
    else if (number == 3)
    {
        return "x < 0; y < 0";
    }
    else if (number == 4)
    {
        return "x < 0; y > 0";
    }
    return "-1";
}