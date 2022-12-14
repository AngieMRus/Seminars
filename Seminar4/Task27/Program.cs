Console.Clear();

Console.Write("Введите число: ");
double n = Convert.ToInt32(Console.ReadLine());

double sum = 0;
int count = 0;

while (n > 0 || n < 0)
{
    sum = sum + n % 10;
    count++;
}

Console.WriteLine(sum);