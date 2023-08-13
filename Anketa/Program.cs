using System;

namespace Anketa
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int j = 0; j < 3; j++)
            {
                (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;

                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();
                Console.WriteLine("Введите фамилию");
                User.LastName = Console.ReadLine();
                Console.WriteLine("Введите логин");
                User.Login = Console.ReadLine();
                User.LoginLength = User.Login.Length;
                Console.WriteLine("Есть ли у Вас домашние животные? Да или нет");
                string temp = Console.ReadLine();
                User.HasPet = temp == "Да" || temp == "да";
                Console.WriteLine("Введите возраст пользователя");
                User.Age = double.Parse(Console.ReadLine());
                User.favcolors = new string[3];
                Console.WriteLine("Введите три любимых цвета через Enter");
                for (int i = 0; i < 3; i++)
                {
                    User.favcolors[i] = Console.ReadLine();
                }
            }
        }
    }
}
