using System;

class Program
{
    static void Main()
    {
        // Для правильного відображення кирилиці
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Завдання 2: Додавання і видалення елементів масиву");
        Console.WriteLine(new string('-', 50));

        // ================== Блок 1 ==================
        Console.WriteLine("Блок 1 — Додавання елементу в кінець масиву");

        int[] array = { 0, 1, 3, 4, 5, 2, 1, -4, -1, 10, 55 };
        int valueToAdd = 20;

        int[] largerArray = new int[array.Length + 1];
        for (int i = 0; i < array.Length; i++)
            largerArray[i] = array[i];
        largerArray[array.Length] = valueToAdd;
        array = largerArray;

        Console.WriteLine("Масив після додавання елементу в кінець:");
        foreach (int item in array) Console.Write(item + " ");
        Console.WriteLine("\n");

        // ================== Блок 2 ==================
        Console.WriteLine("Блок 2 — Додавання елементу на початок");

        array = new int[] { 0, 1, 3, 4, 5, 2, 1, -4, -1, 10, 55 };
        valueToAdd = 10;

        largerArray = new int[array.Length + 1];
        largerArray[0] = valueToAdd;
        for (int i = 0; i < array.Length; i++)
            largerArray[i + 1] = array[i];
        array = largerArray;

        Console.WriteLine("Масив після додавання елементу на початок:");
        foreach (int item in array) Console.Write(item + " ");
        Console.WriteLine("\n");

        // ================== Блок 3 ==================
        Console.WriteLine("Блок 3 — Додавання елементу в позицію 4");

        array = new int[] { 0, 1, 3, 4, 5, 2, 1, -4, -1, 10, 55 };
        valueToAdd = 10;
        int position = 4;

        largerArray = new int[array.Length + 1];
        for (int i = 0, j = 0; i < largerArray.Length; i++)
        {
            if (i == position)
                largerArray[i] = valueToAdd;
            else
            {
                largerArray[i] = array[j];
                j++;
            }
        }
        array = largerArray;

        Console.WriteLine($"Масив після додавання елементу в позицію {position}:");
        foreach (int item in array) Console.Write(item + " ");
        Console.WriteLine("\n");

        // ================== Блок 4 ==================
        Console.WriteLine("Блок 4 — Видалення елементу з кінця");

        array = new int[] { 0, 1, 3, 4, 5, 2, 1, -4, -1, 10, 55 };
        int[] smallerArray = new int[array.Length - 1];
        for (int i = 0; i < smallerArray.Length; i++)
            smallerArray[i] = array[i];
        array = smallerArray;

        Console.WriteLine("Масив після видалення елементу з кінця:");
        foreach (int item in array) Console.Write(item + " ");
        Console.WriteLine("\n");

        // ================== Блок 5 ==================
        Console.WriteLine("Блок 5 — Видалення елементу з початку");

        array = new int[] { 0, 1, 3, 4, 5, 2, 1, -4, -1, 10, 55 };
        smallerArray = new int[array.Length - 1];
        for (int i = 1; i < array.Length; i++)
            smallerArray[i - 1] = array[i];
        array = smallerArray;

        Console.WriteLine("Масив після видалення елементу з початку:");
        foreach (int item in array) Console.Write(item + " ");
        Console.WriteLine("\n");

        // ================== Блок 6 ==================
        Console.WriteLine("Блок 6 — Видалення елементу з позиції 5");

        array = new int[] { 0, 1, 3, 4, 5, 2, 1, -4, -1, 10, 55 };
        position = 5;
        smallerArray = new int[array.Length - 1];
        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (i == position) continue;
            smallerArray[j] = array[i];
            j++;
        }
        array = smallerArray;

        Console.WriteLine($"Масив після видалення елементу з позиції {position}:");
        foreach (int item in array) Console.Write(item + " ");
        Console.WriteLine("\n");

        // ================== Блок 7 ==================
        Console.WriteLine("Блок 7 — Об’єднання двох масивів");

        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 4, 5, 6 };
        int[] result = new int[array1.Length + array2.Length];

        for (int i = 0; i < array1.Length; i++) result[i] = array1[i];
        for (int i = 0; i < array2.Length; i++) result[array1.Length + i] = array2[i];

        Console.WriteLine("Об'єднаний масив:");
        foreach (int item in result) Console.Write(item + " ");
        Console.WriteLine("\n");

        Console.WriteLine("Всі блоки виконані. Натисніть будь-яку клавішу для виходу.");
        Console.ReadKey();
    }
}