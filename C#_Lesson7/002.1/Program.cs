// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int [,] matrix = new int[10, 12];
for (int i=0; i<matrix.GetLength(0); i++)
{
    for (int j=0; j<matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 100);
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();
}
Console.Write("Введите строку элемента: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("\nВведите столбец элемента: ");
int n = Convert.ToInt32(Console.ReadLine());

if ((m<=matrix.GetLength(0)+1)&&(n<=matrix.GetLength(1)+1))
{
    Console.Write(matrix[m, n]);
}
else
{
    Console.Write("такого числа в массиве нет");
}

