// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
void MyPow(int a, int b)
{   
    int result = a;
    for(int i = 2; i <= b; i++)
        result *= a;
    Console.WriteLine(result);
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int b = Convert.ToInt32(Console.ReadLine());

MyPow(a, b);
*/


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
void SumNumber(int number)
{
    int result = 0;
    while (number > 0)
    {
        int last = number % 10;
        result += last;
        number /= 10; 
    }
    Console.Write($"Сумма цифр заданного числа = {result}");
}

Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

SumNumber(userNumber);
*/


// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write("Введите элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) 
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());

ShowArray(CreateArray(size));