using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _30_6_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Write a function in C# that accept 10 numbers and return sum and average.
            //•	Test Data :
            //•	Input the 10 numbers:
            //•	Number - 1 :2
            //•	Number - 10 :2
            //•	Expected Output :
            //•	The sum of 10 no is : 55
            //•	The Average is : 5.500000


            //Class1 arrObj = new Class1();
            //int[] array = new int[10];
            //Console.WriteLine("Please enter a 10 numbers");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = Convert.ToInt32(Console.ReadLine());

            //}
            //Averagey(array);
            //var result = Averagey(array);
            //Console.WriteLine($" The average of numbers:{Averagey(array)}");


            //Class1 numberObj2 = new Class1();
            //Console.Write("Please enter a  number");
            //int x = Convert.ToInt32(Console.ReadLine());
            //numberObj2.Cube(x);
            //  3 - Write a program in C# return only numbers in the years array greater than 1950.

            //const years = [1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020]

            //function getYears(years)
            //            {

            //            }
            //int [] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            //Class1 yearObj2 = new Class1();
            //yearObj2.GetYears(years);
            //4 - Create a function that takes the age in years and returns the age in days.
            Class1 yearsObj3 = new Class1();
            int age=  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(yearsObj3.Getage(age));

            //        5-	Create class that contain the following field:
            //a.Age  between 18-60
            //b.Gender
            //c.Name
            //d.E-Mail
            //e.	ID
            //f.	Phoneshould be started in 077 or 078 or 079
            //Don’t forget the default value.
            CheckValidation person = new CheckValidation(25, "Female", "Dima", "dima@gmail.com", "2016988053", "0791161122");
            person.ShowData();






        }


        //public static  (double sum, double avg) Averagey(int[] arr)
        //{
        //    double sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];

        //    }
        //    double avg = sum / arr.Length;
        //    return (sum, avg);
        //}

        Console.ReadLine();
    }

}
