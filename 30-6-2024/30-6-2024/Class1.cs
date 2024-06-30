using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace _30_6_2024
{
    public class Class1
    {
        public int[] Arr = new int[10];
        public (double sum, double avg) Averagey(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

            }
            double avg = sum / Arr.Length;
            return (sum, avg);

        }
        //        2-	Write a program in C to display the cube of the number up to given an integer.
        //•	Test Data:
        //•	Input number of terms : 5
        //•	Expected Output :
        //•	Number is : 1 and cube of the 1 is :1
        //•	Number is : 2 and cube of the 2 is :8
        //•	Number is : 3 and cube of the 3 is :27
        //•	Number is : 4 and cube of the 4 is :64
        //•	Number is : 5 and cube of the 5 is :125
        int Num;
        public void Cube(int num)
        {
            this.Num = num;
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("The cubic of the {0} is:{1}", i, (i * i * i));
            }

        }

        public int GetYears(int[] year)
        {
            foreach (int i in year)
            {
                if (i > 1950)
                {
                    Console.WriteLine(i);
                }
            }
            return 0; ;

        }

        //4 - Create a function that takes the age in years and returns the age in days.
        public string Getage(int years)
        {
            return ($"The age in days is {years * 365}");
        }
        //        5-	Create class that contain the following field:
        //a.Age  between 18-60
        //b.Gender
        //c.Name
        //d.E-Mail
        //e.	ID
        //f.	Phoneshould be started in 077 or 078 or 079
        //Don’t forget the default value.


    }
    public class CheckValidation
    {
        public int Age;
        public string Gender;
        public string Name;
        public string EMail;
        public string ID;
        public string Phone;

        public  CheckValidation(int age, string gender, string name, string email, string id, string phone)
        {
            this.Age = age;
            this.Gender = gender;
            this.Name = name;
            this.EMail = email;
            this.ID = id;
            this.Phone = phone;
            if (age >= 18 && age <= 60)
            {
                Age = age;
            }
            else
            {
                Console.WriteLine("Age must be between 18 and 60");
            }
            if (gender == "Female" || gender == "Male")
            {
                Gender = gender;
                
            }
            else
            {
                Console.WriteLine("Gender must be either Male or Female");
            }
            Name = name;
            var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            if (emailRegex.IsMatch(email))
            {
                EMail = email;
            }
            else
            {
                throw new ArgumentException("Please enter a valid email");
            }
            ID = id;

            var phoneRegex = new Regex(@"^(079|077|078)\d{7}$");
            if (phoneRegex.IsMatch(phone))
            {
                Phone = phone;
            }
            else
            {
                throw new ArgumentException("Please enter a valid phone number");
            }
        }
        public void ShowData()

        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Email: {EMail}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Phone: {Phone}");
        }

    }
}
