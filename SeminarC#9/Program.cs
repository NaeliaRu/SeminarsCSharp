/* Задача: задать значение N и написать программу, 
которая выведеть все натуральные числа в промежутке от 1 до N */

/*void ShowNums(int n)
{
    if(n > 1) ShowNums(n-1);
    Console.Write(n + " ");
}

ShowNums(5);*/

/*Написать программу, которая будет принимать на вход число и возвращать сумму его цифр*/

/* int SumOfDigits(int n)
{
    if(n != 0)  return SumOfDigits(n / 10) + n % 10;
    else return 0;
}

Console.WriteLine(SumOfDigits(1234));*/

/* Задача: задать значение N   M и написать программу, 
которая выведеть все натуральные числа в промежутке от M до N */

/* void ShowNumber(int m, int n)
{
    if(n == m) Console.Write(n + " ");
    if(n < m)
    {
        ShowNumber(m - 1, n);
        Console.Write(m + " ");
    }
    if(n > m)
    {
        ShowNumber(m, n - 1);
        Console.Write(n + " ");
    }
}
ShowNumber(5,1); */

/*Написать программу, которая на вход принимает числа А и В, и возводит число А в натуральную степень В
А в степени -В тоже что и 1/А в степени В*/

double ShowNumber (double a, double b)
{
    if(b < 0)
    {
        return 1/a * ShowNumber(a, b + 1);
    }
    if(b > 0)
    {
        return a * ShowNumber(a, b - 1);
    }
    return 1;
}
Console.Write(ShowNumber(2,-3));






