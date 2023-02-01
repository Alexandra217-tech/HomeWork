// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] array = new int[123];
int CountElemets = 0;
void FillArray (int [] collection)
{
    int len = collection.Length;
    for (int i=0; i<len; i++)
    {
        collection[i] = new Random().Next(0, 150);
    }
    for (int h=0; h<len; h++)
    {
        if (collection[h]>9) 
        {
            if (collection[h]<100)  
            {
                CountElemets = CountElemets + 1;
            }
        }
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

FillArray(array);
//PrintArray(array);
Console.WriteLine (CountElemets);