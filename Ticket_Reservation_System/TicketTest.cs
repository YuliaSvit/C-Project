using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;

namespace Ticket_Reservation_System
{
    [TestClass]
    public class TicketTest
    {
        [TestMethod]
        public void TestPlay()
        {
            DateTime dt = new DateTime(2021, 1, 1);
            Play myPlay = new Play(2, 3, 33, "front row", 101,dt,"Play","Chicago", "basketball");
            Console.WriteLine(myPlay);
        }
        [TestMethod]
        public void TestMusical()
        {
            DateTime dt = new DateTime(2021, 1, 1);
            Musical myMusical = new Musical(1, 4, 55, "orchestra", "guitar", 55, dt, "Musical", "Chicago");
            Console.WriteLine(myMusical);
        }
        [TestMethod]
        public void TestLecture()
        {
            DateTime dt = new DateTime(2020, 1, 1);
            Lecture myLecture = new Lecture(9, 5, 23, "balcony", 20, dt, "Lecture", "Chicago", "Robins");
            Console.WriteLine(myLecture);
        }
        
    }
}
