//  Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int Akkerman (int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return Akkerman(M - 1, 1);
    if (M > 0 && N > 0) return Akkerman(M - 1, Akkerman(M, N - 1));
return Akkerman(M, N);
}

Console.WriteLine(Akkerman(m, n));

