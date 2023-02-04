// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
//Ввод чисел останавливается при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter

Console.Write("Введите количество элементов массива: ");
int M = Convert.ToInt32(Console.ReadLine());
string st = "stop";
string [] array = new string[M];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}: ");
    array[i] = Console.ReadLine();
    if (array[i]==st)
    {
        break;
    }
}
int [] number = new int [array.Length];
for (int i = 0; i < number.Length-1; i++)
{
    number[i] = Convert.ToInt32(array[i]);
    if (number[i]>0)
    {
        count++;
    }
}


void PrintArray (int [] coll)
{
    int count =coll.Length;
    for (int j=0; j<count; j++)
    {
        Console.WriteLine (coll[j]);
    }
}

Console.WriteLine (count);
//Console.WriteLine (array.Length);
//PrintArray(number);
