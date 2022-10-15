//Написать программу, которая принимает двухзначное число и показывает наибольшую цифру этого числа.
/*
int FindBiggerDigit(int num)
{
    int result;

     if(num < 10 || num >= 100)
        return 0;
     else
     {
        int ed = num % 10;
        int dec = num / 10;

        if (ed > dec)
            result = ed;
        else
            result = dec;
     } 
     return result;  
}

Console.Write("Input a two-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int biggerDigit = FindBiggerDigit(number);

Console.WriteLine($"Bigger digit of {number} is {biggerDigit}"); */

/* Задача: написать программу, которая выводит случайное трехзначное число и удаляет вторую цифруэтого числа.

int RemoveSecond(int num)
{
    int first = num % 10;
    int third = num / 100;
    int result = third * 10 + first;
    return result;
}

int number = new Random().Next(100, 999);
Console.WriteLine(number);
Console.WriteLine(RemoveSecond(number)); */

// Задача: написать программу, которая принимает на вход число n и проверяет: кратно ли это число одновременно числам a и b, где a и b - целые численные делители

bool Del(int num, int divisor1, int divisor2)
{
    if( num % divisor1 == 0 && num % divisor1 == 0)
    {
        return true;
    }
    return false;
}

Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Input first divisor: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second divisor: ");
int b = Convert.ToInt32(Console.ReadLine());

bool result = Del(number, a, b);
Console.WriteLine($"Result: {result}");



