using System;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, int age) anketa;
            Console.WriteLine("Введите свое имя");
            anketa.name = Console.ReadLine();
            Console.WriteLine("Введите свой возраст");
            anketa.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Твое имя {0}\nТебе {1} лет", anketa.name, anketa.age);

        }
    }
}
