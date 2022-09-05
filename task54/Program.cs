//Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

Console.WriteLine("Введите колличество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[row,column];

FillArray(numbers);
Console.WriteLine("Исходный массив:");
PrintArray(numbers);
SortArray(numbers);
Console.WriteLine("Упорядоченный по убыванию массив:");
PrintArray(numbers);

void SortArray(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 1; k < array.GetLength(1); k++)
            {
                if (array[i,k] > array[i,k - 1])
                {
                    temp = array[i,k - 1];
                    array[i,k - 1] = array[i, k];
                    array[i,k] = temp;
                }
            }
        }
    }
}

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