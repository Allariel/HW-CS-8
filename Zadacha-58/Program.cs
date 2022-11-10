// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
void MxM(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Разная размерность");
            int[,] result = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        result[i,j] += a[i,k] * b[k,j];
                    }
                }
            }
            Print_arr(result);
        }


void Print_arr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine(); 
        for (int j = 0; j < array.GetLength(1); j++)        
        {
            Console.Write(" " +  array[i,j] + " ");
        }
    }
    Console.WriteLine();
}

int [,] Fill_array()
{
    Random rnd = new Random();
    int row = rnd.Next(4,6);
    int column = rnd.Next(4,6);
    int[,] array = new int[row,column];

    for (int i = 0; i < row; i++)
    { 
        for (int j = 0; j < column;j++)        
        {
            array[i,j] = rnd.Next(1,10);
        }
    }
    return array;
}
int[,] A = Fill_array();
Print_arr(A);
int[,] B = Fill_array();
Print_arr(B);
MxM(A,B);
