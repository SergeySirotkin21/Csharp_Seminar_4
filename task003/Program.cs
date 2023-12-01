
// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)
// [1 3 5 6 7 8] => [8 7 6 5 3 1]
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

// Создаем функцию которая перевернет одномерный массив
int[] MirrorArray(int[] array)
{
    int[] mirArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        mirArray[i] = array[array.Length -1 -i];
    }
    return mirArray;
}
// Решение основной задачи
int size = ReadInt("Введите размер массива: ");
int[] myArray = GenerateArray(size, 1, 9);
PrintArray(myArray);
int[] newArray = MirrorArray(myArray);
System.Console.Write("  =>  ");
PrintArray(newArray);

