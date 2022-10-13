//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
 /*
 int VozNumSt(int A, int B)
{
 int pro = 1;
 
 for(int i = 1; i <= B; i++)
     
{
    
    pro = pro * A;
   
    
}
     return( pro );
}
Console.WriteLine("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number: ");
int b = Convert.ToInt32(Console.ReadLine());
int c= VozNumSt(a,b);
Console.WriteLine(c);
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Num ( int a)
{
    int sum = 0;
    int i = 1;
    
    for(int b = 1; b <= a; b ++)
    {
        i = a % 10;
        a = a /10;
        sum = sum + i;       
    }
    return sum;
}
Console.WriteLine("Input number:  ");
int c = Convert.ToInt32(Console.ReadLine());
int Sum= Num(c);
Console.WriteLine(Sum);
*/

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*

int [] SomeArray (int m,int minValue,int maxValue)
{
    int [] newArray = new int [m];
    for(int i = 0; i < m; i ++) 
        newArray[i] = new Random().Next(minValue,maxValue);
    return newArray;
      
}
void ShowArray(int[]array)
{
    for(int i = 0; i < array.Length; i ++)
    Console.Write(array[i]+  " ");
    Console.WriteLine();
}
Console.Write("Input number: ");
int m = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 9;
int [] myarray = SomeArray (m,min,max);
ShowArray(myarray);
*/
