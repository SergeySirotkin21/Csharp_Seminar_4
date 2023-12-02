
// Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.
// 5 12 16 q [STOP]
// 3 45 342 15 [STOP]

// Функция проверки на четность суммы цифр числа
int CheckN(int N)
{
    int k = 0;
    int sum = 0;
    while (N > 0)
    {
        int number = N % 10;
        sum = sum + number;
        N/=10;
    }
    if (sum % 2 == 0)
        k = 1;
    return k;
}
// Решение задачи

int i = 0; 
while ( i < 1)
{
    Console.Write("Введите число: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int s1 = Console.Read();
    if (s1 ==113)
    {
    System.Console.Write("[STOP]");
    break;
    }
    i = CheckN(N);
}
System.Console.Write("[STOP]");







// Создаем функцию по вводу размера массива
// int ReadInt(string text)
//     {
    //     System.Console.Write(text);
    //     return Convert.ToInt32(Console.ReadLine());
    // }

    // int[] GenerateArray(int size, int leftRange, int rightRange)
    // {
    //     int[] tempArray = new int[size];
    //     Random rand = new Random();

    //     for (int i = 0; i < size; i++)
    // {
    //     tempArray[i] = rand.Next(leftRange, rightRange + 1);
    // }

    // return tempArray;
    // }