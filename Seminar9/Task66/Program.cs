﻿int rec(int m, int n)
{
    if (n < m)
        return 0;
    return rec(m, n - 1) + n;
}


Console.Clear();
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(m, n));