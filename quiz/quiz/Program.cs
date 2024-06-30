using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentInformation obj = new StudentInformation();
            obj.GetAverage("dima", 24, 26,50);
            PrintYourName obj1= new PrintYourName();
            obj1.yourName = "Layan";
            obj1.GetYourName();


            MathOp mathOp = new MathOp();
            double number = 7;
            double number1 = 10;
            double result = mathOp.Multiply(number, number1);
            Console.WriteLine("This the multiplyin " + result);


           SumOfNumbers arrobj = new SumOfNumbers();
            int[] array=new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i]=Convert.ToInt32(Console.ReadLine());
            
            }
            Console.WriteLine($" The average of numbers { arrobj.Averagey(array)}");
        }
    }
}
