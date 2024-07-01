using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _1_7_2024
{

    //int year;
    //string type;
    //double price;
    //string caremake;
    //string color;
    //string model;
    //string palletnumber;
    //public int Year
    //{
    //    set { year = value; }
    //    get { return year; }
    //}
    //public string Type
    //{
    //    set { type = value; }
    //    get { return type; }
    //}
    //public double Price
    //{
    //    set {price = value; }
    //    get { return price; }
    //}
    //public string Caremake

    //     {
    //        set { caremake= value; }
    //        get { return caremake; }
    //    }

    //public string Color
    //{
    //    set { color = value; }
    //    get { return color; }
    //}
    //public string Model
    // {
    //    set { model = value; }
    //    get { return model; }
    //}
    //public string Palletnumber
    //{
    //    set {palletnumber = value; }
    //    get { return palletnumber; }
    //}

    //public Car(int year, string type, double price, string caremake, string color, string model, string palletnumber)
    //{

    //}


    public class Car
    {
        public int Year { get; set; }
        public string Carmake { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public string Model { get; set; }
        public string Palletnumber { get; set; }
        public string Color { get; set; }

        // Constructor
        public Car(int year, string type, double price, string carmake, string color, string model, string palletnumber)
        {
            Year = year;
            Type = type;
            Price = price;
            Carmake = carmake;
            Color = color;
            Model = model;
            Palletnumber = palletnumber;
        }

        public void Startengine()
        {
            Console.WriteLine("the car is ready to start");
        }

        public void Stoptengine()
        {
            Console.WriteLine("the car is ready to dead");
        }
        public string Carinfo()
        {
            //return ("the Car is {3} made in {0} and the type is {1} and the price of it is {2} model {5} and the palet number of it is {6} with color of {4}",Year,Type,Price,Carmake,Color,Model,Palletnumber);
            return $"The car is {Carmake} made in {Year} and the type is {Type}. The price of it is {Price}, model {Model} and the pallet number is {Palletnumber} with a color of {Color}.";
        }

    }
    public class BMW : Car
    {
        public BMW(int Year, string Type, double Price, string Carmake, string Color, string Model, string Palletnumber)
            : base(Year, Type, Price, Carmake, Color, Model, Palletnumber)
        {

            Carinfo();

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //1.	Implement a Car class which has fields to store the car's make, year, Type, Price, model, Pallet No, and color
            Car car = new Car(2024, "SUV", 39000, " Suzuki", "Black", " D4Max", "9876DEF");

            // Printing the Car object information
            Console.WriteLine(car.Carinfo());
            car.Startengine();
            car.Stoptengine();
            BMW bmw = new BMW(2022, "Sedan", 41.250, "BMW", "white", "330i", " 6789XYZ");
            Console.WriteLine(bmw.Carinfo());
        }
    }

}
