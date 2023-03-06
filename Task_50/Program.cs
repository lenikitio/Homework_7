// Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,1 -> 9
// 1,7 -> элемента с данными индексами в массиве нет

Console.Clear();

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

int SearchValue(int[,] array, int m, int n)
{
    if(m >= array.GetLength(0) || n >= array.GetLength(1))
    {
    Console.WriteLine("Элемента с данными индексами в массиве нет");
    return 0;
    }
    else
    {
    Console.WriteLine($"Значение под индексом: {m},{n}: {array[m, n]}");    
    return array[m, n]; 
    }
}

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

Console.Write("Введите номер строки: ");
int NStrok = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int NStolb = Convert.ToInt32(Console.ReadLine());

int Value = SearchValue(BiArray, NStrok, NStolb);