// Задача 39: Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] array = new int[10];
int[] array1 = array;
int A = 0;
int len = array.Length;
for (int i=0; i<len; i++)
{
    array[i] = new Random().Next(0, 100);
}
for (int h=0; h<len-1; h++)
{
    A = array[h];
    array[h]=array[h+1];
    array[h+1]=A;
}



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
PrintArray(array1);
