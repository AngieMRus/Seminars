Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;

if (n > 0)
{
    while (n >= 1)
    {
        sum = sum + n % 10;
        n = n / 10;
    }
    Console.WriteLine($"Сумма цифр в исходном числе: {sum}");
}
else if (n < 0)
{
    while (n <= (-1))
    {
        sum = sum + n % 10;
        n = n / 10;
    }
    Console.WriteLine($"Сумма цифр в исходном числе: {sum * (-1)}");
}
else Console.WriteLine("0. Повторите попытку.");