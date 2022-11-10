//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
    int row = rnd.Next(4,7);
    int column = rnd.Next(4,9);
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

void Bubble_sort(int[,] array)
{   
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int x = 0; x < array.GetLength(1)-j-1; x++)
            {
                if (array[i,x]<array[i,x+1])
                {
                    temp = array[i,x];
                    array[i,x] = array[i,x+1];
                    array[i,x+1] = temp;
                }
            }
        }
    }
}

int[,] array = Fill_array();
Print_arr(array);
Bubble_sort(array);
Print_arr(array);