// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.

int m = new Random().Next(1, 10);
Console.WriteLine($"Количество строк: {m}");
int n = new Random().Next(1, 10);
Console.WriteLine($"Количество столбцов: {n}");
double[,] array = new double[m, n];

GetArrayRandom(array, m, n);
PrintArray(array);

void GetArrayRandom(double[,] array, int m, int n)
{
    double[,] array1 = new double[m, n];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0);
        }
    }
}

void PrintArray(double[,] array)
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
