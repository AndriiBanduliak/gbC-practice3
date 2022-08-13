/*
Задача 19.Напишите программу, которая принимает на вход пятизначное(и другое) число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
using static System.Console;
WriteLine("Enter the number");
string digit=ReadLine();
int diffDigitCounter = 0;
for(int i=0;i<digit.Length;i++)
{
    if (digit[i] == digit[digit.Length-i-1])diffDigitCounter++;
}
if (diffDigitCounter == digit.Length) WriteLine("This number is a palindrome");
else WriteLine($"This number is not a palindrome");