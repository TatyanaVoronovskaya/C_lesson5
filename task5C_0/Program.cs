// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] GenerateArray(int length, int min, int max)
{
    int[] array = new int [length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void ShowArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write(item + " ");
    }
}

//int CountEven(int[] array)
//{
//int count = 0;
//for (int i = 0; i < array.Length; i++)
//{
   // if(array[i]%2 == 0) 
   // {
   //     count++;
   // }
//}
//return count;
//}

int CountEven(int[] array)
{
int count = 0;
foreach (int item in array)
{
    if(item%2 == 0) 
    {
        count++;
    }
}
return count;
}

int[] arr = GenerateArray(10, 100, 1000);
ShowArray(arr);
System.Console.WriteLine($" > {CountEven(arr)}");


