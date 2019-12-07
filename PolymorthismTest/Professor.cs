using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorthismTest
{
    class Professor:Person,ITraveler
    {
        private string empId;
        private string subject;

        //Constructor (will enherites from the Person constructor as well
        public Professor(string id, string fN, string lN, int age, DateTime dob, string eID, string sub)
            : base(id, fN, lN, age, dob)
        {
            EmployeeID = eID;
            SubjectArea = sub;
        }
        //Properties
        public string EmployeeID
        {
            get
            {
                return empId;
            }
            set
            {
                empId = value;
            }
        }
        public string SubjectArea
        {
            get
            {
                return subject;
            }
            set
            {
                subject = value;
            }
        }
        //methods to implement ITraveler interface
        public string GetDestination()
        {
            return "The Beach";
        }
        public string GetStartLocation()
        {
            return "Home";
        }
        public double DetermineMiles()
        {
            return 200.0;
        }
        //override ToString Method from the Base class
        public override string ToString()
        {
            return base.ToString() +
                "\n Destination: " + GetDestination() +
                "\n Start Location: " + GetStartLocation() +
                "\n Miles: " + DetermineMiles();

        }


    }
}
