using System;

namespace SalarySlip
{

                          /*
 
 
 
 
                                       LINK TO THE UML DIAGRAM: https://imgur.com/a/WOaMkZz
 
 
 
                          */


    class Employee 
    {
        protected int BaseSalary = 1500;
        protected int FuelAllowance;
        protected int MedicalAllowance;

        public int GrossSalary()
        {
            return BaseSalary + FuelAllowance + MedicalAllowance;
        }
    }

    class Engineer : Employee
    { 
        public Engineer()
        {
            FuelAllowance = 100;
            MedicalAllowance = 500;
        }
    }

    class Manager : Employee
    {
        public Manager()
        {
            FuelAllowance = 250;
            MedicalAllowance = 1000;
        }
    }
    class Analyst : Employee
    {
        public Analyst()
        {
            FuelAllowance = 150;
            MedicalAllowance = 800;
        }
    }

    public class SalarySlip 
    {
        private int totalSalary;
        public SalarySlip()
        {
            Console.Write("What is your designation. Type 'E' for Engineer, 'M' for Manager, 'A' for Analyst: ");
            string designation = Console.ReadLine().ToUpper();

            if(designation is "E")
            {
                Employee engineer = new Engineer();
                totalSalary = engineer.GrossSalary();
                Console.WriteLine("Gross salary for this engineer is : ${0}", totalSalary);
            }
            else if (designation is "M")
            {
                Employee manager = new Manager();
                totalSalary = manager.GrossSalary();
                Console.WriteLine("Gross salary for this manager is : ${0}", totalSalary);
            }
            else if (designation is "A")
            {
                Employee analyst = new Analyst();
                totalSalary = analyst.GrossSalary();
                Console.WriteLine("Gross salary for this analyst is : ${0}", totalSalary);
            }
            else
            {
                Console.WriteLine("Sorry, that is not a valid designation");
            }
        }
    }


    class Program
    {
        public static void Main(string[] args)
        {
            SalarySlip slip = new SalarySlip();
        }
    }
}

