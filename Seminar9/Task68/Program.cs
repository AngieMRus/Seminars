int rec(int a, int b)
{
    if (a == 0)
        return b + 1;
    else
    if ((a > 0) && (b == 0))
      return rec(a - 1, 1);
    else
      return rec(a - 1, rec(a, b - 1));
}


Console.Write("Введите число > 0: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число > 0: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(m, n));