// Дополнительная задача 2 (задача со звёздочкой): 
// Вывести первые n строк треугольника Паскаля. Реализовать вывод в виде равнобедренного треугольника.

Console.Clear();

void GetPascalTriangle(int N)
{
    int Strok = N;
    int Stolb = 2*N - 1;
    int Lcount = ((Stolb + 1) / 2) - 1;
    int Rcount = Lcount;
    int[,] PascalTriangle = new int[Strok,Stolb];
    for(int i = 0; i < Strok; i++)
    {
        for(int j = 0; j < Stolb; j++)
        {
            if(j == Lcount || j == Rcount)
            {
            PascalTriangle[i,j] = 1;
            }
            else if(j > Lcount && j < Rcount)
            {
                PascalTriangle[i,j] = PascalTriangle[i - 1, j - 1] + PascalTriangle[i - 1, j + 1];
            }
            else PascalTriangle[i,j] = 0;
            if(PascalTriangle[i,j] == 0) Console.Write(" ");
            else Console.Write(PascalTriangle[i,j]);
        }
        Lcount--;
        Rcount++;
        Console.WriteLine("");
    }
}

GetPascalTriangle(7);