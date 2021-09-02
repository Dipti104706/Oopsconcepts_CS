using System;

namespace AbstractionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape s;
            //s = new Rectangle();
            //s.draw();
            //s = new Circle();
            //s.draw();
            Pig myPig = new Pig();  // Create a Pig object
            myPig.animalSound();
        }
    }
}
