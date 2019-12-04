using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorthismTest
{
    class Person
    {
        private string idNumber;
        public string firstName;
        public string lastName;
        private int perAge;
        protected DateTime dateOfBirth;//this is the composition. (when class contains a memeber when it itself is a class object
        //protected - when it is availible within the class and derived classes. Private is availible only within this class. Public is availible within the project(namespace) for any classes. 

        //Constructors   
        public Person()
        {

        }

        public Person(string id, string fN,string lN, int age, DateTime dob)
        {
            idNumber = id;
            firstName = fN;
            lastName = lN;
            perAge = age;
            dateOfBirth = dob;
        }

        //Abstract method (no code in the body)(should be in abstract class)
        //if method is an abstruct , when derived class is created this method should be implemented (override) according to the devived class specifications. 
        //public abstract string GetExerciseHabits();

        public virtual string HoursOfSleep()
        {
            return "A person gets 8 hours of sleep";
        }

    }
}
