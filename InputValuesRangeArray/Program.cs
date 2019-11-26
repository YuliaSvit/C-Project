using System;

namespace InputValuesRangeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializing the array where we will store number of entries for number 0 till 10. 
            int[] resultArray = new int[11];
            //initializing the variables where we will store the number of unsusessful tries. 
            /////int cntOfInvalidEntries = 0;
            int numberOutsideRange = 0;

            //Assign 0s to array
            AssignZerosToArray(resultArray);

            //Assigning the # of invalid values to the variable
            int cntOfInvalidEntries = GetValues (resultArray, ref numberOutsideRange);

            //Displaying the result
            DisplayResults(resultArray, cntOfInvalidEntries, numberOutsideRange);

            //console window remains to be open
            Console.ReadKey();
        }

        //Method that fills the array with zeros as a number of values entered
        public static void AssignZerosToArray(int[] resultArray)
        {
            for (int i = 0; i < 11; i++)
            {
                resultArray[i] = 0;
            }
        }

        //Method that implements the main logic
        public static int GetValues (int[] resultArray, ref int numberOutsideRange)
        {
            int cntOfInvalidEntries = 0;
            bool moreInput = true;
            int enteredValResult;

            //seting up the infinite loop so it can prompt a user to keep entering the values. Loop will continue until -1 is entered.
            while (moreInput == true)
            {
                Console.WriteLine("Please enter the value");
                string stringInput = Console.ReadLine();
                /*int.TryParse will eveluate if the entered value is integer.
                If value can be convereted to the int then isConvertible will be set to True
                TryParse(takes the string , and out int string result*/

                //bool isIConvertible = int.TryParse(stringInput, out enteredValResult);

                while (int.TryParse(stringInput, out enteredValResult) == false)
                {
                    Console.Write("\nInvalid data types-" + "value must be numeric between 0 and 10(-1 to stop:");
                    stringInput = Console.ReadLine();
                    cntOfInvalidEntries++;
                }

                //if -1 is entered, the infinite loop will be exited(-1 is just an exit point)
                if (enteredValResult == -1)
                {
                    moreInput = false;
                }
                else if ((enteredValResult <= 10) && (enteredValResult >= 0))
                {
                    resultArray[enteredValResult]++;
                }
                else
                {
                    Console.Write("Invalid number- must be between 0 and 10 - (-1 to stop):");
                    numberOutsideRange++;
                }
            }
                
                //we will return # of invalid values non-numeric. N# outside of the valid range will be updated via ref value
                return cntOfInvalidEntries;
            }
                
            public static void DisplayResults(int[] resultArray, int cntOfInvalidEntries, int numberOutsideRange)
            {
                int cntOfValidEntries = 0;
                Console.Clear();
                Console.WriteLine("\tInput Data App\n");
                Console.WriteLine("{0,-12}{1,-6}", "InputValue", "Count");

                //check if the value inside of the valid range was entered at all  
                for (int x = 0; x < 11; x++)
                {
                    if (resultArray[x] != 0)
                { 
                      // total # of valid entries                   
                        cntOfValidEntries += resultArray[x];
                        Console.WriteLine("{0,5}{1,10}", x, resultArray[x]);
                    }
                }
                Console.WriteLine("\nNumber of Valid Entries:{0}", cntOfValidEntries);
                Console.WriteLine("\nNumber of Non-numeric Values Entries:{0}", cntOfInvalidEntries);
                Console.WriteLine("Total Number of Inputs:{0}", (cntOfInvalidEntries + cntOfValidEntries + numberOutsideRange));

            }
        }
    }

