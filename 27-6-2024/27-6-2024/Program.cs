using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _27_6_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            1 - Correct the syntax error:

            //•	string[] ARR = [1, 7  9  45,]
            //•	int arr2 = ["Str" "alex","moh"
            //•	string arr3= 'the','fox' 'over' lazy, 'dog',  ]


            int[] ARR = {1, 7, 9, 45};
            //string[] ARR = { "1", "7", "9", "45" };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = {" the", "fox"," over", "lazy", "dog "};


            //2 - What the index of "Banana","Tomato" ?
            // String[ ]  fruits = ["Tomato", "Banana", "Watermelon"]
            String[] fruits = { "Tomato", "Banana", "Watermelon" };
            Console.WriteLine($"The index of Banana is: {Array.IndexOf(fruits, "Banana")}");
            Console.WriteLine($"The index of Tomato is: {Array.IndexOf(fruits, "Tomato")}");

            //3 - Create an multiple arrays that represents your:
            //        •	Favorite Food(5 item)
            //        •	Favorite Sport(3 item)
            //        •	Favorite Movie(4 item)
            //            Then, print each array using foreach, and Loop Through an Array

            string[] foodArray = { "Mansaf", "Shawerma", "Burger", "Pasta", "Kabseh" };
            string[] sportArray = { "Tennis", "Basketball", "Swimming"};
            string[] movieArray = {"Pride and Prejudice",  "Youve got a mail","Forgotten","Lala land" };
                  Console.Write("This is my Favorite Food :");
            foreach (string food in foodArray)
            {
                Console.Write(" " + food + " ");
            }
            Console.WriteLine();
            Console.Write("This is my Favorite Sport :");

            foreach (string sport in sportArray)
            {
                Console.Write(" " + sport + " ");
            }
            Console.WriteLine();
            Console.Write("This is my Favorite Movie :");

            foreach (string movie in movieArray)
            {
                Console.Write(" " + movie + " ");
            }
            Console.WriteLine();


            //int[] numbers=new int[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    numbers[i]=Convert.ToInt32(Console.ReadLine().Split());
            //    Console.Write(" " + numbers[i] + " ");
            //}

            //4 - Write a program in C# to calculate the sum of three numbers with getting input in one line separated by a comma
            //•	Expected Output:
            //•	Input three numbers separated by comma: 5,10,15


            int firstNum, secondNum, thirdNum;
            string[] numbers = Console.ReadLine().Split(',');
            firstNum=Convert.ToInt32(numbers[0]);   
            secondNum=Convert.ToInt32(numbers[1]);
            thirdNum=Convert.ToInt32(numbers[2]);
            int sum=firstNum+secondNum+thirdNum;
            Console.WriteLine($"Input three numbers separated by comma: {firstNum}, {secondNum}, {thirdNum}");
            Console.WriteLine($"The summation of three numbers is: {sum}");

            //5 - Write a program in C# to display the n terms of odd number and their sum from [1- 100 ]. 
            //•	Test Data
            //•	The odd numbers are1 3 5 7 9 11 13 15 17 19……
            //•	The Sum of odd Numbers is: …...

            Console.Write("The odd numbers are: ");
            int Sum = 0;
            for (int i = 0; i <= 100; i++)
            {

                if (i % 2 != 0)
                {
                    Console.Write(" " + i + " ");
                    Sum += i;
                }


            }
            Console.WriteLine();
            Console.WriteLine($"The Sum of odd Numbers is: {Sum}");

            //6 - Write a program in C## to display the pattern like right angle triangle using an asterisk. Go to the editor
            //The pattern like:
            //   *
            //  **
            //  ***
            // ****


            int num, m, j, k;
            Console.Write("enter the level:");
            num = Convert.ToInt32(Console.ReadLine());
            for (m = 1; m <= num; m++)
            {
                for (j = 1; j < num - m + 1; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= m; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();

            }

            //-Write a program in C# to make such a pattern like right angle triangle with number increased by 1. Go to the editor
            //  The pattern like :

            //    1
            //   2 3
            //  4 5 6
            // 7 8 9 10


            int num1, num2,space, rows,num3, t = 1;  
            Console.Write("Input number of rows : ");  
            rows = Convert.ToInt32(Console.ReadLine());     

           space = rows + 4 - 1;  

            for (num1 = 1; num1 <= rows; num1++)  
            {
                for (num3 = space; num3 >= 1; num3--)  
                {
                    Console.Write(" ");  
                }
                for (num2 = 1;num2 <= num1; num2++)  
                {
                    Console.Write("{0} ", t++);  
                }
                Console.Write("\n");  
                space--;  
            }




        }
    }
}
