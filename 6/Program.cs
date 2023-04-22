internal class Program

{

    private static void Main(string[] table)

    {
        /* Задача 62. Напишите программу, которая заполнит спирально массив . Размер вводит юзер
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

Start();
void Start()
{
            Console.Clear();
            int rows = SetNumber("rows");
            int columns = rows;
            Console.WriteLine();
            int[,] matrix = GetSpiralMatrix(rows, columns);
            PrintMatrix(matrix);
            Console.WriteLine();
            Console.WriteLine();
        }

        int SetNumber(string text = "")
        {
            Console.Write($"Enter number {text}: ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
        int[,] GetSpiralMatrix(int rows, int columns)
        {
            int[,] array = new int[rows, columns];
            int num = 1;
            int i = 0;
            int j = 0;

            while (num <= rows * columns)
            {
                array[i, j] = num;
                if (i <= j + 1 && i + j < columns - 1)
                    ++j;
                else if (i < j && i + j >= rows - 1)
                    ++i;
                else if (i >= j && i + j > columns - 1)
                    --j;
                else
                    --i;
                ++num;
            }

            return array;
        }
        void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLongLength(1); j++)
                {
                    Console.Write($" {matrix[i, j]:D2} ");
                }
                Console.WriteLine();
            }
        }
    }
}