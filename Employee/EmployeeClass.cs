using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class EmployeeClass
    {
        //////////private variables////////
        //We need them only if we perform validations during creating properties. Since we have auto-implemented properties, then variables below not needed.
        /*int employeeNumber;
        string firstName;
        string lastName;
        DateTime dateOfHire;
        string jobDescription;
        string department;
        decimal monthlySalary;*/

        ///////////Constructors//////////
        //Constructor with FN and LN only
        public EmployeeClass(string firstNameC, string lastNameC)
        {
            FirstName = firstNameC;
            LastName = lastNameC;
        }
        //Constructor with all the  required information regarding of the employee )
        public EmployeeClass(int employeeNumberC, string firstNameC, string lastNameC, DateTime dateOfHireC, string jobDescriptionC, string departmentC, decimal monthlySalaryC)
        {
            EmployeeNumber = employeeNumberC;
            FirstName = firstNameC;
            LastName = lastNameC;
            DateOfHire = dateOfHireC;
            JobDescription = jobDescriptionC;
            Department = departmentC;
            MonthlySalary = monthlySalaryC;
        }

        //Empty Constructor
        public EmployeeClass(int employeeNumberC)
        {
            EmployeeNumber = employeeNumberC;
        }

        //Constructor with name , id and title
        public EmployeeClass(int employeeNumberC, string nameC, string jobTitleC) 
        {
            EmployeeNumber = employeeNumberC;
            Name = nameC;
            JobTitle = jobTitleC;
        }
        ////////////Properties: get set acessors////////////
        public int EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfHire { get; set; }
        public string JobDescription { get; set; }
        public string Department { get; set; }
        public decimal MonthlySalary { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }


        //////////methods///////////
        //Method that returns employee in a format of FN LN
        public string ReturnEmployee()
        {
            return $"{ FirstName} { LastName}";
        }
        
        //Method that returns employee in a format of LN, FN (for sorting in the future)
        public string ReturnEmployeeSorted()
        {
            return $"{ LastName}, {FirstName}";
        }
        
        //Method that identifies locarion based on the job titele
        public string JobLocation()
        {
            if (JobTitle=="Manager")
            {
                return "Boston";
            }
            else if (JobTitle=="Staff")
            {
                return "Chicago";
            }
            else
            {
                return "New York";
            }
        }

        //This method automatically will be called, and this string will be returned.
        public override string ToString()
        {
            return EmployeeNumber + " "+ Name + ", Job Title:" + JobTitle;
        }

    }
}
