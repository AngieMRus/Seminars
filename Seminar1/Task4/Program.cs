Console.Clear();

Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int l = Convert.ToInt32(Console.ReadLine());

if (n >= m && n >= l)
    Console.WriteLine(n);
else if (l >= m && l >= n)
    Console.WriteLine(l);
else
    Console.WriteLine(m);