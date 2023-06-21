using System;

namespace SealedClass
{
    class Animal
    {
        public virtual void makeSound()
        {
            Console.WriteLine("Animal Sound");
        }
    }

    class Dog : Animal
    {
        //sealed method
        sealed public override void makeSound()
        {
            Console.WriteLine("Dog Sound");
        }
    }

    class Puppy : Dog
    {
        // trying to overide sealed method
        public  void makemySound()
        {
            Console.WriteLine("Puppy Sound");
        }
    }

    class Program
    {
        static void Main (string [] args)
        {
            //create an object of Puppy class
            Puppy puppy = new Puppy();
            puppy.makemySound();

            Dog dog = new Dog();
            dog.makeSound();

            Animal animal = new Animal();
            animal.makeSound();

            Console.ReadLine();
        }
    }
}
