void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}


int ReleaseArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            sum++;
        }
    return sum;
}


Console.Clear();

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

InputArray(array);
Console.WriteLine($"Mассив: [{string.Join(", ", array)}]");
Console.WriteLine($"Количество четных чисел: {ReleaseArray(array)}");