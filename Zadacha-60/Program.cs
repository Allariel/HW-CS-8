//..Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
void Print_arr(int[,,] array)
{
   for (int i = 0; i < 2; i++)
    { 
        for (int j = 0; j < 2;j++)        
        {
            Console.WriteLine();
            for (int k = 0; k < 2; k++)
            {
              Console.Write(array[j,k,i]+ " ("+j+k+i+")");  
            }
        }
    }
}



int [,,] Fill_array()
{
    Queue<int> numbers = new Queue<int>();
    //Random rnd = new Random();
    //int one = rnd.Next(4,6);
    //int two = rnd.Next(4,6);
    //int three = rnd.Next(4,6);
    int[,,] array = new int[2,2,2];
    for (int i = 0; i < 2; i++)
    { 
        for (int j = 0; j < 2;j++)        
        {
            for (int k = 0; k < 2; k++)
            {
                Console.WriteLine("Ввeдите число");
                int number =  Convert.ToInt32(Console.ReadLine());
                while(numbers.Contains(number) || (number<10)|| (number>99))
                {
                    Console.WriteLine("Введенное число или повторяется или не двухзначное");
                    number =  Convert.ToInt32(Console.ReadLine());
                }
                array[i,j,k] = number;
                numbers.Enqueue(number);
                Console.WriteLine("Введено");
                
            }
        }
    }
    return array;
}
int[,,] A = Fill_array();
Print_arr(A);

