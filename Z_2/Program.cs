//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumAllDigit(int arg)
{
    int result = 0;
    while (arg > 0)
    {
        result += arg % 10;
        arg = arg / 10;
    }
    return result;
}
Console.Write($"Сумма все цифр числа {num} равна {SumAllDigit(num)}");