using System;

namespace Chapter_11_Question_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] phrases = new string[] { "The product is excellent.", "This is a great product.", 
                "I use this product constantly.", "This is the best product from this category." };
            string[] stories = new string[] { "Now I feel better.", "I managed to change.", "It made some miracle.", 
                "I can’t believe it, but now I am feeling great.", "You should try it, too. I am very satisfied." };
            string[] authorFirstName = new string[] { "Dayan", "Stella", "Hellen", "Kate" };
            string[] authorLastName = new string[] { "Johnson", "Peterson", "Charls" };
            string[] cities = new string[] { "London", "Paris", "Berlin", "New York", "Madrid" };

            Console.WriteLine("{0} {1} -- {2} {3}, {4}.", phrases[rnd.Next(4)], stories[rnd.Next(5)], 
                authorFirstName[rnd.Next(4)], authorLastName[rnd.Next(3)], cities[rnd.Next(5)]);

        }
    }
}
