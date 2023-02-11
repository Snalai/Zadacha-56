// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.WriteLine("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int MinSum = 0;
int str = 0;
int[,] num = new int[m, n];
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = new Random().Next(0, 10);
        sum = sum + num[i, j];
        Console.Write($" {num[i, j]}");
    }
    if (i == 0)
    {
        MinSum = sum;
    }
    else if (sum < MinSum)
    {
        MinSum = sum;
        str = i;
    }
    Console.Write($" - Сумма {i + 1} строки равна: {sum}.");
    Console.WriteLine();
    sum = 0;
}
Console.Write($"Наименьшая сумма у {str + 1} строки.");