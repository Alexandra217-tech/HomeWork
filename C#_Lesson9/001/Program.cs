// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;
while (N>a-1)
{
    Console.Write (N);
    N=N-1;
}
