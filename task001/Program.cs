/ Создаем функцию по вводу размера массива
int ReadInt(string text)
    {
        System.Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }
// Создаем функцию по заполнению массива
int[] GenerateArray(int size, int leftRange, int rightRange)
    {
        int[] tempArray = new int[size];
        Random rand = new Random();

        for (int i = 0; i < size; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return tempArray;
    }
// Создаем функцию по выводу массива
void PrintArray(int[] array)
    {
        System.Console.WriteLine($"[{string.Join(", ", array)}]");
    }
// создаем функцию по нахождению количества чисел, которое заканчивается на 1 и делится на 7
int CountDivBy7(int[] array)
{
    int count = 0;
// foreach (int number in array) 
//     if (number % 7 == 0 && number % 10 ==1) {
//         count++;
//     }
    for (int number =0; number < array.Length; number++)
    {
        if (array[number] % 7 == 0 && array[number] % 10 ==1){
            count++;
    }
    }
            return count;
}
// Основная программа

int size = ReadInt("Введите размер массива: ");
int[] myArray = GenerateArray(size, 0, 100);
myArray[1] = 21;
PrintArray(myArray);

int count = CountDivBy7(myArray);

Console.WriteLine($"Количество чисел, которые оканчиваются на 1 и делятся нацело на 7 = {count}");

// Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.
// 5 12 16 q [STOP]
// 3 45 342 15 [STOP]