using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введеите свое имя");
            string name = Console.ReadLine();
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i] + " ");
            }
            Console.WriteLine($"Последняя буква вашего имени {name[^1]}");
        }
    }
}
