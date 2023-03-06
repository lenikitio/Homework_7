// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int mn = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int mx = Convert.ToInt32(Console.ReadLine());

int[,] BiArray = FillArray(m, n, mn, mx);
PrintBiArray(BiArray);
GetArifmeticMean(BiArray);



int[,] FillArray(int strok, int stolb, int min, int max)
{
    Random rnd = new Random();
    int[,] result = new int[strok, stolb];
    for(int i = 0; i < strok; i++)
    {
        for(int j = 0; j < stolb; j++)
        {
            result[i, j] = rnd.Next(min, max + 1);
        }
    }
    return result;
}

void PrintBiArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
    Console.WriteLine(" ");
}

void GetArifmeticMean(int[,] array)
{
    double arf = 0;
    int sum = 0;
    for(int i = 0; i < array.GetLength(1); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j,i];                      
        }
        arf = Math.Round(Convert.ToDouble(sum) / array.GetLength(0), 1);
        Console.WriteLine($"Среднее арифметическое {i} столбца: {arf}");
        sum = 0;
        arf = 0;
    }
}