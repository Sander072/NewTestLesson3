int x =int.Parse(Console.ReadLine());
if (x < 10000 || x > 99999)
{
    Console.WriteLine("Введите число заново");
    x = int.Parse(Console.ReadLine());
}
if ((x-(x%10000))/10000 == x%10 && ((x-x%1000)/1000)%10 == (x%100-x%10)/10)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}