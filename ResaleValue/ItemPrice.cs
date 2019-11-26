using System;
using System.Collections.Generic;
using System.Text;

namespace ResaleValue
{
    class ItemPrice
    {

        //Constructor
        public ItemPrice(decimal resItemPrice)
        {
            ResaleItemPrice = resItemPrice;
        }

        //Property
        public decimal ResaleItemPrice {get;set;}

     }
}
