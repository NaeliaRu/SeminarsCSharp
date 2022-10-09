// Console.Write("Inpur a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Your number is " + num);

/*Console.Write("Input a first number; ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
int q2 = n2 * n2;
if (n1 == q2)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");
    */

    //Задача 2. Напишитепрограмму, которая на вход принимает одно число N, а на выходе показывает последовательность часел от отрицательного значения до положительного.
    /*Console.Write("Input a number ");
    int n = Convert.ToInt32(Console.ReadLine ());
    int current = -n;

    if(n < 0)
    {
        current = n;
        n = -n;
    }
    while(current <= n)
    {
        Console.Write(current + " ");
        current++;
    }
    */

    //Задача: написать код, который запрашивает трехщначное число и на выходе показывает последнюю цифру этого числа
    Console.Write("Input a three-digit number: ");
    int n = Convert.ToInt32(Console.ReadLine());

    if(n >= 100 && n < 1000)
    {
        int lastDigit = n % 10;
        //Console.WriteLine("Last digit of " + n + " is " + lastDigit);
        Console.WriteLine($"Last digit of {n} is {lastDigit}");
    }
    else
    {
        Console.WriteLine("Uncorrect input!");
    }