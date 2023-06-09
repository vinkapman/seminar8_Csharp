﻿/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы

каждой строки двумерного массива.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

7 4 2 1

9 5 3 2

8 4 4 2

internal class Program

{

    private static void Main(string[] myArraySort)

    {

       


        int[,] GenerateArray(int rows, int columns)
        {
            int[,] rndArray = new int[rows, columns];
            var rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    rndArray[i, j] = rand.Next(2, 10);
                }
            }
            return rndArray;
        }

        void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++) // перебор сток массива
                {
                    for (int j = 0; j < array.GetLength(1); j++) // перебор столбцов массива
                    {
                        Console.Write(array[i, j] + "\t"); // печать массива
                    }
                    Console.WriteLine();
                }
            }

        void SortArray(int[,] table)
            {
                Console.WriteLine("Сортировка по строкам: ");
                for (int i = 0; i < table.GetLength(0); i++) // перебор строк массива
                {
                    for (int j = 0; j < table.GetLength(1); j++) // перебор столбцов массива
                    {
                        int temp;
                        for (int k = j+1; k < table.GetLength(1); k++) // цикл нахождения максимума
                        {
                            if (table[i, j] < table[i, k])
                            {
                                temp = table[i,j];
                                table[i,j] = table[i, k];
                                table[i, k] = temp;
                            }
                        } 
                    }
                }

                
        }

        Console.Clear();
        Console.WriteLine("Введите количество строк:");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] myArray = GenerateArray(m, n);
        PrintArray(myArray);
        Console.WriteLine();
        SortArray(myArray);
        PrintArray(myArray);
        Console.WriteLine();

    }

}

Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой 
элементов: 1 строка


internal class Program

{

    private static void Main(string[] minStrokaArray)

    {
        int[,] GenerateArray(int rows, int columns)
        {
            int[,] rndArray = new int[rows, columns];
            var rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    rndArray[i, j] = rand.Next(2, 10);
                }
            }
            return rndArray;
        }

        void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++) // перебор сток массива
                {
                    for (int j = 0; j < array.GetLength(1); j++) // перебор столбцов массива
                    {
                        Console.Write(array[i, j] + "\t"); // печать массива
                    }
                    Console.WriteLine();
                }
            }

        int MinStrokaArray(int[,] table)
            {
                Console.WriteLine("номер строки с наименьшей суммой элементов: ");
                int[] minStroka = new int[table.GetLength(0)];
                for (int i = 0; i < table.GetLength(0); i++) // перебор строк массива
                {
                    minStroka[i] = 0;
                    for (int j = 0; j < table.GetLength(1); j++) // перебор элементов строки
                    {
                        minStroka[i] = minStroka[i] + table[i, j]; // сумма элементов строки i
                    } 
                }
                int min = minStroka[0];
                int indexStroka = 0;
                for (int k=0; k < minStroka.Length - 1; k++)
                {
                    if (minStroka[k] < min)
                    {
                        min = minStroka[k];
                        indexStroka = k;
                    }
                }
                Console.WriteLine(indexStroka+1);
                return indexStroka;
            }
        
        Console.Clear();
        Console.WriteLine("Введите количество строк:");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        int[,] myArray = GenerateArray(m, n);
        PrintArray(myArray);
        Console.WriteLine();
        MinStrokaArray(myArray);

    }

}

Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:

2 4 | 3 4

3 2 | 3 3

Результирующая матрица будет:

18 20

15 18


internal class Program

{

    private static void Main(string[] ProizArray)

    {
        int[,] GenerateArray(int rows, int columns)
        {
            
            int[,] rndArray = new int[rows, columns];
            var rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    rndArray[i, j] = rand.Next(2, 10);
                }
            }
            return rndArray;
        }

        void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++) // перебор сток массива
                {
                    for (int j = 0; j < array.GetLength(1); j++) // перебор столбцов массива
                    {
                        Console.Write(array[i, j] + "\t"); // печать массива
                    }
                    Console.WriteLine();
                }
            }

        int[,] ProizArray(int[,] tableOne, int[,] tableTwo)
            {
                Console.WriteLine("Произведение массивов:");
                var proizTable = new int[tableOne.GetLength(0), tableTwo.GetLength(1)]; // задали размер матрицы после произведения
                for (int i = 0; i < proizTable.GetLength(0); i++) // перебор строк массива
                {
                    for (int j = 0; j < proizTable.GetLength(1); j++) // перебор элементов строки
                    {
                       proizTable[i, j] = 0;
                       for (int k = 0; k < tableOne.GetLength(1); k++)
                       {
                            proizTable[i, j] += tableOne[i, k] * tableTwo[k, j];
                       }
                    } 
                }
              
                return proizTable;
            }
        
        Console.Clear();
        Console.WriteLine("Введите количество строк первого массива:");
        int m1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов первого массива:");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Введите количество строк второго массива:");
        int m2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов второго массива:");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        int[,] myArrayOne = GenerateArray(m1, n1);
        int[,] myArrayTwo = GenerateArray(m2, n2);
        PrintArray(myArrayOne);
        Console.WriteLine();
        PrintArray(myArrayTwo);
        Console.WriteLine();
        if (n1 != m2)
            {
                Console.WriteLine("Умножение невозможно");
            }
        else
            {
                int[,] myArrayThree = ProizArray(myArrayOne, myArrayTwo);
                PrintArray(myArrayThree); 
            }
    }
}



Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2

66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)


internal class Program

{

    private static void Main(string[] ThreeSizeArray)

    {
        int[,,] GenerateArray(int rows, int columns, int pages)
            {
                int[,,] array = new int[rows, columns, pages];
                int count = 10;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        for (int k = 0; k < pages; k++)
                        {
                            array[k, i, j] = count;
                            count += 1;
                        }
                    }
                }
                return array;
            }

        void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++) // перебор сток массива
                {
                    for (int j = 0; j < array.GetLength(1); j++) // перебор столбцов массива
                    {
                        Console.Write(array[i, j] + "\t"); // печать массива
                    }
                    Console.WriteLine();
                }
            }

        void PrintIndex(int[,,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.WriteLine();
                        for (int k = 0; k < array.GetLength(2); k++)
                        {
                            Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
                        }
                    }
                }
            }
        
        Console.Clear();
        Console.WriteLine("Введите индекс 1 массива:");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите индекс 2 массива:");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите индекс 3 массива:");
        int pages = Convert.ToInt32(Console.ReadLine());
        int[,,] matrix = GenerateArray(rows, columns, pages);
        PrintIndex(matrix);
        Console.WriteLine();
        Console.WriteLine();

    }

}


Задача 62. Напишите программу, которая заполнит спирально массив . Размер вводит юзер
Например, на выходе получается вот такой массив:

01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

*/

internal class Program

{

    private static void Main(string[] spiralArrays)

    {

        void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++) // перебор сток массива
                {
                    for (int j = 0; j < array.GetLength(1); j++) // перебор столбцов массива
                    {
                        Console.Write(array[i, j] + "\t"); // печать массива
                    }
                    Console.WriteLine();
                }
            }

        int[,] SpiralArray(int rows)
            {
                int columns = rows;
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
        
        Console.Clear();
        Console.WriteLine("Введите размер массива:");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        PrintArray(SpiralArray(m)); 
    }
}