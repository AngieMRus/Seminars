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


void MeanColumns(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            average = average + matrix[i, j];
        }
        average = average / matrix.GetLength(0);
        Console.WriteLine($"Среднее арифметическое столбца № {j}: {average};");
    }
}


Console.Clear();
Console.Write("Введите размер двумерного массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Двумерный массив: ");
PrintMatrix(matrix);
Console.WriteLine();
MeanColumns(matrix);