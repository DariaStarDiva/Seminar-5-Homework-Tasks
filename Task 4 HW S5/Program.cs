// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//Внутренние функции использовать нельзя(Max и Min)

void InputArray ( double [] array)
{
    for ( int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 100) + new Random().NextDouble();
}

double Big (double[] array)
{
   double max = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] >max)
         max = array[i];
   }
   return max;
}
double Small (double[] array)
{
   double min = Big(array);
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] < min)
         min = array[i];
   }
   return min;
}  

double []array = new double [4];
InputArray(array);
Console.WriteLine ($" [{string.Join ( " , " , array)}]");
Console.WriteLine($"Максимальное: {Big(array)}");
Console.WriteLine($"Минимальное: {Small(array)}");
Console.WriteLine($"Разница: {Big(array) -Small(array)}");
