// Задача 2: Задайте одномерный массив, 
//заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] GetArray(int length, int min, int max)
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

int Sum (int[] array)
{
int sum = 0;
for (int i = 0; i < array.Length; i = i + 2)
{
    sum = sum + array[i];
}
return sum;
}

int[] arr = GetArray(5, -9, 10);
ShowArray(arr);
System.Console.Write($"> {Sum(arr)}");