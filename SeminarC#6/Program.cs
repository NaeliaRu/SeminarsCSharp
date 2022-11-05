/* Написать программу, которая перевернет одномерный массив*/

/*int[] CreateRandomArray()
{
    Console.Write("Input numbers of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);

    return array;
}*/

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

/*void ChangeArray(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

int[] myArray = CreateRandomArray();
ShowArray(myArray);
ChangeArray(myArray);
ShowArray(myArray);*/

/* Написать программу, которая принимает на вход три целых числа и проверяет: 
может ли существовать треугольник со сторонами такой длины. 
Правило существования треугольника: каждая сторона треугольника должна быть строго меньше суммы двух других сторон*/

/*bool Triangle(int a, int b, int c)
{
    if (a + b > c && a + c > b && c + b > a) return true;
    else return false;
    // или return a+b>c && a+c>b && b+c>a; вместо if....else
}

Console.Write("Input first value: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second value: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third value: ");
int num3 = Convert.ToInt32(Console.ReadLine());
bool triangle = Triangle(num1, num2, num3);
if(triangle) Console.Write("Triangle exist");
else Console.Write("Triangle does not exist");*/

/* Необходимо написать программу, которая будет создавать копию задонного массива
с помощью поэлементного копирования.*/

/*int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];

    for(int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;
}

int[] array = CreateRandomArray();
ShowArray(array);
ShowArray(CopyArray(array));*/

/* Не используя рекурсию вывести n чисел Фебоначчи. Первые два числа - это а и b.*/

int[] Fibonacci(int n, int a, int b)
{
    int[] array = new int[n];
    array[0] = a;
    array[1] = b;

    for(int i = 2; i < n; i++)
    {
        array[i] = array[i-2] + array[i-1];
    }
    return array;
}

Console.Write("Input number of numbers in sequence: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input first number in sequence: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number in sequence: ");
int b = Convert.ToInt32(Console.ReadLine());
int[] febonacci = Fibonacci(n, a, b);
ShowArray(febonacci);
