Console.Clear();

Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 99 && n < 1000)
    Console.WriteLine((n % 100) / 10);
else if (n < -99 && n > -1000)
    Console.WriteLine(-(n % 100) / 10);
else
    Console.WriteLine("Неверные исходные данные. Повторите попытку.");