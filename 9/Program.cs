/*
Урок 9. Рекурсия
Задача 64: Задача 64: Задайте значения M и N. Напишите программу, которая выведет все 
натуральные числа в промежутке от M до N.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


static string Natural(int m, int n)
{
    if (m<=n) return $"{m} " + Natural(m + 1, n);
    else return String.Empty;
}

Console.WriteLine("вывод всех натуральных чисел в промежутке от M до N");
Console.WriteLine("Введите значение М");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N");
int numTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Natural(numOne, numTwo));

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

static int SumNumbersNatural(int m, int n)
{
    if (m>n) return 0;
    else return m + SumNumbersNatural(m + 1, n);
}

Console.WriteLine("Сумма всех натуральных чисел в промежутке от M до N");
Console.WriteLine("Введите значение М");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N");
int numTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел = {SumNumbersNatural(numOne, numTwo)}");

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

static int FuncAkk(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return FuncAkk(n - 1, 1);
    else
        return FuncAkk(n - 1, FuncAkk(n, m - 1));
}
 
Console.WriteLine("вычисление функции Аккермана");
Console.WriteLine("Введите значение М");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N");
int numTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-----------------------------------");
Console.WriteLine($"Результат = {FuncAkk(numOne, numTwo)}");