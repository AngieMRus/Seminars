Console.Clear();

Console.Write("Введите любые числа через пробелы, а затем нажмите клавишу Enter: ");
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int sum = 0;

for (int count = 0; count < numbers.Length; count++)
{
    if (numbers[count] > 0)
    {
        sum++;
    }
}
Console.WriteLine(sum);