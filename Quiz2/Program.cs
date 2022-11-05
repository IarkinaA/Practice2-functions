// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
string num = Console.ReadLine();
int length = num.Length;

if(length<3) {
    Console.WriteLine("третьей цифры нет");
} else {
    Console.WriteLine(num[2]);
}