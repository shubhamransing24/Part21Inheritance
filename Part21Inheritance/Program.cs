using System;

namespace Part21Inheritance
{

    public class Employee
    {
        public string FirstName;
        public string LastName;
        //string Gender;
        //we use inheritance becouse of reusablity perpose
        //why to create firstname and lastname again and again in child classes use parent class fields
        public void PrintFullName()
        {
            Console.WriteLine("Full Name Of The Employee:{0} {1}",FirstName,LastName);

        }

    }


   public class FullTimeEmployee : Employee
    {
        int YearlySalary = 400000;

    }
   public class PartTimeEmployee :Employee
    {
        int HourlySalary = 400;
    }
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee();
            fte.FirstName = "Shubham";
            fte.LastName = "Ransing";
            PartTimeEmployee pte = new PartTimeEmployee();
            pte.FirstName = "Saurabh";
            pte.LastName = "Ransing"; ;
            fte.PrintFullName();
            pte.PrintFullName();
            
        }
    }
}
