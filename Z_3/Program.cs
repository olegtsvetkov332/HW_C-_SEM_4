//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

System.Console.Write("Введите длинну массива: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите начальное значение массива: ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите конечное значение массива: ");
int num3 = Convert.ToInt32(Console.ReadLine());


int[] GenerateRandomArray(int Lenght, int MinValue, int MaxValue)
{
    int[] RandomArray = new int[Lenght];
    Random rand = new Random();
    for (int i = 0; i < Lenght; i++)
    {
        RandomArray[i] = rand.Next(MinValue, MaxValue + 1);
    }
    return RandomArray;
}


void PrintRandomArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.Write("]");
}


int[] RandomArray = GenerateRandomArray(num1, num2, num3);
PrintRandomArray(RandomArray);