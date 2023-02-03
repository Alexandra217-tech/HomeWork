// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение b1: ");
float b1 = Convert.ToSingle(Console.ReadLine());
Console.Write("\nВведите значение k1: ");
float k1 = Convert.ToSingle(Console.ReadLine());
Console.Write("\nВведите значение b2: ");
float b2 = Convert.ToSingle(Console.ReadLine());
Console.Write("\nВведите значение k2: ");
float k2 = Convert.ToSingle(Console.ReadLine());
float y=0;
float x=0;
if ((k1==k2)&&(b1==b2))
{
    Console.WriteLine ("Прямые совпадают");
}
if (k1==k2)
{
    Console.WriteLine ("Прямые параллельны");
}
else
{
    x = (b2-b1)/(k1-k2);
    y = (k1*(b2-b1))/(k1-k2)+b1;
    Console.WriteLine ($"(({x});({y}))");
}


