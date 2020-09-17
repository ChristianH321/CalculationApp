using System;
using System.Globalization;

namespace PriceCalculation
{
    public class Program
    {
            private int noOfPassengers;
            private int kilometer;
            private int priceperkilometer;


        public static void Main(string[] args)
        {
            double price = TotalCost(0, 0);
        }   

        public static double TotalCost(int noOfPassengers, int kilometer)
        {
            double cost3 = 0;
            double cost2 = 0;
            double cost1 = 0;

            if (kilometer < 100)
            {
                double priceperkilometer = 3.20;
                double initialfee = 130.00;
                cost1 = kilometer * priceperkilometer + initialfee;

            }
            else if (kilometer > 100 && kilometer < 500 && noOfPassengers < 12)
            {
                double priceperkilometer = 2.75;
                double initialfee = 130.00;
                cost2 = kilometer * noOfPassengers * priceperkilometer + initialfee;
            }
            else if (noOfPassengers > 12)
            {
                double priceperkilometer = 3.00;
                double initialfee = 130.00;
                cost3 = kilometer * noOfPassengers * priceperkilometer + initialfee;
            }
            else{

                return 0;
            }

            double totalCost = cost1 + cost2 + cost3;

            return totalCost;


        }


    }
}
