Console.Clear();

Console.Write("Введите число: ");
double n = Convert.ToInt32(Console.ReadLine());
double sum = 0;

while (n >= 1 || n <= (-1))
{
    sum += n % 10;
    Console.WriteLine($"Сумма цифр в исходном числе: {sum}");
}