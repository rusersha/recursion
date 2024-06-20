// Задайте произвольный массив. Выведете его элементы, начиная с конца.
//  Использовать рекурсию, не использовать циклы.

static void PrintArrayReversed(int[] arr, int index)
    {
        if (index < arr.Length && index >= 0)
        {
            PrintArrayReversed(arr, index + 1);
            Console.Write(arr[index] + " ");
        }
    }

    
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Элементы массива в обратном порядке:");
        PrintArrayReversed(array, 0);
    