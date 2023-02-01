//  Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[10];
int sum = 0;
int len = array.Length;
for (int i=0; i<len; i++)
{
    array[i] = new Random().Next(0, 150);
}
for (int h=0; h<len; h++)
{
    if (h%2!=0) 
    {
       sum = sum + array [h];
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

//PrintArray(array);
Console.WriteLine (sum);
