using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsEg
{
    class State
    {
        public static string state;
        public static void CheckStateOk(string st)
        {
            switch (st.ToUpper())
            {
                case "FL":
                case "GA":
                case "NC":
                    state = st.ToUpper();
                    break;
                default:
                    Exception ex = new Exception("State Not Park" + " of Atlantic ICW");
                    throw ex;
            }
        }
    }
}
