using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogClass
{
    class DogMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            int x1;
            x1 = 15;
            // int x1 = 20;
            Console.WriteLine("x1 = " + x1);

            Dog d1 = new Dog();
            Dog d2 = new Dog();

            // Dog(String name, float age, bool isTrained,  String color, float weight)
            Dog d3 = new Dog("Tammy", 12, true, "Black", 23);
            Dog d4 = new Dog("Aammy", 2, false, "White", 12);
            Dog d5 = new Dog("Nammy",  6, true, "Black and White", 30);
            Dog d6 = new Dog("Happy", 2, false, "Red", 35);

            Console.WriteLine("d1 = " + d1);
            Console.WriteLine("d2 = " + d2);
            Console.WriteLine("d3 = " + d3);
            Console.WriteLine("d4 = " + d4);
            Console.WriteLine("d5 = " + d5);
            Console.WriteLine("d6 = " + d6);

            Console.ReadKey();


            /*
            Console.WriteLine("=================");

            d1.name = "Lassie"; // d1's name = "Lassie"
            d1.age = 3.5F;
            d1.isTrained = true;
            d1.color = "Black";
            d1.weight = 45;

            Console.WriteLine("d1 = " + d1);
            Console.WriteLine("d1's name = " + d1.name);
            Console.WriteLine("d1's age = " + d1.age);

            d1.canMove();
            d1.makeSound();

            Console.WriteLine("d1 = " + d1);

            d2.name = "Tommy"; // d2's name = "Tommy"
            d2.age = 2F;

            d2.isTrained = false;
            d2.color = "White";
            d2.weight = 15;

            Console.WriteLine("d2 = " + d2);
            Console.WriteLine("d2's name = " + d2.name);
            Console.WriteLine("d2's age = " + d2.age);

            d2.canMove();
            d2.makeSound();
            */

        }
    }
}
