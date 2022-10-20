/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    Console.WriteLine("Creating array: ");
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} element of array: ");
        array[i] = Covert.ToInt32(Console.ReadLine());        
    }
    Console.WriteLine("Complete!");
    return array;
}


void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i ++)
    {
        Console.Write(array[i] +  " ");
    }
    Console.WriteLine(); 
}

int[] CreateRandomArray()
{
    Console.Write("Input a number of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max + 1);

    return array;
}
*/
/*int CountNumbers (int size)
{
    
    int count = 0;
    for(int i = 0; i < size; i ++) 
    {
        Console.WriteLine("Input number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        if(number > 0)
        {
            count++;
        }
    }        
    return count;
}
Console.WriteLine("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
int count = CountNumbers(size);
Console.WriteLine("Count of positive numbers:" + count);
*/
void FindPointInter (double b1, double b2, double k1, double k2)
{
    double x1;
    x1 = (b2 - b1)/(k1 -k2);
    double y1;
    y1 = (k1*x1 + b1);
    Console.Write(x1 +  ";" + y1);

}

FindPointInter(2,4,5,9);