using System;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            var (name, age) = ("Екатерина", 26);
            Console.WriteLine("Мое имя {0}", name);
            Console.WriteLine("Мне {0} лет", age);
            Console.WriteLine("Введите свое имя");
            name = Console.ReadLine();
            Console.WriteLine("Введите свой возраст");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Твое имя {0}\nТебе {1} лет", name, age);

        }
    }
}
