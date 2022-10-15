// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < array.Length; i++ )
{
    array[i] = new Random().Next(0,100);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
int max = 0;
int min = 100;
for(int i = 0; i < array.Length; i++) 
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
    i++;
}
Console.WriteLine("max:  " + max);
Console.WriteLine("min  " +min);
Console.WriteLine("Разница максимального и минимального:  "+(max - min));