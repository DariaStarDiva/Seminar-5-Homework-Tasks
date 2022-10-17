// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
void InputArray ( int [] array)
{
    for ( int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(99, 1000);
}
int CountPositiveNumbers(int[] array)
{
   int CountP = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] %2 == 0)
         CountP++; // summaP += array[i];
   }
   return CountP;
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine ($"[{string.Join ( " , " , array)}]");
Console.WriteLine($"Количество четных элементов равна: {CountPositiveNumbers(array)}");