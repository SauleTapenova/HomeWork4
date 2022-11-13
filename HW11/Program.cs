
int[,] CreateRandom2dArray(int rows,int columns,int minValue,int maxValue)
{
int [,] array = new int [rows, columns];
for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                array[i,j] = new Random().Next(minValue, maxValue + 1); 
            }           
        }    
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

void BubbleSortArray(int [,] array)
{
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1)-1; j++)
        {
            for(int z = 0; z < array.GetLength(1)-1; z++)
            {
                 if(array[i,z] < array[i,z+1])
                {
                    int temp = array[i,z];
                    array[i,z] = array[i,z+1];
                    array[i,z+1] = temp;
                }
             
            }
        }
    }
}




/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
int [,] myArray = CreateRandom2dArray(3,4,1,9);
Show2dArray(myArray);
BubbleSortArray(myArray);
Console.WriteLine();
Show2dArray(myArray);
*/

int MinSumRow(int[,] array)
{
    int min = 0;
    int sum = 0;
    int index = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for(int j = 0; j < array.GetLength(1); j++) 
       {
            sum = sum + array[i,j];
       }
       if (min > sum )
       {
            min = sum;
            index = i;
       }
    }
    return index;
}
/*
int [,] myArray = CreateRandom2dArray(4,4,1,9);
Show2dArray(myArray);
int index = MinSumRow(myArray);
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой {index}");
*/

//Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateRandom3dArray(int rows,int columns,int depth, int minValue,int maxValue)
{
int [,,] array = new int [rows, columns, depth];
for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                for(int z = 0; z < depth; z++)
                {
                 //   array[i,j,z] = new Random().Next(minValue, maxValue + 1);
                  while (array[i, j, z] == 0)
                {
                    int number = new Random().Next(minValue, maxValue + 1);

                    if (NumberInArray(array, number) == false)
                    {
                        array[i, j, z] = number;
                    }
                }
                }
                 
            }           
        }    
return array; 
}


void Show3dArray(int [,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)

            for(int z = 0; z < array.GetLength(2); z++)
                Console.Write(array[i,j,z] + " "+ "("+ i+","+j+","+z+")");

        Console.WriteLine();    
    }
}

bool NumberInArray(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                if (array[i, j, z] == number) return true;
            }
        }
    }

    return false;
}
/*
int [,,] myArray = CreateRandom3dArray(2,2,2,10,99);
Show3dArray(myArray);
*/
/*Задачa 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int [,] myArray1 = CreateRandom2dArray(2,2,1,9);
Show2dArray(myArray1);
Console.WriteLine();
int [,] myArray2 = CreateRandom2dArray(2,2,1,9);
Show2dArray(myArray2);
Console.WriteLine();
int[,] myArray3 = MultiplyMatrix(myArray1, myArray2, 2,2);
Show2dArray(myArray3);
*/

int [,] MultiplyMatrix(int[,] myArray1, int[,] myArray2, int minValue,int maxValue)
{
  int[,] resultMatrix = new int[minValue, maxValue];
  
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < myArray1.GetLength(1); k++)
      {
        sum += myArray1[i,k] * myArray2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
  return resultMatrix;
}

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
int [,] SquareMassiv(int num)
{
    int [,] array = new int[num,num];
    int temp = 1;
    
    for(int j = 0; j < num-1; j++)
    {
        int i = 0;
        array[i,j]= temp;
        temp++;
    }
    for(int i =0; i<num-1; i++)
    {
        int j=num-1;
        array[i,j]=temp;
        temp++;
    }
    for(int j = num-1; j > 0; j--)
    {
        int i = num-1;
        array[i,j]=temp;
        temp++;
    }
    for(int i = num -1; i>0; i--)
    {
        int j = 0;
        array[i,j]= temp;
        temp++;
    } 
    for(int j = 1; j< num-1;j++)
    {
        int i = 1;
        array[i,j]= temp;
        temp++;
    }    
    for(int j = num/2; j>0; j--)
    {
        int i = num/2;
        array[i,j]=temp;
        temp++;
    }
    return array;    

}
/*
int num = 4; //рамер массива
int [,] myArray = SquareMassiv(num);
Show2dArray(myArray);
*/
