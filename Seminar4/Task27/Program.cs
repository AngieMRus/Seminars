﻿Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int count = 0;

while (n > 0 || n < 0)
{
    sum = sum + n % 10;
    count++;
}

Console.WriteLine($"Сумма цифр в исходном числе: {sum}");