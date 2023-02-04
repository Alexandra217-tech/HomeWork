// Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
while (M<N+1)
{
    Console.Write (M);
    M++;
}