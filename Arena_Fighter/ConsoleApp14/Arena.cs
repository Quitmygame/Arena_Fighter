using ConsoleApp14;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Arena
    {
        public Arena() { }

        public void Start()
        {
            Fighter[] fighters = new Fighter[]
            {
                new Soldier("Солдат Алекс"),
                new Rascal("Дуэлянт Джек"),
                new Magician("Маг Мерлин"),
                new Paladin("Паладин Артур"),
                new Barbarian("Варвар Конан")
            };

            Console.WriteLine("Добро пожаловать на арену!");
            Console.WriteLine("Выберите двух бойцов для битвы:");

            for (int i = 0; i < fighters.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {fighters[i].Title} {fighters[i].Name}");
            }

            int fighter1Index = GetUserInput("Введите номер первого бойца: ", 1, fighters.Length) - 1;
            int fighter2Index = GetUserInput("Введите номер второго бойца: ", 1, fighters.Length) - 1;

            Fighter fighter1 = fighters[fighter1Index];
            Fighter fighter2 = fighters[fighter2Index];

            Console.WriteLine($"{fighter1.Title} {fighter1.Name} против {fighter2.Title} {fighter2.Name}!");

            while (fighter1.IsLive && fighter2.IsLive)
            {
                fighter1.DealDamage(fighter2);
                if (fighter2.IsLive)
                {
                    fighter2.DealDamage(fighter1);
                }
            }

            Console.WriteLine(fighter1.IsLive ? $"{fighter1.Title} {fighter1.Name} победил!" : $"{fighter2.Title} {fighter2.Name} победил!");
        }

        private bool IsInputNumber(string input, out int number)
        {
            return int.TryParse(input, out number);
        }

        private int GetUserInput(string prompt, int minValue, int maxValue)
        {
            int userInput;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (IsInputNumber(input, out userInput))
                {
                    if (userInput >= minValue && userInput <= maxValue)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Введите число от {minValue} до {maxValue}.");
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                }
            }

            return userInput;
        }
    }
}