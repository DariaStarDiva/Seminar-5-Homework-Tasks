// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void InputArray ( int [] array)
{
    for ( int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-99, 100);
}
int SummaPositiveNumbers(int[] array)
{
   int summaP = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (i%2 > 0)
         summaP = summaP + array[i]; // summaP += array[i];
   }

   return summaP;
}

int[]array = new int [4];
InputArray(array);
Console.WriteLine ($" [{string.Join ( " , " , array)}]");
Console.WriteLine($"Сумма элементов на нечетных позициях равна: {SummaPositiveNumbers(array)}");
