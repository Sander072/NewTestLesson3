Random random = new Random();
int n = random.Next(100,999);
Console.WriteLine(n);
int x = (n - (n%100))/100;
int y = n % 10;
int z;
Console.WriteLine(z = x*10 + y);
