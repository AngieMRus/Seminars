void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
    }
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите размер двумерного массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Двумерный массив: ");
PrintMatrix(matrix);
Console.Write("Введите позиции элемента в массиве: ");
int[] positions = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (positions[0] > size[0] || positions[1] > size[1])
{   Console.WriteLine("Такой позиции в массиве нет. Введите позиции элемента в массиве: ");
    positions = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
object element = matrix.GetValue(positions[0] - 1, positions[1] - 1);
Console.WriteLine($"Значение элемента: {element}");