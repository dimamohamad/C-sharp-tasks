using System;
using System.Runtime.Remoting.Channels;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   Write a C# Sharp program to calculate the factorial of a given number.

            //2 - Write a program in C# Sharp to display the n terms of even natural number and their sum.

            //3 - Write a program in C# Sharp to find the sum of the series 1 +11 + 111 + 1111 + .. n terms.
            //4 - Write a C# Sharp program to determine whether a given number is prime or not.
            //Write a program that displays the second largest integer among five integers

            Console.Write("Please enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 2; i <= x; i++)
            {
                factorial *= i;


            }
            Console.WriteLine("The factorial is:{0}", factorial);

            double num = 0;
            double sum = 0;
            Console.Write("Please enter  how many iteration of the series you wanna to calculate: ");
            int iteration = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < iteration; i++)
            {
                num += Math.Pow(10, i);
                sum += num;

            }
            Console.WriteLine("the summation of numbers {0}", sum);



            int num1, y = 0;
            Console.Write("Please enter the number you want to check:");
            num1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < num1; i++)
            {
                if (i % num1 == 0)
                {
                    y++;
                }
            }
                if (y == 2)
                {
                    Console.WriteLine("this number is not a prime one");
                }
                else
                {
                    Console.WriteLine("this number is prime");
                }
            
        }
    }
}
