using System;
using System.Collections.Generic;
using System.Text;

namespace Loan_Program
{
    public class AutoLoan:Loan
    {
        //constructor
        public AutoLoan(string loanType,int loanNum, string custFN, string custLN, double rate, double loanAm, double numYears, int yearBuiltAuto, string model, string make, string color):base(loanType,loanNum, custFN, custLN, rate, loanAm, numYears)
        {
            YearBuiltAuto = yearBuiltAuto;
            Model = model;
            Make = make;
            Color = color;
        }
        //properties
        public int YearBuiltAuto { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string Color { get; set; }

        //override ToString Method
        public override string ToString()
        {
            return base.ToString() +
                "\n\tYear Built: " + YearBuiltAuto.ToString() +
                "\n\tModel: " + Model +
                "\n\tMake: " + Make +
                "\n\tColor: " + Color;
        }
        //Calculate Interest Rate Method
        public override decimal CalculateInterest()
        {
            decimal numOfPayments = Convert.ToDecimal(NumOfYearsLoanTerm) / 12;
            decimal loanPrincipal = Convert.ToDecimal(LoanAmount + 1000);
            return Convert.ToDecimal(InterestRate) / numOfPayments * loanPrincipal;
        }

    }



}
