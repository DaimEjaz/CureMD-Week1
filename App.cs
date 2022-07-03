using System;

namespace CarParkingCalculator
                                              /*




 
                                              LINK TO THE UML DIAGRAM: https://imgur.com/a/sKyN6Jh






                                              */
{
    //PARENT CLASS
    public class Vehicle
    {
    
        protected double MinimumRate;
        private double HoursParked;
        public double TotalCharge;
        private double ExtraHours;
        protected double Overhead;
        protected double MaximumCharge;
        protected bool IsInputValid = true;

        //Constructor must be initialized with hours parked
        public Vehicle(double Hours)
        {
            HoursParked = Hours;
        }

        public double CalculateCharge()
        {

            if (HoursParked > 3)
            {
                ExtraHours = HoursParked - 3;
            }
            else
            {
                ExtraHours = 0;
            }

            if (HoursParked <= 3 && HoursParked > 0)
            {
                TotalCharge = MinimumRate;
            }
            else if (HoursParked > 3 && HoursParked < 24)
            {
                TotalCharge = MinimumRate + (ExtraHours * Overhead);
            }
            else if (HoursParked == 24)
            {
                TotalCharge = MaximumCharge;
            }
            else
            {
                IsInputValid = !IsInputValid;
            }

            var result = IsInputValid ? "Total Charge is: ${0} " : "Invalid input hours";
            Console.WriteLine(result, TotalCharge);

            return TotalCharge;
        }

    }

    //CHILD CLASSES : BIKE, CAR, BUS
    public class Bike : Vehicle
    {
      
        private double HoursParked;

        public Bike(double Hours) : base(Hours)
        {
            HoursParked = Hours;
            base.MinimumRate = 2.0;
            base.Overhead = 0.5;
            base.MaximumCharge = 10;
        }
       
    }

    public class Car : Vehicle
    {

        private double HoursParked;

        public Car(double Hours) : base(Hours)
        {
            HoursParked = Hours;
            base.MinimumRate = 4.0;
            base.Overhead = 1.0;
            base.MaximumCharge = 20;
        }

    }

    public class Bus : Vehicle
    {

        private double HoursParked;

        public Bus(double Hours) : base(Hours)
        {
            HoursParked = Hours;
            base.MinimumRate = 6.0;
            base.Overhead = 1.5;
            base.MaximumCharge = 30;
        }

    }


    class Program
    {
        
        static void Main(string[] args)
        {

            Vehicle bike1 = new Bike(24);
            bike1.CalculateCharge();

            Vehicle bike2 = new Bike(5);
            bike2.CalculateCharge();

            Vehicle bike3 = new Bike(1);
            bike3.CalculateCharge();

            Vehicle car1 = new Car(24);
            car1.CalculateCharge();

            Vehicle car2 = new Car(5);
            car2.CalculateCharge();

            Vehicle car3 = new Car(1);
            car3.CalculateCharge();

            Vehicle bus1 = new Bus(24);
            bus1.CalculateCharge();

            Vehicle bus2 = new Bus(5);
            bus2.CalculateCharge();

            Vehicle bus3 = new Bus(1);
            bus3.CalculateCharge();
        }
    }
}
