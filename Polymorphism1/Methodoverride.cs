using System;

namespace Polymorphism1
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating...");
            Console.ReadLine();
        }
    }
    public class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating bread...");
            Console.ReadLine();
        }
    }
}
