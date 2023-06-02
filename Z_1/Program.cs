//Задача 25: Напишите цикл (***Функцию***), который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Введите A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int Power(int arg1, int exponent)
{
    return arg1 = Convert.ToInt32(Math.Pow(arg1, exponent));
}

bool Valid(int exponent)
{
    if (exponent < 0)
    {
        Console.Write("Число В должно быть больше 0!");
        return false;
    }
    else
    {
        return true;
    }
}
if (Valid(num2) == true)
{
    Console.Write($"Число {num1} в степени {num2} равно {Power(num1, num2)}");
}
