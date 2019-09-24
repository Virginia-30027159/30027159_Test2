using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            Salary s1 = new Salary();
            s1.AnnualSalary = 80000;

            Console.WriteLine($"your Salary is set at {s1.AnnualSalary} per year.");
            Console.WriteLine($"Your Weekly Salary per week is ${s1.DisplaySalary()}.\n\n");

            Wages w1 = new Wages();
            w1.HourlyRate = 33.72;

            Console.WriteLine($"I will calculate your Wages.");
            Console.Write($"Enter the number of hours worked: ");
            w1.NumHours = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your Wages per week is ${w1.DisplayWages()}.");
            Console.ReadLine();
        }
    }

    public class Salary
    {
        double annualSalary, weeklySalary;

        public double AnnualSalary 
        {
            get { return annualSalary; }
            set { annualSalary = value; }
        }
       public double WeeklySalary
        {
            get { return weeklySalary; }
            set { weeklySalary = value; }
        }
        public Salary()
        {
            WeeklySalary = DisplaySalary();
        }
       public double DisplaySalary()

        {
            return (annualSalary*7) / 365;
        }
    }

    public class Wages
    {
        double hourlyRate, weeklyWages;
        int numHours;
        public double HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }
        public double WeeklyWages
        {
            get { return weeklyWages; }
            set { weeklyWages = value; }
        }
        public int NumHours
        {
            get { return numHours; }
            set { numHours = value; }
        }

        public Wages()
        {
            WeeklyWages = DisplayWages();
        }
        public double DisplayWages()

        {
            return numHours * hourlyRate;
        }
    }
}
