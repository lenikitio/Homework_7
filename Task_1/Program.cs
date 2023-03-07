// Задайте двумерный массив из целых чисел. Определите, 
// есть столбец в массиве, сумма которого, больше суммы элементов расположенных в четырех "углах" двумерного массива.

// Например, задан массив:
// 4 4 7 5
// 4 3 5 3
// 8 1 6 8 -> нет

void PrintBiArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}

int[,] GetBiArray(int strok, int stolb, int min, int max)
{
    int[,] result = new int[strok, stolb];
    Random rnd = new Random();
    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = rnd.Next(min, max + 1);
        }
    }
    return result;
}

int GetStolbSum(int[,] array)
{
    int Sum = 0;
    int SumStolb = 0;
    int NStolb = 0;
    for(int i = 0; i < array.GetLength(1); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
        {
            Sum += array[j,i];
        }
        if(Sum >= SumStolb)
        { 
        SumStolb = Sum;
        NStolb = i;
        }
        Sum = 0;
    }
    Console.WriteLine($"Самая большая сумма чисел в столбике {NStolb} равна {SumStolb}");
    return SumStolb;
}

void CheckBoxSum(int[,] array, int StolbSum)
{
    int BoxSum = array[0,0] + array[0, array.GetLength(1) - 1] + array[array.GetLength(0) - 1,0] + array[array.GetLength(0) - 1,array.GetLength(1) - 1];
    Console.WriteLine($"Сумма в углах {BoxSum}");
    if(BoxSum >= StolbSum) Console.WriteLine("Нет");
    else Console.WriteLine("Есть");
}


int[,] BiArray = GetBiArray(4, 5, 0, 9);
PrintBiArray(BiArray);
int stolb = GetStolbSum(BiArray);
CheckBoxSum(BiArray, stolb);