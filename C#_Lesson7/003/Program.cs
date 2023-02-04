// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] array2 = new int[5, 6];
double sum = 0;
int count =0;
double SrArifm =0;
for (int i=0; i<array2.GetLength(0); i++)
{
    for (int j=0; j<array2.GetLength(1); j++)
    {
        array2[i, j] = new Random().Next(0, 10);
        Console.Write(array2[i, j]);
    }
    Console.WriteLine();
}
Console.Write("----------------------------");
    
for (int i=0; i<6; i++)
{
    for (int j=0; j<5; j++)
    {
        sum += array2[j, i];
        count++;
    }
    Console.WriteLine("  ");
    Console.WriteLine(SrArifm=sum/count);
}