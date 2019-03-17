namespace Consecration2019.Common.Helpers
{
    public class Validator
    {
        #region Constructors

        public Validator()
        {
            //Continue.
        }

        #endregion Constructors

        #region Methods

        public bool IsValidMonth(string targetMonthNumber)
        {
            bool myIsValidFlag = false;
            targetMonthNumber = (targetMonthNumber + string.Empty).Trim();
            int myMonthNumberCandidate = int.MinValue;

            if (!(int.TryParse(targetMonthNumber, out myMonthNumberCandidate)))
            {
                myIsValidFlag = false;
            }
            else if (myMonthNumberCandidate < 1 || myMonthNumberCandidate > 12)
            {
                myIsValidFlag = false;
            }
            else
            {
                myIsValidFlag = true;
            }

            return myIsValidFlag;
        }

        #endregion Methods
    }
}
