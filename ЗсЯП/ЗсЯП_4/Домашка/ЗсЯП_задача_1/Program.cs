float a = float.Parse(Console.ReadLine());
float b = float.Parse(Console.ReadLine());

Console.Write(NotPow(a,b));

float NotPow (float x, float y)
{
    float z = 1;
    if (y>=0)
    {
        for (int i = 1; i <= y; i++)
        {
           z = z*x;
        }
    }
    else
    {
        for (int i = 1; i <= -y; i++)
        {
           z = z/x;
        }
    }
    return z;
}
