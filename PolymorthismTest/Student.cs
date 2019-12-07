using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorthismTest
{
    //Person is a base class, Student is a derived class. So student enherites all the properties from the 
    //..from the Person class, plus will have some additional specific properties
    class Student:Person,ITraveler
    {
        private string major;
        private string studentId;

        //Constructor (will enherites from the Person constructor as well
        public Student(string id, string fN, string lN, int age,DateTime dob, string maj, string studId)
            :base(id, fN, lN, age, dob)
        {
            major = maj;
            studentId = studId;
        }

        /*public override string GetExerciseHabits()
        {
            return "message";
        }
        */

        public void GetDOB()
        {
            Console.WriteLine(base.dateOfBirth);
        }

        public override string HoursOfSleep()
        {
            return "A student gets 6 hours of sleep";
        }

        //methods to implement ITraveler interface
        public string GetDestination()
        {
            return "Home";
        }
        public string GetStartLocation()
        {
            return "School";
        }
        public double DetermineMiles()
        {
            return 75.0;
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
