using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2nd_day_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Write a C# program that accept two integers and display the smaller. 
            Console.WriteLine("Please insert two integer number:");
            int number1=Convert.ToInt32(Console.ReadLine());
            int number2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Min(number1,number2));


            //Write a C# conditional statement to find the sign  of input  number. Display sign. Go 
            //    •	Sample numbers: -7
            //    •	Output: The sign is -

            //Console.WriteLine("Please insert an integer number:");
            //int number3;
            //number3=int.Parse(Console.ReadLine());
            //  int sign=Math.Sign(number3);

            //Console.WriteLine(sign>0?"The sign is + ":sign<0?"The sign is - ":"The number is zero");

            Console.Write("Enter a number: ");
            int numse = int.Parse(Console.ReadLine());
            int signValue = Math.Sign(numse);
            string[] signs = { "-", "0", "+" };
            string sign = signs[signValue + 1];
            Console.WriteLine("The sign is " + sign);

            //3.Write a C# conditional statement to sort three numbers ascending. Use console to display the result.
            //    •	Sample numbers: 0, -1, 4
            //    •	Output: 4, 0, -1
            Console.WriteLine("Please insert a three integer number:");
            int firstNum=Convert.ToInt32(Console.ReadLine());
            int secondNum=Convert.ToInt32(Console.ReadLine());
            int thirdNum=Convert.ToInt32(Console.ReadLine());
            int x=Math.Max(firstNum,Math.Max( secondNum,thirdNum));
            int y = Math.Min(firstNum, Math.Min(secondNum, thirdNum));
            int middleNum = firstNum + secondNum + thirdNum - x - y;
            Console.WriteLine($"{x}, {middleNum} , {y} ");

            //4.Write a C# conditional statement to find the max of five numbers. Use console to display the result.
            //    •	Sample numbers: -5, -2, -6, 0, -1
            //    •	Output: 0

            Console.WriteLine("Please insert a five integer number:");
            int firstNum1 = Convert.ToInt32(Console.ReadLine());
            int secondNum2 = Convert.ToInt32(Console.ReadLine());
            int thirdNum3 = Convert.ToInt32(Console.ReadLine());
            int fourthNum = Convert.ToInt32(Console.ReadLine());
            int fifthNum = Convert.ToInt32(Console.ReadLine());
            int maxFirstNumber=Math.Max(firstNum1,Math.Max(secondNum2,thirdNum3));
            int maxNumber =Math.Max(maxFirstNumber,Math.Max(fourthNum,fifthNum));
            Console.WriteLine($"the Maximum number is {maxNumber}");

            //5.Write a C# program that converts kilometers per hour to miles per hour.  
            //        Expected Output:
            //        •	Input kilometers per hour: 15.
            //    •	9.320568 miles per hour
            Console.WriteLine("Please insert a speed in kilometers per hour ");
            int distance1 =Convert.ToInt32(Console.ReadLine());
            double distance = Convert.ToDouble(distance1 * 0.621371);
            Console.WriteLine($"the speed is {distance} miles per hour");

            //6.Write a C# program that takes hours and minutes as input and calculates the total number of minutes.
            //    •	Input hours: 5
            //    •	Input minutes: 37
            //    •	Total: 337 minutes.
            Console.WriteLine("Please insert a time in hours");
            int hour=Convert.ToInt32(Console.ReadLine());
             int minute1=hour*60;
            Console.WriteLine("Please insert a time in minutes");
            int minute=Convert.ToInt32(Console.ReadLine());
            int totalMinutes = minute + minute1;
            Console.WriteLine($"The total time is : {totalMinutes} minutes");

            //7.Write a program in C# that takes minutes as input and display the total number of hours and minutes. 
            //    •	Input minutes: 546
            //    •	9 Hours, 6 Minutes

            Console.WriteLine("Please insert a time in minute");
            int minutes;
            minutes=int.Parse(Console.ReadLine());
            int hours = minutes / 60;
            int modulusMinutes = minutes % 60;
            Console.WriteLine($"{hours} Hours, {modulusMinutes} Minutes");


            //8.Create string of array that contains 5 element of different sentence with different length.
            //    Print all elements with fixed length for each sentence.

            string[] array= new string[5];
            Console.WriteLine("Please insert five sentences");
            array[0]= Console.ReadLine();
            array[1]= Console.ReadLine();   
            array[2]= Console.ReadLine();
            array[3]= Console.ReadLine();
            array[4]= Console.ReadLine();
            Console.WriteLine($"{array[0]} and the length of it is {array[0].Length}");
            Console.WriteLine($"{array[1]} and the length of it is {array[1].Length}");
            Console.WriteLine($"{array[2]} and the length of it is {array[2].Length}");
            Console.WriteLine($"{array[3]} and the length of it is {array[3].Length}");
            Console.WriteLine($"{array[4]} and the length of it is {array[4].Length}");







        }
    }
}
