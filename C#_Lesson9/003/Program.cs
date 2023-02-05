// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
void sumNumber(int n)
{
    if (n<=0) return;
    sumNumber(n/10);
    sum+=n%10;
    Console.WriteLine(sum);
}
sumNumber(number);
Console.WriteLine(sum);
 