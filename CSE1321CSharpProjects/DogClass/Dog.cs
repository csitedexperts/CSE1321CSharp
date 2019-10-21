using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogClass
{
    class Dog
    {
        public String name;
        public float age;
        public bool isTrained;
        public String color;
       // public String color {get; set;}
        public float weight;

        //public string color { get => color; set => color = value; }

        public String getName()
        {
            return name;
        }
        public void setName(String name)
        {
            this.name = name;

        }

        public Dog()
        {
            name = "Belley";
            age = 2;
            isTrained = true;
            color = "White";
            weight = 34;
            //Console.WriteLine("The Dog() constructor is  called....");
        }

        public Dog(String Name, float age, bool isTrained, String color, float weight)
        {
            name = Name;
            this.age = age;
            this.isTrained = isTrained;
            this.color = color;
            this.weight = weight;

            //Console.WriteLine("The Dog() constructor is  called....");
        }


        public void canMove()
        {
            Console.WriteLine("My doc can move ....");
        }

        public void makeSound()
        {
            Console.WriteLine("My doc can make sound....");

        }

        public override string ToString()
        {

            return name + " " + age + " " + isTrained + " " + color + " " + weight;
        }

     }
    }
