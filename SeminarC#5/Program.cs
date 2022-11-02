/*Задать массив из 12 элементов, заполненный случайными числами из промежутка от -9 до 9
включительно и найти сумму отрицательных элементов в данном массиве*/

/*int[] CreateArray(int size)
{
    int[] array = new int[size];
    Console.WriteLine("Creating array:");
    for(int i =0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} element of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Complete!");
    return array;
}

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

int SumOfNegatives(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            sum += array[i];
    }

    return sum;
}

Console.Write("Input numbers of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int result = SumOfNegatives(myArray);

Console.WriteLine("Sum of negative elements is" + result);*/

/*Напишите программу замены элементов массивов. 
Положительные элементы заменить на соответствующие отрицательные, а отрицательные на положительные.*/

/*int[] CreateRandomArray(int size, int minValue, int maxValue)
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

int[] ReversArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] *= -1;
    return array;
}

Console.Write("Input numbers of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] YourArray = CreateRandomArray(size, min, max);
ShowArray(YourArray);
YourArray = ReversArray(YourArray);
ShowArray(YourArray);*/

/*Необходимо задать массив из 12 случайных чисел. 
Необходимо найти количество элементов массива значения которых лежат в отрезке от 10 до 99*/

/*int[] CreateRandomArray(int size, int minValue, int maxValue)
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

int СountValue (int[] array)
{
    int current = 0;
    for(int i = 0; i < array.Length; i++)

        if (array[i] > 9 && array[i] < 100)
            current++;
    
    return current;
}

Console.Write("Input numbers of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array1 = CreateRandomArray(size, min, max);
ShowArray(array1);
int result = СountValue(array1);
Console.WriteLine("Number of elements in the array from 10 to 99: " + result);*/


/*Необходимо написать программу, которая определяет, присутсвует ли заданное число в массиве*/

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

bool FindNumber(int[] array, int num)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == num)
            return true;
    }

    return false;
}

Console.Write("Input numbers of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array1 = CreateRandomArray(size, min, max);
ShowArray(array1);

Console.Write("Add your number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(FindNumber(array1, num))
    Console.Write("Your number is in the array: ");
else
{
    Console.Write("There isn't your number in the array: ");
}

