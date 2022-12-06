Console.Clear();

Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 99 && n < 1000)
{
    string s = Convert.ToString(n);
    Console.WriteLine(s[1]);
}
else if (n < -99 && n > -1000)
{
    string s = Convert.ToString(n);
    Console.WriteLine(s[2]);
}
else
    Console.WriteLine("Неверные исходные данные. Повторите попытку.");