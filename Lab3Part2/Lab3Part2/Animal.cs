using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Part2
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }
        protected Animal(string name)
        {
            Name = name;
        }

        // Abstract method
        public abstract void Eat();

        public virtual string Cry()
        {
            return "animal sound";
        }
        public void SetColour(string colour)
        {
            Colour = colour;
        }
        public void SetAge(int age)
        {
            Age = age;
        }

        public void SetHeight(int height)
        {
            Height = height;
        }
        public string GetName()
        {
            return Name;
        }

        public string GetColour()
        {
            return Colour;
        }

        public int GetHeight()
        {
            return Height;
        }

        public int GetAge()
        {
            return Age;
        }
    }

}
