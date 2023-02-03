// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("\nВведите количество столбцов: ");
int n= Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double[m, n];
for (int i=0; i<matrix.GetLength(0); i++)
{
    for (int j=0; j<matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(-99, 99) / 10.0;
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();
}
