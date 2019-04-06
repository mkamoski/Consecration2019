using System.Collections.Generic;
using Xamarin.Forms;

namespace Consecration2019
{
    public class StartPickerPage : ContentPage
    {
        #region Fields

        private Common.Helpers.Converter converterField = null;

        #endregion Fields

        #region Constructors

        public StartPickerPage()
        {
            StackLayout myStackLayout = new StackLayout();

            //Create the header.
            Label myHeaderLabel = new Label();
            myHeaderLabel.Text = "Pick your start day.";
            myHeaderLabel.HorizontalOptions = LayoutOptions.Center;
            myHeaderLabel.VerticalOptions = LayoutOptions.CenterAndExpand;
            myStackLayout.Children.Add(myHeaderLabel);

            //Create the home button.
            Button myHomeButton = new Button();
            myHomeButton.Text = "Go to the main page.";
            myHomeButton.Clicked += this.HomeButton_Clicked;
            myHomeButton.HorizontalOptions = LayoutOptions.CenterAndExpand;
            myHomeButton.VerticalOptions = LayoutOptions.CenterAndExpand;
            myStackLayout.Children.Add(myHomeButton);

            //Create a list of start days.
            List<string> myStartDayList = new List<string>();

            //TODO. Build the whole calendar for the year, or use a calendar control.
            //
            //Fill the list of start days.
            myStartDayList.Add("Jan 09");
            myStartDayList.Add("Feb 20");
            myStartDayList.Add("Jun 13");
            myStartDayList.Add("Jul 13");
            myStartDayList.Add("Aug 06");
            myStartDayList.Add("Aug 13");
            myStartDayList.Add("Oct 19");
            myStartDayList.Add("Nov 05");
            myStartDayList.Add("Nov 09");

            //Add the buttons for the start days.
            foreach (string myStartDay in myStartDayList)
            {
                Button myDayButton = new Button();
                myDayButton.Text = myStartDay;
                myDayButton.Clicked += this.DayButton_Clicked;
                myDayButton.HorizontalOptions = LayoutOptions.CenterAndExpand;
                myDayButton.VerticalOptions = LayoutOptions.CenterAndExpand;
                myStackLayout.Children.Add(myDayButton);
            }

            //Old.
            //this.Content = myStackLayout;

            //Create a ScrollView.
            ScrollView myScrollView = new ScrollView();

            //Add the StackLayout to the ScrollView.
            myScrollView.Content = myStackLayout;

            //Set the page Content to the ScrollView.
            this.Content = myScrollView;
        }

        #endregion Constructors

        #region Properties

        public Common.Helpers.Converter ConverterObject
        {
            get
            {
                if (this.converterField == null)
                {
                    this.converterField = new Common.Helpers.Converter();
                }

                return this.converterField;
            }
        }

        #endregion Properties

        #region Methods

        private void DayButton_Clicked(object sender, System.EventArgs e)
        {
            Button myButton = (Button)sender;
            string myButtonText = myButton.Text;
            string[] myButtonTextParts = myButtonText.Split(" ".ToCharArray());
            string myMonthAbbreviation = (myButtonTextParts[0] + string.Empty).Trim();
            int myMonthNumber = this.ConverterObject.ConvertToMonthByForce(myMonthAbbreviation);
            string myDayText = (myButtonTextParts[1] + string.Empty).Trim();
            int myDayNumber = int.MinValue;

            if (!(int.TryParse(myDayText, out myDayNumber)))
            {
                myDayNumber = Common.Helpers.Constants.DefaultDay;
            }

            if (myDayNumber < Common.Helpers.Constants.DefaultDayMin || myDayNumber > Common.Helpers.Constants.DefaultDayMax)
            {
                myDayNumber = Common.Helpers.Constants.DefaultDay;
            }

            Application.Current.MainPage = new DayMappingPage(targetMonth: myMonthNumber, targetDay: myDayNumber);
        }

        private void HomeButton_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        #endregion Methods
    }
}
