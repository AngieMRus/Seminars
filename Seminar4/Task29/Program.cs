Console.Clear();

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите {n} элемент(-а / -ов) массива через пробелы: ");
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

if (numbers.Length == n)
    Console.WriteLine($"Mассив: [{string.Join(", ", numbers)}]");
else Console.WriteLine("Несовпадение количества элементов массива. Повторите попытку.");