using System;

namespace AbstractionDemo
{
        public abstract class Shape
        {
            public abstract void draw();
        }
        public class Rectangle : Shape
        {
            public override void draw()
            {
                Console.WriteLine("drawing rectangle...");
                Console.ReadLine();
            }
        }
        public class Circle : Shape
        {
            public override void draw()
            {
                Console.WriteLine("drawing circle...");
                Console.ReadLine();
            }
        }
}

