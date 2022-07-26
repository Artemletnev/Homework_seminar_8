
// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Set the number of rows:");
int enterRows = int.Parse(Console.ReadLine());
Console.WriteLine("Set the number of columns:");
int enterColumns = Convert.ToInt32(Console.ReadLine());
if (enterColumns != enterRows)
{
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
    int currentMinStringValue = int.MaxValue;
    int currentIndexMinString = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumElementsRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumElementsRow = sumElementsRow + array[i, j];
        }
        Console.WriteLine("The sum of the elements in row " + (i + 1) + "=" + sumElementsRow);
        if (sumElementsRow < currentMinStringValue)
        {
            currentMinStringValue = sumElementsRow;
            currentIndexMinString = i;
        }
    }
    Console.WriteLine("The row with the smallest sum of elements:" + (currentIndexMinString + 1) );





}
else
{
    Console.WriteLine("Error, the number of columns and rows cannot be the same. ");
}



//   int arrayRows = 5;
//     int arrayColumns = 4;
//     int arrayMaxValue = 10;
//     int arrayMinValue = 1;

//     Console.WriteLine("Исходный массив:");
//     int[,] array = new int[arrayRows, arrayColumns];

//     int currentMinStringValue = Int32.MaxValue;
//     int currentIndexMinString = -1;

//     for (int i = 0; i < arrayRows; i++)
//     {
//         int sumStringElement = 0;
//         for (int j = 0; j < arrayColumns; j++)
//         {
//             array[i, j] = new Random().Next(arrayMinValue, arrayMaxValue);
//             Console.Write(array[i, j] + "\t|");
//             sumStringElement += array[i, j];
//         }
//         Console.WriteLine("<-- row " + (i + 1) + " sum = " + sumStringElement);
//         if (sumStringElement < currentMinStringValue)
//         {
//             currentMinStringValue = sumStringElement;
//             currentIndexMinString = i;
//         }
//     }

//     Console.WriteLine("Строка с наименьшей суммой элементов: \nrow " + (currentIndexMinString + 1) + " sum = " + currentMinStringValue);









