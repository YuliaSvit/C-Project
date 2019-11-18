using System;
using System.Collections.Generic;
using System.Text;

namespace Trip
{
    class Trip
    {
        // variables
        /*private string destination;
        private double distanceTraveled;
        private double totalCostOfGas;
        private double numberOfGallonsConsumed;*/

        //Constructors
        public Trip (string destinationC, double distanceTraveledC,decimal totalCostOfGasC,double numberOfGallonsConsumedC)
        {
            Destiantion=destinationC ;
            DistanceTraveled = distanceTraveledC; ;
            TotalCostOfGas=totalCostOfGasC;
            NumberOfGallonsConsumed = numberOfGallonsConsumedC;
        }

        //Properties
       public string Destiantion { get; set; }
       public double DistanceTraveled { get; set; }
       public decimal TotalCostOfGas { get; set; }
       public double NumberOfGallonsConsumed { get; set; }

        //Methods

        //Miles per Gallon
        public double CalculateMilesPerGallon()
        {
            return DistanceTraveled / NumberOfGallonsConsumed;
        }
        //Cost per Mile
        public decimal CalculateCostPerMile()
        {
            return TotalCostOfGas / Convert.ToDecimal(DistanceTraveled);
        }

        //String Method
        public override string ToString()
        {
            return "Destination: " + Destiantion +
                  "\nTotal Miles: " + DistanceTraveled +
                  "\nFuel Consumed: " + NumberOfGallonsConsumed.ToString("f1") + " gallons" +
                  "\nCost: " + TotalCostOfGas.ToString("c") +
                  "\nMiles Per Gallon: " + CalculateMilesPerGallon().ToString("f0") +
                  "\nCost Per Mile: " + CalculateCostPerMile().ToString("c");
        }
    }
}
