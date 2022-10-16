int [] CreatRandomArray (int m,int minValue,int maxValue)
{
    int [] newArray = new int [m];
    for(int i = 0; i < m; i ++) 
        newArray[i] = new Random().Next(minValue,maxValue);
    
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i ++)
    {
        Console.Write(array[i] +  " ");
    }
    Console.WriteLine(); 
}

int CountPosNumber (int [] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i ++) 
    {
        if(array[i]%2 == 0)
        {
            count ++;
        }
    }        
    return count;
}

int SumNegNumber (int [] array)
{
    int sum = 0;
    int i = 1;

    while(i < array.Length)
    {
        sum += array[i];  
        i=i+2;

    }
       
    return sum;
}

int FindMaxNumber (int [] array)
{
    int max = array[0];
    for(int i = 1; i < array.Length; i ++) 
    {
        if(array[i]>max)
        {
            max = array[i];
        }
    }        
    return max;
}

int FindMinNumber (int [] array)
{
    int min = array[0];
    for(int i = 1; i < array.Length; i ++) 
    {
        if(array[i]<min)
        {
            min = array[i];
        }
    }        
    return min;
}


//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
Console.Write("Input size of array: ");
int m = Convert.ToInt32(Console.ReadLine());
int min = 100;
int max = 1000;
int [] myarray = CreatRandomArray (m,min,max);
int number = CountPosNumber(myarray);
ShowArray(myarray);
Console.WriteLine(number);
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
Console.Write("Input size of array: ");
int m = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 9;
int [] myarray = CreatRandomArray (m,min,max);
int number = SumNegNumber (myarray);
ShowArray(myarray);
Console.WriteLine(number);     
 */
 //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
Console.Write("Input size of array: ");
int m = Convert.ToInt32(Console.ReadLine());
int min = 1;
int max = 9;
int [] myarray = CreatRandomArray (m,min,max);
int number = FindMaxNumber (myarray);
int number2 = FindMinNumber (myarray);
ShowArray(myarray);
Console.WriteLine(number - number2); 
*/