using System;
using System.Collections.Generic;
using System.Text;

namespace Receipt
{
    public class Receipt
    {
        private int receiptNumber;
        //private DateTime dateOfPurchase;
        private int customerNumber;
        //private string customerName;
        //private string customerAddress;
        //private string customerPhoneNumber;
        private int itemNumber;
        //private string itemDescription;
        private decimal itemCost;
        private int itemQtyPurchased;

        public  Receipt(int recN, DateTime datePurch, int custN,
             string custName, string custAddress, string custPhoneN, int itemN,
             string itemDes, decimal itemCost, int itemQtyPurch)
        {
            ReceiptNumber = recN;
            DateOfPurchase = datePurch;
            CustomerNumber = custN;
            CustomerName = custName;
            CustomerAddress = custAddress;
            CustomerPhoneNumber = custPhoneN;
            ItemNumber = itemN;
            ItemDescription = itemDes;
            ItemCost = itemCost;
            ItemQtyPurchased = itemQtyPurch;

        }


        //Properties
        public int ReceiptNumber
        {
            get { return receiptNumber; }
            set
            {
                if (value >0)
                {
                    receiptNumber = value;
                }
                else
                {
                    Console.WriteLine("Please enter valid Receipt Number");
                }
            }
                
        }


        public DateTime DateOfPurchase { get; set; }
        public int CustomerNumber
        {
            get { return customerNumber; }
            set
            {
                if (value > 0)
                {
                    customerNumber=value;
                }
                else
                {
                    Console.WriteLine("Please enter correct Customer Number");
                }
            }
        }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public int ItemNumber
        {
            get { return itemNumber; }
            set
            {
                if ((value>0)&&(value<9999))
                {
                    itemNumber=value;
                }
                else
                {
                    Console.WriteLine("Please enter correct Item Number");
                }
            }
        }
        public string ItemDescription { get; set; }
        public decimal ItemCost
        {
            get { return itemCost; }
            set
            {
                if ((value>0)&&(value<9999))
                {
                    itemCost = value;
                }
                else
                {
                    Console.WriteLine("Please enter correct Item Cost");
                }
            }
        }
        public int ItemQtyPurchased
        {
            get { return itemQtyPurchased; }
            set
            {
                if (value>0)
                {
                    itemQtyPurchased = value;
                }
                else
                {
                    Console.WriteLine("Please enter correct item qty");
                }
            }
        }

        //Methods
        //Calculate Total Cost
        public decimal CalcTotalCost()
        {
            return ItemCost * ItemQtyPurchased;
        }

        //Override ToString method
        public override string ToString()
        {
            return
                "Customer: " + CustomerName +
                "\nPhone:" + CustomerPhoneNumber.ToString() +
                "\nTotal Purchases:" + CalcTotalCost().ToString("c");
        }
    }
}
