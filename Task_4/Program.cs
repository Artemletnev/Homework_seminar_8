// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int firstSide = 3;
int secondSide = 3;
int thirdSide = 3;

int [,,] array = new int [firstSide,secondSide,thirdSide];
int startNumber = 10;
int sizeArray = firstSide * secondSide * thirdSide;
int maxPossibleArraySize = 100;
if( sizeArray < maxPossibleArraySize )
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            array[i,j,k] = startNumber + 1;
            startNumber++;
            Console.Write(array[i,j,k]+ $"({i},{j},{k})" + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
}
else
{
    Console.WriteLine("Not enough numbers to fill the array");
}

















