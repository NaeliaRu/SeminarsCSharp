/*Написать программу, которая принимает на вход координаты некоторой точки, не нулевые, 
и выдает номер четверти плоскости, в которой она находится.

int FindQuart(double x, double y)
{
    int num = 0;

    if(x > 0 && y > 0) num = 1;
    if(x < 0 && y > 0) num = 2;
    if(x < 0 && y < 0) num = 3;
    if(x > 0 && y < 0) num = 4;
    
    return num;
}

Console.Write("Input x-coordinate: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y-coordinate: ");
double y = Convert.ToDouble(Console.ReadLine());

int quartNum = FindQuart(x, y);
Console.WriteLine($"The point A({x}, {y}) is in {quartNum} quart");*/

/*Написать программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в двухмерном пространстве
4 аргументы double, т.к. у каждой точки 2 координаты

double FindDistans(double x, double x1, double y, double y1)
{
    double num = 0;
    num = (x1 - x)*(x1 - x) + (y1 - y)*(y1 - y);
    num = Math.Sqrt(num);
    return num;
}

Console.Write("Enter coordinate x of the first point: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter coordinate x1 of the first point: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter coordinate y of the second point: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter coordinate y1 of the second point: ");
double y1 = Convert.ToDouble(Console.ReadLine());

double findDistans = FindDistans(x, x1, y, y1);
Console.WriteLine(findDistans);*/

/*Написать программу, которая принимает на вход некоторое число "n" 
и выдает в качестве результата ряд квадратов чисел от 1 до "n".
Используем метод void. Выводим числа прямо внутри метода. 
Аргумент типа int

void ShowNumbers(int num)
{
    int count = 1;
    while(count <= num)
    {
        double n = Math.Pow(count, 2);
        Console.Write(n + " ");
        count ++;
    }
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowNumbers(number); */