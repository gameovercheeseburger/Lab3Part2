using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Part2
{
    class ProgramMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dog's name:");
            string dogName = Console.ReadLine();
            Dog dog = new Dog(dogName);
            Console.WriteLine($"Enter dog's colour:");
            string dogColour = Console.ReadLine();
            dog.SetColour(dogColour);
            Console.WriteLine($"Enter dog's age:");
            int dogAge = int.Parse(Console.ReadLine());
            dog.SetAge(dogAge);
            Console.WriteLine($"Enter dog's height:");
            int dogHeight = int.Parse(Console.ReadLine());
            dog.SetHeight(dogHeight);
            Console.WriteLine($"Dog: {dog.GetName()}, Colour: {dog.GetColour()}, Age: {dog.GetAge()}, Height: {dog.GetHeight()} cm");
            dog.Eat();
            Console.WriteLine($"Dog says: {dog.Cry()}");

            Console.WriteLine("\nEnter cat's name:");
            string catName = Console.ReadLine();
            Cat cat = new Cat(catName);
            Console.WriteLine($"Enter cat's colour:");
            string catColour = Console.ReadLine();
            cat.SetColour(catColour);
            Console.WriteLine($"Enter cat's age:");
            int catAge = int.Parse(Console.ReadLine());
            cat.SetAge(catAge);
            Console.WriteLine($"Enter cat's height:");
            int catHeight = int.Parse(Console.ReadLine());
            cat.SetHeight(catHeight);
            Console.WriteLine($"Cat: {cat.GetName()}, Colour: {cat.GetColour()}, Age: {cat.GetAge()}, Height: {cat.GetHeight()} cm");
            cat.Eat();
            Console.WriteLine($"Cat says: {cat.Cry()}");

            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(dog);
            animals.Add(cat);

            Dog anotherDog = new Dog("Bud");
            anotherDog.SetColour("Black");
            anotherDog.SetAge(5);
            anotherDog.SetHeight(60);
            animals.Add(anotherDog);

            Cat anotherCat = new Cat("Garf");
            anotherCat.SetColour("Orange");
            anotherCat.SetAge(3);
            anotherCat.SetHeight(30);
            animals.Add(anotherCat);

            Console.WriteLine("\nNames of all animals:");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }
}
