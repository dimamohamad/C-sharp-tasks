using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1-	Create console application that read string from user and print the same string
            string userInput;
            Console.WriteLine("please enter a string value");
            userInput = Console.ReadLine();
            Console.WriteLine(userInput);

            /*  2 - Define variables with kind of
                a.Double
                 b.String
                 c.Char
                  d.Bool
                 e.Int
                f.Const
                Then display it in console application*/
            double firstNumber = 5.6;
            string firstText = "dima";
            char firstLetter = 'D';
            bool OnOff = true;
            int secondNumber = 26; ;
            const double number = 3.14;
            Console.WriteLine(firstNumber);
            Console.WriteLine(firstText);
            Console.WriteLine(firstLetter);
            Console.WriteLine(OnOff);
            Console.WriteLine(secondNumber);
            Console.WriteLine(number);
            //3-	Define array with name car that hold more than 3 kinds on cars, then print all the cars with the array length.
            string[] carsArray = { "Mercedes", "tesla", "Suzuki" };
            Console.WriteLine(carsArray[0]);
            Console.WriteLine(carsArray[1]);
            Console.WriteLine(carsArray[2]);
            Console.WriteLine(carsArray.Length);
            Console.WriteLine("The length of the array is:" + carsArray.Length);


            /*4-	Write a program in C that reads a first name, surname and year of birth and display the names and the year one after another sequentially. Go to the editor
                    •	Input your firstname: Sami
                    •	Input your lastname: Ali
                    •	Input your year of birth: 1999
                    •	Sami Ali 1999
            */
            string firstName;
            Console.WriteLine("Please enter your first name");
            firstName = Console.ReadLine();
            string lastName;
            Console.WriteLine("Please enter your last name");
            lastName = Console.ReadLine();
            int birthYear;
            Console.WriteLine("Please enter your Birth year");
            birthYear = int.Parse(Console.ReadLine());
            Console.Write("Input your firstname:");
            Console.WriteLine(firstName);
            Console.Write("Input your lastname::");
            Console.WriteLine(lastName);
            Console.Write("Input your year of birth:");
            Console.WriteLine(birthYear);
            Console.Write(firstName + " ");
            Console.Write(lastName + "  ");
            Console.WriteLine(birthYear);

            /*
        5-	Write a program in C # to store elements in an array and print it. 
            •	Test Data :	
            •	Input 10 elements in the array :
            •	element - 0 : 1
            •	element - 1 : 1
            •	element - 2 : 2
                •	.......
            •	Expected Output :
            •	Elements in array are: 1 1 2 3 4 5 6 7 8 9
            */
            Console.WriteLine("Enter 10 number");

            int[] arrayOfNumber = new int[10];
            arrayOfNumber[0] = int.Parse(Console.ReadLine());
            arrayOfNumber[1] = int.Parse(Console.ReadLine());
            arrayOfNumber[2] = int.Parse(Console.ReadLine());
            arrayOfNumber[3] = int.Parse(Console.ReadLine());
            arrayOfNumber[4] = int.Parse(Console.ReadLine());
            arrayOfNumber[5] = int.Parse(Console.ReadLine());
            arrayOfNumber[6] = int.Parse(Console.ReadLine());
            arrayOfNumber[7] = int.Parse(Console.ReadLine());
            arrayOfNumber[8] = int.Parse(Console.ReadLine());
            arrayOfNumber[9] = int.Parse(Console.ReadLine());
            Console.Write("Elements in array are:");
            for (int i = 0; i < arrayOfNumber.Length; i++)
            {
                Console.Write(arrayOfNumber[i] + " ");
            }
            Console.WriteLine("");
            /*Write a program in C# to find the sum of all elements of the array.
            •	Test Data :
            •	index - 0 : 2
            •	index - 1 : 5
            •	index - 2 : 8
            •	Expected Output :
                Sum of all elements stored in the array is : 15

             */
            Console.WriteLine("insert 3 integer number");
            int[] arrayOfSum = new int[3];
            arrayOfSum[0] = int.Parse(Console.ReadLine());
            arrayOfSum[1] = int.Parse(Console.ReadLine());
            arrayOfSum[2] = int.Parse(Console.ReadLine());
            int theSum = arrayOfSum[0] + arrayOfSum[1] + arrayOfSum[2];
            Console.Write(" Sum of all elements stored in the array is :");
            Console.WriteLine(theSum);


        }
    }
}
