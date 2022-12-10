/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/


Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"В массиве строк: {m}");
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"В массиве столбцов: {n}");

int[,] array = new int[m, n];

FillArray(array, m, n);
PrintArray(array);

Console.WriteLine("Введите позицию на строке");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию на столбце");
int l = Convert.ToInt32(Console.ReadLine());

FindNumber(array, k, l);

void FillArray(int[,] array, int m, int n)
{
    Random array1 = new Random();
    int[,] array2 = new int[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(array1.Next(-100, 100) / 10.0);

        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }

}
void FindNumber(int[,] array, int k, int l)
{

    if (k > array.GetLength(0) || l > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
    else
    {
        Console.WriteLine($"Искомый элемент на заданной позиции:{array[k, l]} ");
    }
}
