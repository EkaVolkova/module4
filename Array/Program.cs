using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введеите свое имя");
            string name = Console.ReadLine();
            //Вывести в прямом порядке
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i] + " ");
            }
            Console.WriteLine($"Последняя буква вашего имени {name[^1]}");

            //Вывести в обратном порядке
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i] + " ");
            }

            //Двумерный массив
            Console.WriteLine("\n\nДвумерный массив");
            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
            Console.WriteLine("Нормальная форма");
            //Нормальное отображение
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
                    Console.Write(array[i, k] + " ");

                Console.WriteLine();
            }
            Console.WriteLine("Транспонирование");
            //Нормальное отображение
            for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
            {
                for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
                    Console.Write(array[k, i] + " ");

                Console.WriteLine();
            }

            //Сортировка
            Console.WriteLine("\n\nСортировка");
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int k = arr[i];
                        arr[i] = arr[j];
                        arr[j] = k;
                    }
                }
                
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            //Сумма элементов массива
            Console.WriteLine("\n\nСумма элементов массива");
            int Sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Sum += arr[i];
            }
            Console.WriteLine(Sum);

            //Зубчатый массив
            Console.WriteLine("\n\nЗубчатый массив");
            int[][] jagedArray = new int[3][];
            jagedArray[0] = new int[2] { 1, 2 };
            jagedArray[1] = new int[3] { 1, 2, 3 };
            jagedArray[2] = new int[5] { 1, 2, 3, 4, 5 };
            foreach(var arrays in jagedArray)
            {
                foreach (var items in arrays)
                {
                    Console.Write(items + " ");
                }
            }

            //Счетчик положительных чисел в массиве
            Console.WriteLine("\n\nСчетчик положительных чисел в массиве");
            int[] arrayWithNegative = { 1, -2, 3, -4, 5, -6 };
            Console.WriteLine("Исходный массив: ");
            int counterPositive = 0;
            foreach (var items in arrayWithNegative)
            {
                Console.Write(items + " ");
                if (items > 0)
                    counterPositive++;
            }
            Console.WriteLine("\nПоложительных элементов " + counterPositive);

            //Счетчик положительных чисел в двумерном массиве
            Console.WriteLine("\n\nСчетчик положительных чисел в двумерном массиве");
            int[,] array2WithNegative = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            Console.WriteLine("Исходный массив: ");
            counterPositive = 0;
            foreach (var items in array2WithNegative)
            {
                Console.Write(items + " ");
                if (items > 0)
                    counterPositive++;
            }
            Console.WriteLine("\nПоложительных элементов " + counterPositive);
        }
    }
}
