//Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

Console.WriteLine("Введите колличество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[row,column];
Console.WriteLine("Введите начальное значение массива: ");
int val = Convert.ToInt32(Console.ReadLine());
int i = 0; 
int k = 0; 
int j;


while (i < row * column)
{
    k++;
    for (j = k - 1; j < column - k + 1; j++)
    {
        numbers[k - 1,j] = val++;
        i++;
    }
    for (j = k; j < row - k + 1; j++)
    {
        numbers[j,column - k] = val++;
        i++;
    }
    for (j = column - k - 1; j >= k - 1; j--)
    {
        numbers[row - k,j] = val++;
        i++;
    }
    for (j = row - k - 1; j >= k; j--)
    {
        numbers[j,k - 1] = val++;
        i++;
    }
}

PrintArray(numbers);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}
