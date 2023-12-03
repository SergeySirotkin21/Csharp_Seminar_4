
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
    int N;
    string sq = Console.ReadLine();
    if (int.TryParse(sq, out N))
    {
    i = CheckN(N);
    }
    else
    {
        i = 1;
    }
}
System.Console.Write("[STOP]");
