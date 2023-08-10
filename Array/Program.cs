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
        }
    }
}
