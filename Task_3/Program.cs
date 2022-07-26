//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Enter the array rows numbers:");
int enterRows = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the array columns numbers");
int enterColumns = int.Parse(Console.ReadLine());



if (enterRows == enterColumns)
{
    int[,] Getarray(int m, int n, int minValue, int maxValue)
    {
        int[,] matrix = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = new Random().Next(minValue, maxValue + 1);
            }
        }
        return matrix;
    }
    void PrintArray(int[,] inputArray)
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(1); j++)
            {
                Console.Write(inputArray[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine("The first matrix:");
    int[,] firstArray = Getarray(enterRows, enterColumns, 0, 10);
    PrintArray(firstArray);
    Console.WriteLine();
    Console.WriteLine("The second matrix:");
    int[,] secondArray = Getarray(enterRows, enterColumns, 0, 10);
    PrintArray(secondArray);
    Console.WriteLine();
    Console.WriteLine("The finish matrix:");
    int[,] finishArray = new int[enterRows, enterColumns];
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < firstArray.GetLength(1); j++)
        {
            finishArray[i, j] = firstArray[i, j] * secondArray[i, j];
            Console.Write(finishArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Error. It is impossible to multiply, the matrices are different");
}






