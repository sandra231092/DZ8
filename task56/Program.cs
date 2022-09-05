//Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
//находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
//наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите колличество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[row,column];
int[] rowSum = new int[row];

FillArray(numbers);
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0; 
    for (int j = 0; j < numbers.GetLength(1); j++)
    sum = sum + numbers[i,j];
    rowSum[i] = sum;
}

int minSum = rowSum[0];
int rowMinSum = 0;
 for (int i = 0; i < rowSum.Length; i++)
 {
    if (minSum > rowSum[i])
    {
        minSum = rowSum[i];
        rowMinSum = i;
    }
 }

 Console.WriteLine($"Наименьшая сумма элементов {minSum} у строки номер {rowMinSum}");

void FillArray(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
    array[i,j] = rand.Next(0,150);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}