
// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.
// [344 452 341 125] => 2
// Создаем функцию по вводу размера массива
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

// Создаем функцию по наполнению массива
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
        System.Console.Write($"[{string.Join(", ", array)}]");
    }

// Создаем функцию по подсчету четных чисел в массиве
int CountdivTwo(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        count = count + 1;
    }
    return count;
}
// Решение основной задачи
int size = ReadInt("Введите размер массива: ");
int[] myArray = GenerateArray(size, 100, 999);
PrintArray(myArray);
int divTwo = CountdivTwo(myArray);
System.Console.WriteLine($" => {divTwo}");
