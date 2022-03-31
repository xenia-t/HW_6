// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.

int M = Promt("\nВведите длину массива: ");
Console.WriteLine();

if (M > 0)
{
    int[] array = InputArray(M);
    PrintArray(array);
    Console.WriteLine($"Количество чисел больше 0 составляет {cout(array)}\n");
}

else Console.WriteLine("Введено некорректное значение длины массива\n");


int Promt(String message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int[] InputArray (int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i} элемент массива ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("\nМассив: [ ");
    foreach (int digit in array)
    {
        Console.Write(digit + " ");
    }
    Console.WriteLine("]\n");
}

int cout(int[] array)
{
    int cout = 0;
    foreach (int digit in array)
    {
        if (digit > 0) cout++;
    }
    return cout;
}



