// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

void PrintBiArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

double[,] FillBiArray(int strok, int stolb, int min, int max)
{
    double[,] BiArray = new double[strok, stolb];
    Random rnd = new Random();
    for(int i = 0; i < strok; i++)
    {
        for(int j = 0; j < stolb; j++)
        {
            BiArray[i, j] = Math.Round(rnd.Next(min, max + 1) + rnd.NextDouble(), 1);
        }
    } 
    return BiArray;
}


Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int mn = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int mx = Convert.ToInt32(Console.ReadLine());

double[,] BiArray = FillBiArray(m, n, mn, mx);
PrintBiArray(BiArray);