using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace quiz
{
  public class StudentInformation
    {
       public string Student_Name;
        public int First_Grade;
        public int Second_Grade;
        public int Final_Grade;
       public void GetAverage(string student_name, int first_grade, int second_grade, int final_grade) { 
         //this.Student_Name = student_name;
         // this.First_Grade = first_grade;   
         //   this.Second_Grade = second_grade;
         //     this.Final_Grade = final_grade;
         int avg=(first_grade+second_grade+final_grade)/3;

            Console.WriteLine($"the student name is {student_name} and{avg}");


        
        
        }
        
    }
    public class PrintYourName
    {
        public string yourName;
        public void GetYourName() {

            Console.WriteLine($"my name is {yourName}");
        }
    }
    public class MathOp
    {
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
    }
    public class SumOfNumbers {
        public int[] Arr = new int[10];
        public (double sum, double avg) Averagey(int[] arr)
        { double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

            }
           double avg=sum/Arr.Length;
            return(sum, avg);
            
        }

    }


}
