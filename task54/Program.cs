// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomMatrix(int rows, int columns, int leftRange = 0, int rightRange = 10)
{
    int[,] matr = new int [rows, columns];
    var rand = new Random();
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// int minArray(int [,]matr)
// {
//     int min = 0;
//     for(int i = 0; i < matr.GetLength(0); i++)
//     {
//         for(int j = 0; j < matr.GetLength(1); j++)
//         {
//             if(min > matr[i, j])
//             {
//                 min = matr[i, j];
//             }
//         }
//     }
//     return min;
// }

int[,] newMatrix(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        int[] array = new int[matr.GetLength(1)];
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            array[j] = matr[i,j];
        }
        Array.Sort(array);
        for(int j = 0; j <matr.GetLength(1); j++)
        {
            matr[i,j] = array[j];
        }
    }
    Console.WriteLine($"Упорядоченный массив:");
    return (matr);
}



int rowsCount = ReadInt("Введите число строк");
int columnsCount = ReadInt("Введите число столбцов");
int[,] matrix = GetRandomMatrix(rowsCount, columnsCount);

PrintMatrix(matrix);

newMatrix(matrix);

PrintMatrix(matrix);
