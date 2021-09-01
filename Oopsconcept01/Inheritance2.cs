using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oopsconcept01
{
        public class Animal
        {
            public void eat() 
            {
                Console.WriteLine("Eating...");
                Console.ReadLine();
            }
        }
        public class Dog : Animal
        {
            public void bark() 
            {
                Console.WriteLine("Barking...");
                Console.ReadLine();
            }
        }
}

