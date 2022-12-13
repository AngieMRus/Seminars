Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
int m = Convert.ToInt32(Console.ReadLine());

if (m > 0)
{
double result = 1;

for (int count = 0; count < m; count++)
    result = result * n;

Console.WriteLine($"{n} ^ {m} = {result}");
}
else Console.WriteLine("Внимание! Степень должна быть > 0. Повторите попытку.");