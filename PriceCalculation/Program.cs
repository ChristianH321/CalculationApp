using System;

namespace PriceCalculation
{
    public class Program
    {
            private int noOfPassengers;
            private int kilometer;
            private int priceperkilometer;


        public static void Main(string[] args)
        {
            double price = TotalCost(12, 100);
            
        }   

        public static double TotalCost(int noOfPassengers, int kilometer)
        {
            double cost3 = 0;
            double cost2 = 0;
            double cost1 = 0;
            if (kilometer < 100)
            {
                double priceperkilometer = 3.20;
                cost1 = kilometer * noOfPassengers * priceperkilometer;

            }
            else if (kilometer > 100 && kilometer < 500 && noOfPassengers < 12)
            {
                double priceperkilometer = 2.75;
                cost2 = kilometer * noOfPassengers * priceperkilometer;
            }
            else if (noOfPassengers > 12)
            {
                double priceperkilometer = 3.00;
                cost3 = kilometer * noOfPassengers * priceperkilometer;
            }
            else
            {
                Console.WriteLine("No Driving!");
            }

            double totalCost = cost1 + cost2 + cost3;
            return totalCost;


        }


    }
}
