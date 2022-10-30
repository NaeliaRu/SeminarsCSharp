/* Написать программу, которая принимает на вход число и выдает сумму чисел от 1 до этого числа

int GetSum(int num)
{
    int sum = 0;

    for(int current = 1; current <= num; current++)
        sum += current; // sum = sum + current;
    return sum;
}

Console.Write("Input a positive integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

int s = GetSum(a);
Console.WriteLine($"Sum of numbers from 1 ti {a} is {s}");*/

/* Написать прошрумму, кторая принимает на вход число и отображает количество цифр в числе


int CountInt (int number)
{
    int count = 0;
    
    if (number < 0) number *= -1; // number = number * -1

    while (number > 0)
    {
        number /= 10; // number = number / 10
        count++;
    }

    return count;
}

Console.WriteLine("Input a number: ");
Console.WriteLine($"The number of digit in a number {CountInt(Convert.ToInt32(Console.ReadLine()))}");*/

/*Написать программу, которая принимает на вход число и выдает произведение (факториал) чисел от 1 до этого числа*/

/*int Fact (int number)
{
    int f = 1;
    if (number < 0) return -1;

    for(int i = 1; number >= i; i++)
    {
        f*=i;
    }

    return f;
}

Console.WriteLine("Input a number: ");
int f = Fact(Convert.ToInt32(Console.ReadLine()));
if (f == -1) Console.WriteLine("Факториал не может быть отрицательным");
else
Console.WriteLine($"Factorial of your number is {f}");*/

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

/*Написать программу, которая выводит массив из м элементов, заполненный 0 и 1 в случайном порядке.*/

Console.Write("Input number of element: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

