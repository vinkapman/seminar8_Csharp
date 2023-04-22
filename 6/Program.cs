internal class Program

{

    private static void Main(string[] table)

    {
        static int[,] GenerateArray(int rows, int cols)
        {
            int[,] table = new int[rows, cols]; // инициализация двумерного массива случайными числами
            Random random = new Random();
            for (int a = 0; a < rows; a++)
            {
                for (int b = 0; b < cols; b++)
                {
                    table[a, b] = random.Next(0, 9);
                }
            }
            for (int i = 0; i < table.GetLength(0); i++) // перебор сток массива
            {
                for (int j = 0; j < table.GetLength(1); j++) // перебор столбцов массива
                {
                    Console.Write(table[i, j] + "\t"); // печать массива
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сортировка по строкам: ");
            for (int i = 0; i < table.GetLength(0); i++) // перебор строк массива
            {
                int temp;
                int max = 0;
                for (int j = 0; j < table.GetLength(1); j++) // перебор столбцов массива
                {
                    int indexMax = table[i, j];
                    for (int k = j; k < table.GetLength(1) - 1; k++) // цикл нахождения максимума
                    {
                        if (table[i, k] > table[i, k + 1])
                        {
                            max = table[i, k];
                            indexMax = k;
                        }
                        else
                        {
                            max = table[i, k + 1];
                            indexMax = k + 1;
                        }
                    }
                    temp = table[i, j];
                    table[i, j] = max;
                    table[i, indexMax] = temp;
                }
            }
            for (int i = 0; i < table.GetLength(0); i++) // печать массива
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(table[i, j] + "\t");
                }
                Console.WriteLine();
            }
            return table;
        }

        Console.WriteLine("Введите количество строк:");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов:");
        int n = Convert.ToInt32(Console.ReadLine());

        GenerateArray(m, n);

    }

}