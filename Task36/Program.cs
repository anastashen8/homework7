// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < array.Length; i++ )
{
    array[i] = new Random().Next(-100,101);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
int sum = 0;
for(int i = 0; i < array.Length;) 
{
    if (array[i]%2 != 0)
    {
      sum += array[i];
    }
    i++;
}
Console.Write("Сумма нечетных чисел: " + sum);