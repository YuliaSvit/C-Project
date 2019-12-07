using System;
using System.Collections.Generic;
using System.Text;

namespace BMI
{
    class CustomException: Exception
    {
        public CustomException(string message):base(message)
        {

        }
    }
}
