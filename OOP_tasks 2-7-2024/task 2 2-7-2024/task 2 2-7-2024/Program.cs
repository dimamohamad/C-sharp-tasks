using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace task_2_2_7_2024
{
    internal class Program
    {
        //        1.	Define an Interface
        //o   Create an interface named ISound that includes a method void MakeSound();.

        public interface ISound
        {

            void MakeSound();

        }
        //        2.	Define an Abstract Class
        //o Create an abstract class named Animal that includes:
        //	A property string Name { get; set; }.
        //	A constructor that takes a string name parameter and sets the Name property.
        //	An abstract method void Eat();.
        //	A concrete method void Sleep() that prints out the animal's 
        public abstract class Animal
        {
            protected string Name { get; set; }
            public Animal(string name)
            {
                Name = name;
            }
            public abstract void Eat();
            public void Sleep()
            {
                Console.WriteLine($"tha animal {Name} is Sleeping ");
            }

        }
        //   3.Implement Concrete Classes
        //o   Create two classes, Dog and Cat, that:
        //	Inherit from Animal.
        //	Implement the ISound interface.
        //	Provide specific implementations for the Eat method that print out the animal's name followed by what it is eating.
        //	Provide specific implementations for the MakeSound method that print out the animal's name followed by the sound it makes (e.g., "Woof!" for dogs and "Meow!" for cats).
        public class Dog : Animal, ISound
        {
            public Dog(string name) : base(name) { }

            public override void Eat()
            {
                Console.WriteLine($"{Name} is eating dog food.");
            }

            public void MakeSound()
            {
                Console.WriteLine($"{Name} says Woof 3aw 3aw 3aw!");
            }
        }

        class Cat : Animal, ISound
        {
            public Cat(string name) : base(name) { }
            public override void Eat()
            {
                Console.WriteLine($"{Name} is eating cat food.");
            }
            public void MakeSound()
            {
                Console.WriteLine($"{Name} says Meow meow meow !");
            }

        }
        //        4.	Create a Program to Test Your Classes
        //o   In the Main method, create instances of Dog and Cat.
        //o Call the Eat, Sleep, and MakeSound methods on each instance.

        static void Main(string[] args)
        {
            Dog dog =new Dog("Summer");
            Cat cat = new Cat("winter");
            dog.MakeSound();
            dog.Sleep();
            dog.Eat();
            cat.MakeSound();
            cat.Eat();
            cat.Sleep();

        }
    }
}
