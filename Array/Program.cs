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

        }
    }
}
