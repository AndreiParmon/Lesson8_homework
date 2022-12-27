// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49


int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomMatrix(int rows, int columns, int leftRange = 1, int rightRange = 9)
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

int[,] GetRandomMatrix2(int rows2, int columns2, int leftRange = 1, int rightRange = 9)
{
    int[,] matr2 = new int [rows2, columns2];

    var rand = new Random();
    for(int i = 0; i < matr2.GetLength(0); i++)
    {
        for(int j = 0; j < matr2.GetLength(1); j++)
        {
            matr2[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matr2;
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


int[,] MatrixMultiplication(int[,] matr, int[,] matr2)
{
    int[,] result = new int[matr.GetLength(0), matr2.GetLength(1)];
    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            for(int n = 0; n < matr.GetLength(1); n++)
            {
                result[i,j] = matr[i,j] * matr2[i,j];
            }
        }
    }
    return result;
}

int rowsCount = ReadInt("Введите число строк");
int columnsCount = ReadInt("Введите число столбцов");
int[,] matrix = GetRandomMatrix(rowsCount, columnsCount);
int rowsCount2 = ReadInt("Введите число строк второй матрицы");
int columnsCount2 = ReadInt("Введите число столбцов второй матрицы");
int[,] matrix2 = GetRandomMatrix2(rowsCount2, columnsCount2);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
int[,] result = MatrixMultiplication(matrix, matrix2);
PrintMatrix(result);