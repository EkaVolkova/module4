using System;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
			const int StopIndex = 3;
			//Wикл while
			int k = 0;
			Console.WriteLine("Цикл while");
			while (k < StopIndex)
            {
                Console.WriteLine(k);
				Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

				switch (Console.ReadLine())
				{
					case "red":
						Console.BackgroundColor = ConsoleColor.Red;
						Console.ForegroundColor = ConsoleColor.Black;

						Console.WriteLine("Your color is red!");
						break;
					case "green":
						Console.BackgroundColor = ConsoleColor.Green;
						Console.ForegroundColor = ConsoleColor.Black;

						Console.WriteLine("Your color is green!");
						break;
					case "cyan":
						Console.BackgroundColor = ConsoleColor.Cyan;
						Console.ForegroundColor = ConsoleColor.Black;

						Console.WriteLine("Your color is cyan!");
						break;
					default:
						Console.BackgroundColor = ConsoleColor.Yellow;
						Console.ForegroundColor = ConsoleColor.Red;

						Console.WriteLine("Your color is yellow!");
						break;
				}
				k++;

			}

			//Цикл do..while
			int t = 0;
			Console.WriteLine("\n\nЦикл do..while");
			do
			{
				Console.WriteLine(t);
				Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

				switch (Console.ReadLine())
				{
					case "red":
						Console.BackgroundColor = ConsoleColor.Red;
						Console.ForegroundColor = ConsoleColor.Black;

						Console.WriteLine("Your color is red!");
						break;
					case "green":
						Console.BackgroundColor = ConsoleColor.Green;
						Console.ForegroundColor = ConsoleColor.Black;

						Console.WriteLine("Your color is green!");
						break;
					case "cyan":
						Console.BackgroundColor = ConsoleColor.Cyan;
						Console.ForegroundColor = ConsoleColor.Black;

						Console.WriteLine("Your color is cyan!");
						break;
					default:
						Console.BackgroundColor = ConsoleColor.Yellow;
						Console.ForegroundColor = ConsoleColor.Red;

						Console.WriteLine("Your color is yellow!");
						break;
				}
				t++;
			} while (t < StopIndex);

			//Цикл for
			Console.WriteLine("\n\nЦикл for");
			for (int i = 0; i < StopIndex; i++)
            {
				Console.WriteLine(i);
				Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

				switch (Console.ReadLine())
				{
					case "red":
						Console.BackgroundColor = ConsoleColor.Red;
						Console.ForegroundColor = ConsoleColor.Black;

						Console.WriteLine("Your color is red!");
						break;
					case "green":
						Console.BackgroundColor = ConsoleColor.Green;
						Console.ForegroundColor = ConsoleColor.Black;

						Console.WriteLine("Your color is green!");
						break;
					case "cyan":
						Console.BackgroundColor = ConsoleColor.Cyan;
						Console.ForegroundColor = ConsoleColor.Black;

						Console.WriteLine("Your color is cyan!");
						break;
					default:
						Console.BackgroundColor = ConsoleColor.Yellow;
						Console.ForegroundColor = ConsoleColor.Red;

						Console.WriteLine("Your color is yellow!");
						break;
				}
			}
		}
    }
}
