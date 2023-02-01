// Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] array = new int[10];
int max = array[0];
int difference = 0;
int len = array.Length;
for (int i=0; i<len; i++)
{
    array[i] = new Random().Next(0, 150);
}
for (int h=1; h<len; h++)
{
    if (array[h]>max) 
    {
       max = array[h];
    }
}
int min = max;
for (int h=0; h<len; h++)
{
    if (array[h]<min) 
    {
       min = array[h];
    }
}


difference=max-min;

void PrintArray (int [] coll)
{
    int count =coll.Length;
    for (int j=0; j<count; j++)
    {
        Console.WriteLine (coll[j]);
    }
}

PrintArray(array);
Console.WriteLine ();
Console.WriteLine (difference);