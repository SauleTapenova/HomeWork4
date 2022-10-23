//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,]CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double [,] array = new double [rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
    return array; 
}

void Show2dArray(double [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i,j],1) + " ");

        Console.WriteLine();    
    }
}

double [,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,]CreateRandom2dArray()

{
    //Console.Write("Input a number of rows: ");
    //int rows = Convert.ToInt32(Console.ReadLine());
    //Console.Write("Input a number of columns: ");
    //int columns = Convert.ToInt32(Console.ReadLine());
    //Console.Write("Input a min possible value: ");
    //int minValue = Convert.ToInt32(Console.ReadLine());
    //Console.Write("Input a max possible value: ");
    //int maxValue = Convert.ToInt32(Console.ReadLine());

    int [,] array = new int [5, 4];

    for(int i = 0; i < 5; i++)
        for(int j = 0; j < 4; j++)
            array[i,j] = new Random().Next(1, 9);
    return array; 
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();    
    }
}

int [,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

void ShowElements()
{
    Console.WriteLine("Input a number of rows: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number of columns: ");
    int m = Convert.ToInt32(Console.ReadLine());
    

    if (n > myArray.GetLength(0) || m > myArray.GetLength(1))
    {
        Console.WriteLine("такого элемента нет");
    }
    else
    {
        Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {myArray[n-1,m-1]}");
    }
}
ShowElements();
*/
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,]CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
   
    int [,] array = new int [rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array; 
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();    
    }
}



double[] ColumnsAverage(int[,] myArray, int rows, int columns)
{
    double sum = 0;
    
    double[] averArray = new double [columns];
    for(int j = 0; j < myArray.GetLength(1); j++)
    {
        for(int i = 0; i < myArray.GetLength(0); i++)
        {
            sum = sum + myArray[i,j];             
        }
     
        averArray[j] = sum / rows;
        Console.Write(Math.Round(averArray[j],1) + "; "); 
        sum = 0;
    }    
    
    return averArray;
    
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int [,] myArray = CreateRandom2dArray(rows, columns, minValue,  maxValue);
Show2dArray(myArray);
double[] Over = ColumnsAverage(myArray, rows, columns);
Console.WriteLine();
*/