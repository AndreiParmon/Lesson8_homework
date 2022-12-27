// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7


int[,] GetRandomMatrix(int rows, int columns)
{
    int[,] matr = new int [4, 4];
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

void SpiralMatrix(int[,] matr)
{
    int count = 2;
    int i = 0;
    int j =0;
    matr[i,j] = 1;
    while (count <= matr.GetLength(0) * matr.GetLength(1))
    {
        while (j +1 < matr.GetLength(1) && matr[i, j+1] == 0)
        {
            matr[i,j+1] = count;
            j++;
            count++;
        }
        while (i+1 < matr.GetLength(0) && matr[i+1,j] == 0)
        {
            matr[i+1,j] = count;
            i++;
            count++;
        }
        while (j-1 >= 0 && matr[i,j-1] == 0)
        {
            matr[i, j-1] = count;
            j--;
            count++;
        }
        while (i-1 >= 0 && matr[i-1,j] == 0)
        {
            matr[i-1,j] = count;
            i--;
            count++;
        }
    }
}

int rowsCount = 4;
int columnsCount = 4;
int[,] matrix = GetRandomMatrix(rowsCount, columnsCount);
SpiralMatrix(matrix);
PrintMatrix(matrix);