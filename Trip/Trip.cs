using System;
using System.Collections.Generic;
using System.Text;

namespace Trip
{
    class Trip
    {
        // variables
        private string destination;
        private double distanceTraveled;
        private double totalCostOfGas;
        private double numberOfGallonsConsumed;

        //Constructors
        public Trip (string destinationC, double distanceTraveledC,double totalCostOfGasC,double numberOfGallonsConsumedC)
        {
            Destiantion=destinationC ;
            DistanceTraveled = distanceTraveledC; ;
            TotalCostOfGas=totalCostOfGasC;
            NumberOfGallonsConsumed = numberOfGallonsConsumedC;
        }

        //Properties
       public string Destiantion { get; set; }
       public double DistanceTraveled { get; set; }
       public double TotalCostOfGas { get; set; }
       public double NumberOfGallonsConsumed { get; set; }

        //Methods

        //Miles per Gallon
        public double CalculateMilesPerGallon()
        {
            double mPG = DistanceTraveled / NumberOfGallonsConsumed;
            return mPG;
        }
        //Cost per Mile
        public double CalculateCostPerMile()
        {
            double cPM = TotalCostOfGas / DistanceTraveled;
            return cPM;
        }

        //String Method
        public override string ToString()
        {
           return  "Be ready for your next epic trip. If you want to go to " + Destiantion + " you have to  drive " + DistanceTraveled + " miles. And it will cost you " + TotalCostOfGas + "$";
        }
    }
}
