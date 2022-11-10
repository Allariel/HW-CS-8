//Напишите программу, которая заполнит спирально массив 4 на 4.
int [,] Fill_array()
{
    int[,] array = new int[4,4];
    int temp = 1;
    int i=0,j=0;
    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
    array[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= array.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > array.GetLength(1) - 1)
        j--;
    else
        i--;
    }

    return array;
}
void Print_arr(int[,] array)
{
   for (int i = 0; i < 4; i++)
    { 
        Console.WriteLine();
        for (int j = 0; j < 4;j++)        
        {
              Console.Write(" " +array[i,j] + " ");  
        }
    }
}
int[,] A = Fill_array();
Print_arr(A);