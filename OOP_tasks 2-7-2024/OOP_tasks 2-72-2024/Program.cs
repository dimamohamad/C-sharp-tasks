using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_tasks_2_7_2024
{
    internal class Program
    {
        //1.	Implement a Car class which has fields to store the car's
        //make, year, Type, Price, model, Pallet No, and color

        class Car
        {
            public string Carmake { get; set; }
            public int Year { get; set; }
            public string Type { get; set; }
            public double Price { get; set; }
            public string Model { get; set; }
            public string Palletnumber { get; set; }
            public string Color { get; set; }
            public Car(string carmake, int year, string type, double price, string model, string palletnumber, string color)
            {
                Carmake = carmake;
                Year = year;
                Type = type;
                Price = price;
                Model = model;
                Palletnumber = palletnumber;
                Color = color;
            }
            //2.	Create function name DisplayInfo take two parameters(make, year)
            public static void DisplayInfo(string carmake, int year)
            {
                Console.WriteLine($"the car is {carmake} made in {year}");
            }
            //3.	Create function name DisplayInfo take one parameters(make)
            public static void DisplayInfo(string carmake)
            {
                Console.WriteLine($"the car is {carmake}");
            }
            //4.	This class contain function name(Display) that print statement(Welcome Car)

            public void Display()
            {
                Console.WriteLine("Welcome Car");
            }



            //6 – repeat step 4 , 5 with Overriding Concept.
            //public virtual void Display() {
            //    Console.WriteLine("Welcome Car");
            //}


        }
        //5- create a BMW Class  inherit from Car Class
        //a.This class contain function name(Display) that print statement(welcome BMW)
        //b-  create object from  BMW then call the function Display

        class BMW : Car
        {
            public BMW(string Carmake, int Year, string Type, double Price, string Model, string Palletnumber, string Color)
            : base(Carmake, Year, Type, Price, Model, Palletnumber, Color)
            {


            }
            public void Display()
            {
                Console.WriteLine("Welcome BMW");
            }

            //6 – repeat step 4 , 5 with Overriding Concept.
            //public override void Display()
            //{
            //    Console.WriteLine("Welcome BMW");
            //}



        }





        static void Main(string[] args)
        {
            
            BMW bmw = new BMW("BMW", 2022, "Sedan", 41.250, "330i", " 6789XYZ", "white");
            bmw.Display();
           Car.DisplayInfo("BMW", 2022);
           Car.DisplayInfo("Bmw");

        }
    }
}
