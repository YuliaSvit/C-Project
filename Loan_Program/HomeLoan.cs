using System;
using System.Collections.Generic;
using System.Text;

namespace Loan_Program
{
    public class HomeLoan:Loan
    {
        //constructor
        public HomeLoan(string loanType, int loanNum, string custFN, string custLN, double rate, double loanAm, double numYears, string address, int yearBuild, string sqFoot):base(loanType, loanNum, custFN, custLN, rate, loanAm, numYears)
        {
            Address = address;
            YearBuild = yearBuild;
            SquareFootage = sqFoot;
        }
        //properties
        public string Address { get; set; }
        public int YearBuild { get; set; }
        public string SquareFootage { get; set; }

        //override ToString method from base class
        public override string ToString()
        {
            return base.ToString() +
                "\n\tAddress: " + Address +
                "\n\tYear Build: " + YearBuild.ToString() +
                "\n\tSquare Footage: " + SquareFootage;
        }
        //Calculate Interest Rate Method
        public override decimal CalculateInterest()
        {
            decimal numOfPayments = Convert.ToDecimal( NumOfYearsLoanTerm) / 12;
            decimal loanPrincipal = Convert.ToDecimal(LoanAmount + 5000);
            return Convert.ToDecimal(InterestRate) / numOfPayments * loanPrincipal;
        }

    }
}
