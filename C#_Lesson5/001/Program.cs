//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
int[] array = new int[5];
int CountEven = 0;
void FillArray (int [] collection)
{
    int len = collection.Length;
    for (int i=0; i<len; i++)
    {
        collection[i] = new Random().Next(100, 999);
    }
    for (int h=0; h<len; h++)
    {
        if (collection[h]%2==0) 
        {
            CountEven = CountEven + 1;
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
PrintArray(array);
Console.WriteLine (CountEven);

