// Задача 3: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] GetArrayDouble()
{
double[] array = new double[5];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
int number = new Random().Next(1, 100);
array[i] = rand.NextDouble() * number;
}
return array;
}

void ShowArray(double[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]:f2}   ");
    }
}

double FindMax (double[] array)
{
    double max = array[0];
    {
        for (int i = 1; i < array.Length; i++)
            {
            if (array[i] > max)
                {
                max = array[i];
                }
            }
        return max;
    }
}

double FindMin (double[] array)
{
    double min = array[0];
    {
        for (int i = 1; i < array.Length; i++)
            {
            if (array[i] < min)
                {
                min = array[i];
                }
            }
        return min;
    }
}

double[] arr = GetArrayDouble();
ShowArray(arr);
double diff = (FindMax (arr) - FindMin (arr));
System.Console.WriteLine($"=> {diff:f2} ");