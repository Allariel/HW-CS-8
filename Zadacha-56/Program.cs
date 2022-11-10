// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
    int row = rnd.Next(4,5);
    int column = rnd.Next(4,5);
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

void Min_str(int[,] array)
{   
    int index=0,temp=0,min=0;
    for (int k = 0; k < array.GetLength(1); k++)
    {
        min+=array[0,k];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        temp=0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp+=array[i,j];
        }
        if (temp<min)
        {
            min = temp;
            index=i;
        }
    }    
    Console.WriteLine("Sum "+ min);
    Console.WriteLine("Number of string "+ (index+1)); 
}

int[,] array = Fill_array();
Print_arr(array);
Min_str(array);