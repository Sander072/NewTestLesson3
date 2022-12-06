namespace Common;
public static int max2 (int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}

public static int GetNumberOfQuarter(int x, int y)
    {
        if (x > 0 && y > 0)
        {
            return 1;
        }

        if (x < 0 && y > 0)
        {
            return 2;
        }

        if (x < 0 && y < 0)
        {
            return 3;
        }

        if (x > 0 && y < 0)
        {
            return 4;
        }

        return -1;
    }