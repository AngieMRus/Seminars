Console.Clear();

Console.Write("Введите значение переменной b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение переменной k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение переменной b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение переменной k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double intersection = (b2 - b1) / (k1 - k2);

Console.WriteLine($"Точка пересечения двух прямых: {intersection}");