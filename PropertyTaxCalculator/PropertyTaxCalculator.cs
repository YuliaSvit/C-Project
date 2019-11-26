using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyTaxCalculator
{
    class PropertyTaxCalculator
        
    {
        private decimal millage_rate = 10.03M;
        private decimal assessment_increase =0.027M;
        private decimal exemption = 25000;
  
        public  PropertyTaxCalculator(string propAddress,decimal propValLY, decimal propValCY)
        {
        PropertyAddress = propAddress ;
        PropertyValueLastYear = propValLY;
        PropertyValueCurrentYear = propValCY;

        }
        public decimal PropertyValueLastYear { get; set; }
        public decimal PropertyValueCurrentYear { get; set; }
        public string PropertyAddress { get; set; }

        public decimal CalculateNewAssessedValue()
        {
            return PropertyValueLastYear * (1 + assessment_increase);
        }

        public decimal CalculateTaxDue()
        {
            return (PropertyValueCurrentYear - exemption) / 1000 * millage_rate;
        }

        public decimal CalculateTaxableValue()
        {
            return PropertyValueCurrentYear - exemption;
        }

        public override string ToString()
        {
            return string.Format("Property Address:{0}\n" +
                "Last Year Assessed Value:{1:C}\n" +
                "Current Assessed Value:{2:C}\n" +
                "Exemption:{3:C}\n" +
                "Taxable Value:{4:C}\n" +
                "Millage Rate:{5:C}\n" +
                "Taxes Due:{6:C}", PropertyAddress, PropertyValueLastYear, PropertyValueCurrentYear, exemption,
                CalculateTaxableValue(), millage_rate, CalculateTaxDue());
        }
    }
}
