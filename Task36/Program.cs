// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] array = new int[4];
int sumEven = 0;
int sumOdd = 0;
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-30, 30);
}
Console.WriteLine('[' + string.Join(", ", array) + ']');

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 > 0)
    {
        sumOdd += array[i];
    }
    else
    {
        sumEven += array[i];
    }
}
Console.Write($"Сумма нечетных чисел = {sumOdd}, сумма четных = {sumEven}");