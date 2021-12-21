using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[5];
            animals[0] = new Dog(12, "Dying", true);
            animals[1] = new Cat(12, "Dying", false);
            animals[2] = new Kitten(1, "Cute", true);
            animals[3] = new Frog(12, "Overlord of Frogling Culture", true);
            animals[4] = new TomCat(37, "Bald and Unemployed", true);

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
