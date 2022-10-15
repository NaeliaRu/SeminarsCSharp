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

// Задача: написать программу, которая выводит случайное трехзначное число и удаляет вторую цифруэтого числа.

int RemoveSecond(int num)
{
    int first = num % 10;
    int third = num / 100;
    int result = third * 10 + first;
    return result;
}

int number = new Random().Next(100, 999);
Console.WriteLine(number);
Console.WriteLine(RemoveSecond(number));
