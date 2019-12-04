using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;

namespace PolymorthismTest
{
    [TestClass]
    public class InheritanceTest
    {
        [TestMethod]
        public void Check_Person_Student_Relationship()
        {
            DateTime dob = new DateTime(1980, 5, 20);
            Person myPerson = new Person("1234", "Baker", "Anna", 24,dob);

            /*if Person class (or any class) is abstract , then you can not initiate the objects 
            from the class, but you can strill do it for the derived class that inherites from 
            the abstract class*/

           Student myStrudent = new Student("1", "Svit", "Yulia",32,dob, "Computer Science", "7");

            //call the mothod and assign the output to the string variable 
           // string response = myStrudent.GetExerciseHabits();
        }
        [TestMethod]
        public void Composition_Test()
        {
            DateTime dob = new DateTime(1980, 5, 20);
            Student myStudent = new Student("1", "Svit", "Yulia", 32,dob, "Computer Science", "7");

        }
        [TestMethod]
        public void Test_Student_As_Person()
        {
            ArrayList PersonList = new ArrayList();
            DateTime dob = new DateTime(1980, 5, 20);
            Person myPerson = new Person("1234", "Baker", "Anna", 24, dob);
            Student myStudent = new Student("1", "Svit", "Yulia", 32, dob, "Computer Science", "7");

            //we can add both of these objects to the list and loop through it.
            PersonList.Add(myPerson);
            PersonList.Add(myStudent);

            foreach(Person item in PersonList)
            {
                Console.WriteLine(item.HoursOfSleep());
            }
        }


    }
}