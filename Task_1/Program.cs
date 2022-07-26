
// Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Set the number of rows:");
int enterRows = int.Parse(Console.ReadLine());
Console.WriteLine("Set the number of columns:");
int enterColumns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[enterRows, enterColumns];
Console.WriteLine("Standart array:");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(100);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
int[] tempArray = new int[enterRows];

Console.WriteLine("Sorted array:");
for (int i = 0; i < enterRows; i++)
{
    for (int j = 0; j < enterColumns; j++)
        tempArray[j] = array[i, j];
    Array.Sort(tempArray);
    Array.Reverse(tempArray);
    for (int k = 0; k < enterRows; k++)
    {
        array[i, k] = tempArray[k];
        Console.Write("{0}\t", array[i, k]);
    }
    Console.WriteLine();
}


// Не совсем понял в какую сторону надо было сделать, сделал на всякий случай в обе.
// Console.WriteLine("Sorted array:");
// for (int i = 0; i < enterRows; i++)
// {
//     for (int j = 0; j < enterColumns; j++)
//         tempArray[j] = array[i, j];
//     Array.Sort(tempArray);
//         for (int k = 0; k < enterRows; k++)
//     {
//         array[i, k] = tempArray[k];
//         Console.Write("{0}\t", array[i, k]);
//     }
//     Console.WriteLine();
// }














