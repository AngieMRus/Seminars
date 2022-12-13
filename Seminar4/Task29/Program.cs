Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = 0;

if (n > 0)
{
    for (int count = 0; n > 0; count++)
        sum = sum + n % 10;
    Console.WriteLine(sum);
}

else if (n < 0)
{
    for (int count = 0; n < 0; count++)
        sum = (sum + n % 10) * (-1);
    Console.WriteLine(sum);
}

else Console.WriteLine("0");