Console.Clear();
Console.WriteLine("Какую задачу вы хотите проверить (1/2/3)? ");
int Task = Convert.ToInt32(Console.ReadLine());

if (Task == 1)
{
    Task1();
}
else if (Task == 2)
{
    Task2();
}
else if (Task == 3)
{
    Task3();
}


//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void Task1()
{
    Console.WriteLine(" Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. ");
    Console.WriteLine();
    Console.WriteLine("Введите количество строк двумерного массива");
    int rowCount = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов двумерного массива");
    int columnCount = Convert.ToInt32(Console.ReadLine());
    double[,] array = FillArray(rowCount, columnCount, 1, 9);
    Console.WriteLine("Исходный массив");
    PrintArray(array);
    Console.WriteLine("Если выводить массивы строк");
    StringToArray(array);
    Console.WriteLine("Если применить метод и выводить двумерный массив");
    SortArray(array);
    //PrintArray(TransArray(array));

    double[,] FillArray(int rows, int columns, int min, int max)
    {
        double[,] filledArray = new double[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                filledArray[i, j] = new Random().Next(min, max + 1);
            }
        }
        return filledArray;
    }

    void PrintArray(double[,] inputArray)
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(1); j++)
            {
                Console.Write(" " + inputArray[i, j]);
            }
            Console.WriteLine();
        }
    }
     void SortArray(double[,] Inputarray)
    {
        int rowFirstArray = Inputarray.GetLength(0);
        int columnuFirstArray = Inputarray.GetLength(1);
        double[] rowArray = new double[columnuFirstArray];
        int k = 0;

        for (int i = 0; i < rowFirstArray; i++)
        {
            for (int j = 0; j < columnuFirstArray; j++)
            {            
                {
                    StringToArray(Inputarray);
                    Inputarray[i, j] =  rowArray[k];                  
                    break;
                }
             
            }
            break;
            
        }
    }    
 
    

   void StringToArray(double[,] firstArray)
    {   
        int rowFirstArray = firstArray.GetLength(0);
        int columnuFirstArray = firstArray.GetLength(1);
        double[] rowArray = new double[columnuFirstArray];
        int k = 0;

        for (int i = 0; i < rowFirstArray; i++)
        {
            for (int j = 0; j < columnuFirstArray; j++)
            {            
                {
                    rowArray[k] = firstArray[i, j];
                    k++;                         
                                 
                }
                
            }
            Array.Sort(rowArray);
            Array.Reverse(rowArray);
            Console.WriteLine(string.Join(" ", rowArray));
            k = 0;        
            
        }      

        //PrintArray(firstArray);
    }
}
    void Task2()
{   //Задайте прямоугольный двумерный массив.
    // Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:
    Console.WriteLine(" Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. ");
    Console.WriteLine();
    Console.WriteLine("Введите количество строк двумерного массива");
    int rowCount = Convert.ToInt32(Console.ReadLine());
    int RandomNum = new Random().Next(1,10);

    int columnCount = rowCount + RandomNum;
    double[,] array = FillArray(rowCount, columnCount, 1, 9);
    Console.WriteLine("Прямоугольный массив");
    PrintArray(array);
    Console.WriteLine("Номер строки с минимальной суммой элементов");
    SumInRowarray(array);
    
    double[,] FillArray(int rows, int columns, int min, int max)
    {
        double[,] filledArray = new double[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                filledArray[i, j] = new Random().Next(min, max + 1);
            }
        }
        return filledArray;
    }

    void PrintArray(double[,] inputArray)
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(1); j++)
            {
                Console.Write(" " + inputArray[i, j]);
            }
            Console.WriteLine();
        }
    }
    
    void SumInRowarray(double[,] inputArray)
    {
        double sum=0;   
        double[] rowSum = new double[array.GetLength(0)];
        int k = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum = sum + array[i,j];            
            }         
            rowSum[k] = sum;
            k++;         
            sum = 0;  
        }
        Console.WriteLine("Сумма элементов по строкам  " + string.Join(" ", rowSum));
        
        double minVal = rowSum.Min(); 
        
        int indexMin = Array.IndexOf(rowSum, minVal);

        Console.WriteLine(Array.IndexOf(rowSum, minVal)+1);           
   }
}

//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void Task3()
{
    Console.WriteLine(" Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
    Console.WriteLine();
    Console.WriteLine("Введите количество строк двумерного массива ");
    int rowCount = Convert.ToInt32(Console.ReadLine());
    int columnCount = rowCount;
    double[,] array1 = FillArray(rowCount, columnCount, 1, 9);
    Console.WriteLine();
    double[,] array2 = FillArray(rowCount, columnCount, 1, 9);
    Console.WriteLine("Исходный массив");
    PrintArray(array1);
    Console.WriteLine();
    PrintArray(array2);
    Console.WriteLine();
    
    MultiMatrix(array1, array2);
   
   

    double[,] FillArray(int rows, int columns, int min, int max)
    {
        double[,] filledArray = new double[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                filledArray[i, j] = new Random().Next(min, max + 1);
            }
        }
        return filledArray;
    }

    void PrintArray(double[,] inputArray)
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(1); j++)
            {
                Console.Write(" " + inputArray[i, j]);
            }
            Console.WriteLine();
        }
    }


    void MultiMatrix(double[,] inputarray1, double[,] inputarray2)
    {
        double[,] multiMatrix  = new double[inputarray1.GetLength(0), inputarray2.GetLength(1)];
        
        for (int i = 0; i < inputarray1.GetLength(0); i++)
        {
            for (int j = 0; j < inputarray2.GetLength(1); j++)
            {
                for (int k = 0; k < inputarray2.GetLength(0); k++)
                {
                    multiMatrix[i,j] += inputarray1[i,k] * inputarray2[k,j];
                }            
             
            }          
          
        }
        PrintArray (multiMatrix);
    }
}


  
