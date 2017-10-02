using System;

namespace Shapes
{

    class App
    {
        public App()
        {
            
        }


        public void Run()
        {
            Triangle triangle1 = new Triangle();

            Console.WriteLine("Enter the height of the triangle: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the base length of the triangle: ");
            double baseLength = Convert.ToDouble(Console.ReadLine());
            
            triangle1.Height = height;
            triangle1.BaseLength = baseLength;

            Console.Write("The area of the triangle is ");
            Console.WriteLine( triangle1.GetArea() );
        }
    
    }
}