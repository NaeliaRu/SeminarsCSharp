/* Задача: задать двумерный массия и написать программу, которая заменит строки на столбцы, 
а если это не возможно сообщит это пользователю.*/

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows,colums];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    }

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

/*  1 5 2       1 6 4       Не меняется главная диагональ
    6 3 8       5 3 7
    4 7 9       2 8 9 */

/*  void ChangeArray(int[,] array)
  {
    if(array.GetLength(0) != array.GetLength(1))
        Console.WriteLine("Impossible to change!");
    else
    for(int i = 0; i < array.GetLength(0) - 1; i++)
        for(int j = i + 1; j <array.GetLength(1); j++) // j = i + 1 идем с каждой строчки с элемента слежующего после главной диагонали
        {
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
  }

int[,] userArray = CreateRandom2dArray();
Show2dArray(userArray);
ChangeArray(userArray);
Console.WriteLine();
Show2dArray(userArray); */

/* --------------------------------------------------------------------------------------------------------------------- 
Задача: задать двумерный массив и написать программу, 
которая поменяет первую и последнюю строки массива (услож. вариант: поменет строки, номера которых укажем сами)*/

/*void ReChangeArray(int[,] array, int row1, int row2)
{
    if(row1 < array.GetLength(0) && row2 < array.GetLength(0))
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1,j];
            array[row1,j] = array[row2,j];
            array [row2,j] = temp;
        }
    else Console.WriteLine("Replacement is not possible");
}

int[,] userArray = CreateRandom2dArray();
Show2dArray(userArray);
Console.WriteLine("Input line 1: ");
int str1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input line 2: ");
int str2 = Convert.ToInt32(Console.ReadLine());
ReChangeArray(userArray, str1-1, str2-1);
Console.WriteLine();
Show2dArray(userArray);*/


/* ----------------------------------------------------------------------------------------------------------
Задача: из двумерного массива целых чисел удалить строку и столбец, 
на пересечении которых расположен наименьший элемент. */

int[,] CutArray(int[,] array)
{
    int mini = 0;
    int minj = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if(array[i,j] < array[mini,minj])
            {
                mini = i;
                minj = j;
            }
    
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for(int i = 0, x = 0; i < array.GetLength(1); i++)
        if(i != mini)
        {
            for (int j = 0, y = 0; j < array.GetLength(1); j++)
                if(j != minj)
                {
                    newArray[x,y] = array[i,j];
                    y++;
                }
            x++;
        }
    return newArray;
}

int[,] userArray = CreateRandom2dArray();
Show2dArray(userArray);
int[,] newArray = CutArray(userArray);
Console.WriteLine();
Show2dArray(newArray);