using System;
using System.Collections.Generic;
using System.Text;

namespace Loan_Program
{
    public abstract class Loan
    {
        //Constructor
        public Loan(string loanType,int loanNum, string custFN, string custLN,double rate,double loanAm,double numYears)
        {
            LoanType = loanType;
            LoanNumber = loanNum;
            CustomerFirstName = custFN;
            CustomerLastName = custLN;
            InterestRate = rate;
            LoanAmount = loanAm;
            NumOfYearsLoanTerm = numYears;
        }
        //properties
        public string LoanType { get; set; }
        public int LoanNumber { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public double InterestRate { get; set; }
        public double LoanAmount { get; set; }
        public double NumOfYearsLoanTerm { get; set; }

        //Override ToString method to display  data about the loan
        public override string ToString()
        {
            return "Loan Information: " +
                "\n\tLoan Type: "+LoanType+
                "\n\tLoan Number: " + LoanNumber +
                "\n\tCustomer First Name: " + CustomerFirstName +
                "\n\tCustomer Last Name: " + CustomerLastName +
                "\n\tInterest Rate: " + InterestRate.ToString("p2") +
                "\n\tLoan Amount: " + LoanAmount.ToString("C") +
                "\n\tNumber of Years in the loan's term: " + NumOfYearsLoanTerm+
                "\n\tInterest: "+CalculateInterest().ToString("C");
        }

        //Required Calculate Interest Rate Method
        public abstract decimal CalculateInterest();
    }
}
