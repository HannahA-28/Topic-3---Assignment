using System.Formats.Asn1;

namespace Topic_3___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hannah Anderson

            Console.WriteLine("Part 1");
            string name = "Hannah";
            int age = 16;
            double height = 1.73;

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(height);
            Console.WriteLine();


            Console.WriteLine("Part 1");
            int roomNumber = 29;
            double price = 2.99;
            string phrase = "computer science!";


            Console.WriteLine("Your room number is " + roomNumber);
            Console.WriteLine("The price is " + price.ToString("C"));
            Console.WriteLine("I am learning a bit about " + phrase);
            Console.WriteLine();


            Console.WriteLine("Part 2");
            String Name = "Hannah Anderson";
            String graduationYear = "2026";
            Console.WriteLine("My name is " + Name + " and I'll graduate in " + graduationYear);
            Console.WriteLine();


            Console.WriteLine("Part 3");
            double radius = 4.0;
            double area = Math.PI + Math.Pow(radius, 2.0);
            Console.WriteLine("What is the area for a circle with a radius of 4.0");
            Console.WriteLine(area);
            Console.WriteLine("The area for a circle with a radius of " + radius + " equals " + area);
            Console.WriteLine();


            Console.WriteLine("Part 4");
            int Area = 8;
            int number = 4;
            Console.WriteLine("The perimeter of a square with an area of " + Area + " equals " + (number * Area));
        }
    }
}
