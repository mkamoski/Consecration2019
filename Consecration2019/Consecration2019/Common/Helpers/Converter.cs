using System;

namespace Consecration2019.Common.Helpers
{
    public class Converter
    {
        #region Constructors

        public Converter()
        {
            //Continue.
        }

        #endregion Constructors

        #region Methods

        public int ConvertToMonthByForce(int targetMonthNumber)
        {
            int myMonthNumber = targetMonthNumber;

            if (myMonthNumber < Common.Helpers.Constants.DefaultMonthMin)
            {
                myMonthNumber = Common.Helpers.Constants.DefaultMonthMin;
            }
            else if (myMonthNumber > Common.Helpers.Constants.DefaultMonthMax)
            {
                myMonthNumber = Common.Helpers.Constants.DefaultMonthMax;
            }
            else
            {
                //Continue.
            }

            return myMonthNumber;
        }

        public int ConvertToMonthByForce(string targetMonthName)
        {
            int myMonthNumber = Common.Helpers.Constants.DefaultMonth;
            string myMonth = (targetMonthName + string.Empty).Trim().ToLowerInvariant();

            if (myMonth.StartsWith("jan", System.StringComparison.InvariantCultureIgnoreCase))
            {
                myMonthNumber = 1;
            }
            else if (myMonth.StartsWith("feb", System.StringComparison.InvariantCultureIgnoreCase))
            {
                myMonthNumber = 2;
            }
            else if (myMonth.StartsWith("mar", System.StringComparison.InvariantCultureIgnoreCase))
            {
                myMonthNumber = 3;
            }
            else if (myMonth.StartsWith("apr", System.StringComparison.InvariantCultureIgnoreCase))
            {
                myMonthNumber = 4;
            }
            else if (myMonth.StartsWith("may", System.StringComparison.InvariantCultureIgnoreCase))
            {
                myMonthNumber = 5;
            }
            else if (myMonth.StartsWith("jun", System.StringComparison.InvariantCultureIgnoreCase))
            {
                myMonthNumber = 6;
            }
            else if (myMonth.StartsWith("jul", System.StringComparison.InvariantCultureIgnoreCase))
            {
                myMonthNumber = 7;
            }
            else if (myMonth.StartsWith("aug", System.StringComparison.InvariantCultureIgnoreCase))
            {
                myMonthNumber = 8;
            }
            else if (myMonth.StartsWith("sep", System.StringComparison.InvariantCultureIgnoreCase))
            {
                myMonthNumber = 9;
            }
            else if (myMonth.StartsWith("oct", System.StringComparison.InvariantCultureIgnoreCase))
            {
                myMonthNumber = 10;
            }
            else if (myMonth.StartsWith("nov", System.StringComparison.InvariantCultureIgnoreCase))
            {
                myMonthNumber = 11;
            }
            else if (myMonth.StartsWith("dec", System.StringComparison.InvariantCultureIgnoreCase))
            {
                myMonthNumber = 12;
            }
            else
            {
                myMonthNumber = Common.Helpers.Constants.DefaultMonth;
            }

            return myMonthNumber;
        }

        #endregion Methods
    }
}
