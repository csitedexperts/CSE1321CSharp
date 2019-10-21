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
            
            Console.WriteLine("d1 = " + d1);
            Console.WriteLine("d2 = " + d2);
            Console.ReadKey();

            Console.WriteLine("d3 = " + d3);
            Console.WriteLine("d4 = " + d4);
         


            
            Console.WriteLine("=================");
            Dog d5 = new Dog();
            Dog d6 = new Dog();

            d5.setName ("Massie"); // d5's name = "Massie"
            d5.age = 3.5F;
            d5.isTrained = true;
            d5.color = "Black";
            d5.weight = 45;

            Console.WriteLine("d5 = " + d5);
            Console.WriteLine("d5's name = " + d5.getName());
            Console.WriteLine("d5's age = " + d5.age);

            d5.canMove();
            d5.makeSound();

            Console.WriteLine("d6 = " + d6);

            d6.setName("Tonny"); // d6's name = "Tonny"
            d6.age = 2F;

            d6.isTrained = false;
            d6.color = "White";
            d6.weight = 15;

            Console.WriteLine("d6 = " + d6);
            Console.WriteLine("d6's name = " + d6.getName());
            Console.WriteLine("d6's age = " + d6.age);

            d6.canMove();
            d6.makeSound();

            Console.WriteLine("d5 = " + d5);
            Console.WriteLine("d6 = " + d6);
            Console.ReadKey();


        }
    }
}
