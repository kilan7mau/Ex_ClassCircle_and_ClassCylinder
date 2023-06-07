// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");
 
using System;
using Ex_ClassCircle_and_ClassCylinder;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Circle circle = new Circle(5, "blue");
            circle.getArea(circle.Radius);
            Console.WriteLine("Circle 1 is:");
            Console.WriteLine(circle.ToString());

            Console.WriteLine("Circle 2 is");
            Circle circle1 = new Circle();
            double radius;
            Console.WriteLine("Enter radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
            circle1.Radius = radius;
            string color;
            Console.WriteLine("Enter color: ");
            color = Console.ReadLine();
            circle1.Color = color;
            circle1.getArea(circle1.Radius);
            Console.WriteLine(circle1.ToString());
            
            
            
            Cylinder cylinder = new Cylinder(5, 10, "red");
            cylinder.getArea(cylinder.Radius, cylinder.Height);
            cylinder.getVolume(cylinder.Radius, cylinder.Height);
            Console.WriteLine("Cylinder 1 is:");
            Console.WriteLine(cylinder.ToString());
            
            
            Console.WriteLine("Cylinder 2 is:");
            Cylinder cylinder1 = new Cylinder();
            double height;
            Console.WriteLine("Enter height: ");
            height = Convert.ToDouble(Console.ReadLine());
            cylinder1.Height = height;
            Console.WriteLine("Enter radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
            cylinder1.Radius = radius;
            Console.WriteLine("Enter color: ");
            color = Console.ReadLine();
            cylinder1.Color = color;
            cylinder1.getVolume(cylinder1.Radius, cylinder1.Height);
            cylinder1.getArea(cylinder1.Radius, cylinder1.Height);
            Console.WriteLine(cylinder1.ToString());
        }
    }
}