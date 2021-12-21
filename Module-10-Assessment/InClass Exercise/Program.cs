using System;
using System.Collections.Generic;

namespace InClass_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> inventory = new Dictionary<string, List<string>>()
            {
                { "gold", new List<string> {"500"} },
                { "pouch", new List<string> {"flint", "twine", "gemstone"} },
                { "backpack", new List<string> {"xyolphone", "dagger", "bedroll", "bread loaf"} }
            };

            inventory.Add("pocket", new List<string> { "seashell", "strange berry", "lint" });
            List<string> sortedList = inventory["backpack"];
            sortedList.Sort();
            inventory["backpack"] = sortedList;

            inventory["backpack"].Remove("dagger");


            inventory["gold"] = AddGold(inventory["gold"], 50);

            foreach(KeyValuePair<string, List<string>> item in inventory)
            {
                PrintItemInventory(item);
            }
            
        }
        public static List<string> AddGold(List<string> items, int valueToAdd)
        {
            int currentGoldAmount = Int32.Parse(items[0]);
            int newGoldAmount = currentGoldAmount + valueToAdd;
            return new List<string> { newGoldAmount.ToString() };
        }
        public static void PrintItemInventory(KeyValuePair<string, List<string>> items)
        {
            Console.WriteLine($"Item: {items.Key} \nContents: ");
            foreach(string str in items.Value)
            {
                Console.WriteLine(str);
                
            }
            Console.WriteLine();
        }
    }
}
