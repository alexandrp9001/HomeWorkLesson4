//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите число A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B:");
int FirstB = Convert.ToInt32(Console.ReadLine());
int b = FirstB;
int c = 1;
if (b<1)
{
    Console.Write("Квадрат должен быть натуральным");
}
else
{
    while (b!=0)
    {
        c *= a;
        b -= 1;
    }
    Console.Write($"Число {a} в степени {FirstB} равно {c}");
}
