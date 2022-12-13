Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 100 && n > -100)
    Console.WriteLine("Третьей цифры нет."); 
else if (n > 99 && n < 1000 || n < -99 && n > -1000)
    Console.WriteLine(n % 10);
else 
    {
    while (n > 999 || n < -999)
    {
    n = n / 10;
    }
    Console.WriteLine(n % 10);
    }

/* or

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 0)
    n *= (-1);
if (n < 100)
    Console.WriteLine("Третьей цифры нет");
else
{
    while (n > 1000)
        n /= 10;
    Console.WriteLine(n % 10);
}

*/