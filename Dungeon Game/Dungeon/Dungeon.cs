using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon
{
    public class Dungeon
    {
        public List<DungeonRooms> SetOfRooms { get; set; }
        static int DiceRoll()
        {
            Random rand = new Random();
            return rand.Next(1, 20);
        }
        static void Attack(Character character, Character monster)
        {
            int roll = DiceRoll();
            if (roll <= (character.CalcuateHitChance() - monster.Block))
            {
                int damage = character.CalculateDamage();
                monster.Health -= damage;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{monster.Name} takes {damage} damage!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{character.Name} missed");
                Console.ResetColor();
            }
        }


        static void Main(string[] args)
        {
            Console.Title = "Welcome to Dungeon Game";
            Weapon stick = new Weapon("Stick", 1, 10, false, 1);
            Character phil = new Character("Phil", 100, 5, 50, stick);
            bool exit = false;

            do
            {
                Character bob = new Character("bob", 10, 3, 5, stick);
                do
                {
                    Console.WriteLine("Please select an action!\n1.Attack\n2.Flee\n3.Player Info\n4.Monster Info\n5.Extit");
                    ConsoleKey userSelection = (Console.ReadKey(true).Key);
                    switch (userSelection)
                    {
                        case ConsoleKey.D1:
                            {
                                Attack(phil, bob);
                                break;
                            }
                        case ConsoleKey.D2:
                            {
                                break;
                            }
                        case ConsoleKey.D3:
                            {
                                break;
                            }
                        case ConsoleKey.D4:
                            {
                                break;
                            }
                        case ConsoleKey.D5:
                            {
                                exit = true;
                                break;
                            }

                        default:
                            {
                                exit = true;
                                break;
                            }
                    }
                    if (phil.Health <= 0)
                    {
                        exit = true;
                    }
                }
                while (!exit);
            }
            while (!exit);
        }


        
    }


}
