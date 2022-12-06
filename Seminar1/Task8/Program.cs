Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());


if (n < 0)
    {
    int i = -2;
    while (i >= n)
    {
        Console.Write($"{i} ");
        i = i - 2;
    }}
else
    {
    int i = 2;
    while (i <= n)
    {
        Console.Write($"{i} ");
        i = i + 2;
    }}

/*

int i = 2;
while (i <= n)
{
    Console.Write($"{i} ");
    i = i + 2;
}

*/