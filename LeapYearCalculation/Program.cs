using System;

namespace LeapYearCalculation
{
    public class Program
    {
        static void Main(string[] args)
        {
            EnterYear(2000);
        }

        public static string EnterYear(int enteredYear)
        {
            //Console.WriteLine("Please enter a year");
            //int enteredYear = Convert.ToInt32(Console.ReadLine());
            
            //Default value
            string leapYear="No";

            //Dispaly message with the entered year
            Console.WriteLine($"Year entered: {enteredYear}");

            //Determine if year is valid
            if ((enteredYear <= 0) || (enteredYear % 1 != 0))
            {
                leapYear = "Please enter a valid year";
            }
            else
            {
                //Display a message if given year is divisible by 4
                var div4 = enteredYear % 4 == 0 ? "Yes" : "No";
                Console.WriteLine($"Divisible by 4:{div4}");

                //Display a message if given year is divisible by 100
                var div100 = enteredYear % 100 == 0 ? "Yes" : "No";
                Console.WriteLine($"Divisible by 100:{div100}");

                //Display a message if given year is divisible by 400
                var div400 = enteredYear % 400 == 0 ? "Yes" : "No";
                Console.WriteLine($"Divisible by 400:{div400}");

                //Display a message if given year is a Leap Year or Not
                if ((enteredYear%4==0))
                {
                    if (enteredYear % 100 == 0)
                    {
                        if (enteredYear % 400 == 0)
                        {
                            leapYear = "Yes";
                        }
                        else
                        {
                            leapYear = "No";
                        }
                    }
                    else
                    {
                        leapYear = "Yes";
                    }
                }
                else
                {
                    leapYear = "No";
                }
                Console.WriteLine($"Leap Year:{leapYear}");
            }

            //Console.ReadLine();
            return leapYear;


        }

    }
}

