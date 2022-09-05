//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите колличество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество страниц: ");
int page = Convert.ToInt32(Console.ReadLine());
int[,,] res = new int[row,column,page];

FillArray3D(res);
PrintArray3D(res);

void FillArray3D (int[,,] array)
{
    Random rand = new Random();
    int val = 10;
    int index = rand.Next(1,3);

    for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
    for (int k = 0; k < array.GetLength(2); k++, val += index)
    array[i,j,k] = val;
}

void PrintArray3D (int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        for (int k = 0; k < array.GetLength(1); k++)
        Console.Write(array[i,j,k] + "("+i+","+j+","+k+") ");
        Console.WriteLine();
    }
}