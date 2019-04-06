using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin;
using Xamarin.Forms;

namespace Consecration2019.Presentation.Helpers
{
    public class Utility
    {
        #region Constructors

        public Utility()
        {
            //Continue.
        }

        #endregion Constructors

        #region Methods

        public void DoSomething()
        {
           //Continue.
        }

        public Label GetHeaderLabel(string targetText)
        {
            Label myHeaderLabel = null;

            if (string.IsNullOrWhiteSpace(targetText))
            {
                throw new System.InvalidOperationException("Error as (string.IsNullOrWhiteSpace(targetText)) here.");
            }

            targetText = (targetText + string.Empty).Trim();
            myHeaderLabel = new Label();
            myHeaderLabel.Text = targetText;
            myHeaderLabel.HorizontalOptions = LayoutOptions.Center;
            myHeaderLabel.VerticalOptions = LayoutOptions.CenterAndExpand;
            return myHeaderLabel;
        }

        #endregion Methods
    }
}
