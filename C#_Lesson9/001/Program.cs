// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;
while (a<N+1)
{
    Console.Write (a);
    a++;
}
