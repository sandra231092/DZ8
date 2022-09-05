//Задайте две матрицы. Напишите программу, которая будет 
//находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

Console.WriteLine("Введите колличество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] arg1 = new int[row,column];
int[,] arg2 = new int[row,column];
int[,] comp = new int[row,column];

FillArray(arg1);
FillArray(arg2);
Console.WriteLine("Первая матрица:");
PrintArray(arg1);
Console.WriteLine("Вторая матрица:");
PrintArray(arg2);

for (int i = 0; i < arg1.GetLength(0); i++)
for (int j = 0; j < arg1.GetLength(1); j++)
comp[i,j] = arg1[i,j] * arg2[i,j];
Console.WriteLine("Результирующая матрица:");
PrintArray(comp);

void FillArray(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
    array[i,j] = rand.Next(0,50);
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