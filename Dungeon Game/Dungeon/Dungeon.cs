using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon
{
    public class Dungeon
    {
        public static List<DungeonRooms> SetOfRooms = new List<DungeonRooms>();


        public static List<Character> SetOfMonsters = new List<Character>();
        static int Randomizer(int length)
        {
            Random rand = new Random();
            return rand.Next(1, length);
        }

        static int DiceRoll()
        {
            Random rand = new Random();
            return rand.Next(1, 20);
        }
        static void Attack(Character character, Character monster, ref bool exit, ref bool exit2)
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
                exit = false;
            }
            if (Healthcheck(monster) == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{monster.Name} is dead");
                Console.WriteLine("You win!!!!");
                Console.ResetColor();
                monster.Health = monster.MaxLife;
                exit = true;

            }
            else
            {
                if (roll <= (monster.CalcuateHitChance() - character.Block))
                {
                    int damage = monster.CalculateDamage();
                    character.Health -= damage;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{character.Name} takes {damage} damage!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{monster.Name} missed!");
                    Console.ResetColor();
                }
            }
            if (Healthcheck(character) == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{character.Name} is dead");
                Console.WriteLine("GAME OVER!");
                Console.ResetColor();
                exit = true;
                exit2 = true;
                
            }
            else
            {
                exit2 = false;
            }


        }
        static void Flee(Character character, Character monster, ref bool exit, ref bool exit2)
        {
            int roll = DiceRoll();
            if (roll <= (monster.CalcuateHitChance() - character.Block))
            {
                int damage = monster.CalculateDamage();
                character.Health -= damage;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{character.Name} takes {damage} damage!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{character.Name} fleed!");
                Console.ResetColor();
                exit2 = false;
                exit = true;
            }
            if (Healthcheck(character) == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{character.Name} is dead");
                Console.WriteLine("GAME OVER!");
                Console.ResetColor();
                exit = true;
                exit2 = true;
            }
        }

        static bool Healthcheck(Character character)
        {
            if (character.Health <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            
            Weapon stick = new Weapon("Stick", 1, 10, false, 1);
            SetOfRooms.Add(new DungeonRooms("Hallway", "A Dark Hallway with Candles"));
            SetOfRooms.Add(new DungeonRooms("Entryway", "Majestic"));
            SetOfRooms.Add(new DungeonRooms("Throne Room", "Covered in Gold"));
            SetOfRooms.Add(new DungeonRooms("Bathroom", "Why are you here, and what is that on the wall!"));
            SetOfMonsters.Add(new Character("Orc", 10, 3, 3, stick));
            SetOfMonsters.Add(new Character("Wolf", 10, 3, 3, stick));
            SetOfMonsters.Add(new Character("Troll", 10, 3, 3, stick));
            SetOfMonsters.Add(new Character("Dragon", 10, 3, 3, stick));
            int lenghtofRoomList = SetOfRooms.Count;
            int lengthOfMonsterList = SetOfMonsters.Count;
            //Console.WriteLine(lenghtofRoomList);



            Console.Title = "Welcome to Dungeon Game";

            Console.WriteLine("Enter a name for your character");
            string userName = Console.ReadLine();
            Character userCharacter = new Character(userName, 15, 10, 10, stick);
            
            bool exit2 = false;

            do
            {
                int roomNumber = Randomizer(lenghtofRoomList);
                int monsterNumber = Randomizer(lengthOfMonsterList);
                bool exit = false;
                do
                {
                    Console.WriteLine($"You enter the {SetOfRooms[roomNumber].RoomName}.");
                    Console.WriteLine($"Description: {SetOfRooms[roomNumber].RoomDescription}.");
                    Console.WriteLine($"You see a {SetOfMonsters[monsterNumber].Name}");
                    //how can i call the name of the weapon the monster is using?

                    Console.WriteLine("Please select an action!\n1.Attack\n2.Flee\n3.Player Info\n4.Monster Info\n5.Exit");
                    ConsoleKey userSelection = (Console.ReadKey(true).Key);
                    switch (userSelection)
                    {
                        case ConsoleKey.D1:
                            {

                                Attack(userCharacter, SetOfMonsters[monsterNumber], ref exit, ref exit2);
                                Console.WriteLine(exit);
                                break;
                                
                            }
                        case ConsoleKey.D2:
                            {
                                Flee(userCharacter, SetOfMonsters[monsterNumber], ref exit, ref exit2);
                                break;
                            }
                        case ConsoleKey.D3:
                            {
                                Console.WriteLine(userCharacter);
                                exit = false;
                                break;
                            }
                        case ConsoleKey.D4:
                            {
                                Console.WriteLine(SetOfMonsters[monsterNumber]);
                                exit = false;
                                break;
                            }
                        case ConsoleKey.D5:
                            {
                                exit = true;
                                exit2 = true;
                                break;
                            }

                        default:
                            {
                                exit = true;
                                exit2 = true;
                                break;
                            }
                    }
                    //if (userCharacter.Health <= 0)
                    //{
                    //    exit = true;
                    //}
                }
                while (!exit);
            }
            while (!exit2);
        }


        
    }


}
