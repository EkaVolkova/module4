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

            (string Name, string Type, double Age, int NameCount) Pet;
            Console.WriteLine("Введите имя своего питомца");
            Pet.Name = Console.ReadLine();
            Console.WriteLine("Введите тип своего питомца");
            Pet.Type = Console.ReadLine();
            Console.WriteLine("Введите возраст своего питомца");
            Pet.Age = double.Parse(Console.ReadLine());
            Pet.NameCount = Pet.Name.Length;
            Console.WriteLine("Имя питомца: {0}\nТип питомца: {1}\nВозраст питомца: {2}\nКоличество символов в имени: {3}", Pet.Name, Pet.Type, Pet.Age, Pet.NameCount);


        }
    }
}
