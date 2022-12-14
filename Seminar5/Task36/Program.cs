void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}


Console.Clear();

int[] array = new int[10];
InputArray(array);
Console.WriteLine($"Mассив: [{string.Join(", ", array)}]");

Console.WriteLine($"Максимальный элемент массива: " + array.Max());
Console.WriteLine($"Минимальный элемент массива: " + array.Min());

Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {array.Max() - array.Min()}");