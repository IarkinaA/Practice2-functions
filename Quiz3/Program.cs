// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());

if(number1>7 || number1<1)
{
    Console.WriteLine("Ошибка");
}

if(number1 == 1 || number1 == 2||number1 == 3||number1 ==4||number1 ==5)
{
    Console.WriteLine("Будний день");
}

if(number1 == 6 || number1 ==7)
{
    Console.WriteLine("Выходной");
}