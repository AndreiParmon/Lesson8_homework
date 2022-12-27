// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] GetRandomMatrix(int rows, int columns, int depth, int leftRange = 10, int rightRange = 100)
{
    int[,,] matr = new int [rows, columns, depth];

    var rand = new Random();
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            for(int n = 0; n < matr.GetLength(2); n++)
            {
                matr[i, j, n] = rand.Next(leftRange, rightRange + 1);
            }
        }
    }
    return matr;
}

void newMatrix(int[,,] result)
{
    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int n = 0; n < result.GetLength(1); n++)
        {
            string[] newResult = new string[result.GetLength(2)];
            for(int j = 0; j < result.GetLength(2); j++)
            {
                newResult[j] = $"{result[i,n,j]}({i},{n},{j})";
            }

            Console.WriteLine($"{string.Join(" ", (newResult))}");
            
        }
    }
}
int rowsCount = ReadInt("Введите число строк");
int columnsCount = ReadInt("Введите число столбцов");
int depthCount = ReadInt("Введите число третьей стороны");
int[,,] matrix = GetRandomMatrix(rowsCount, columnsCount, depthCount);
newMatrix(matrix);