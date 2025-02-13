﻿// Задайте значения M и N. Напишите программу,которая выведет 
// все натуральные числа в промежутке от M до N.
//  Использовать рекурсию, не использовать циклы.

System.Console.WriteLine("Задача 1: Задайте значения M и N. Напишите программу, которая выведет ");
System.Console.WriteLine("все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.");
string firstText = "Введите значение М => ";
System.Console.Write(firstText);
int firstNumber = NumberInTerminal(0xFFFFFF, firstText, 1);
string secondText = "Введите значение N => ";
System.Console.Write(secondText);
int secondNumber = NumberInTerminal(0xFFFFFF, secondText, 1);
if (firstNumber < secondNumber)
{
    System.Console.WriteLine($"Числа от {firstNumber} до {secondNumber} => {ShowDigit(firstNumber, secondNumber)}");
}
else {
    System.Console.WriteLine($"Число {firstNumber} больше числа {secondNumber}. Вы ввели некоректные данные");
}
/*Рекурсия при нахождении чисел*/
static string ShowDigit(int firstDigit, int secondDigit)
{
    if (firstDigit > secondDigit)
    {
        return "";
    }
    return $"{firstDigit} " + ShowDigit(firstDigit + 1, secondDigit);
}
/*Функция ввода чисел в терминале*/
 static int NumberInTerminal(int numberDigits, string repeatString, int minValueSet)
{
    string? numString = Console.ReadLine();
    int numInt = 0;
    while ((!Int32.TryParse(numString, out numInt)) || !(numInt >= minValueSet) || !(numInt <= numberDigits))
    {
        System.Console.WriteLine("Ошибка ввода, повторите");
        System.Console.Write(repeatString);
        numString = Console.ReadLine();
    }
    return numInt;
}

