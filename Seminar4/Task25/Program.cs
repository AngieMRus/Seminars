Console.Clear();

Console.Write("Введите число: ");
double n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
double m = Convert.ToInt32(Console.ReadLine());

double result = 1;

for (int count = 0; count < m; count++)
    result = result * n;

Console.WriteLine($"{n} ^ {m} = {result}");