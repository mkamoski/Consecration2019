using System;
using Xamarin.Forms;

namespace Consecration2019
{
    public class DayMappingPage : ContentPage
    {
        #region Fields

        public const char DefaultDayButtonSeparatorChar = ':';
        public const string DefaultDayButtonPrefix = "DAY-";
        private Common.Helpers.Converter converterField = null;

        #endregion Fields

        #region Constructors

        public DayMappingPage()
        {
            this.BuildLayout(Common.Helpers.Constants.DefaultMonth, Common.Helpers.Constants.DefaultDay);
        }

        public DayMappingPage(int targetMonth, int targetDay)
        {
            this.BuildLayout(targetMonth, targetDay);
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

        public void BuildLayout(int targetMonth, int targetDay)
        {
            if (targetDay < Common.Helpers.Constants.DefaultDayMin)
            {
                targetDay = Common.Helpers.Constants.DefaultDayMin;
            }

            if (targetDay > Common.Helpers.Constants.DefaultDayMax)
            {
                targetDay = Common.Helpers.Constants.DefaultDayMin;
            }

            StackLayout myStackLayout = new StackLayout();

            Label myHeaderLabel = new Label();
            myHeaderLabel.Text = "Click today's date below.";
            myHeaderLabel.HorizontalOptions = LayoutOptions.Center;
            myHeaderLabel.VerticalOptions = LayoutOptions.CenterAndExpand;
            myStackLayout.Children.Add(myHeaderLabel);

            Button myHomeButton = new Button();
            myHomeButton.Text = "Click here to return to the main page.";
            myHomeButton.Clicked += this.HomeButton_Clicked;
            myHomeButton.HorizontalOptions = LayoutOptions.CenterAndExpand;
            myHomeButton.VerticalOptions = LayoutOptions.CenterAndExpand;
            myStackLayout.Children.Add(myHomeButton);

            //The 34-day-period will always span 2 months, which we call the First Month and the Second Month.
            DateTime myDateTimeNow = DateTime.Now;
            string myDate = string.Empty;
            int myDaysInFirstMonth = DateTime.DaysInMonth(year: myDateTimeNow.Year, month: targetMonth);

            DateTime myFirstMonthStartDate = new DateTime(year: myDateTimeNow.Year, month: targetMonth, day: targetDay);
            int myDayNumber = 1;
            int myFirstMonthDay = int.MinValue;

            for (myFirstMonthDay = targetDay; myFirstMonthDay <= myDaysInFirstMonth; myFirstMonthDay++)
            {
                //Set the button text.
                Button myGoToDayButton = new Button();
                myGoToDayButton.Text = string.Empty;
                myGoToDayButton.Text = myGoToDayButton.Text + DayMappingPage.DefaultDayButtonPrefix + myDayNumber.ToString().PadLeft(totalWidth: 2, paddingChar: '0');
                myGoToDayButton.Text = myGoToDayButton.Text + " " + DayMappingPage.DefaultDayButtonSeparatorChar + " ";
                myGoToDayButton.Text = myGoToDayButton.Text + myFirstMonthStartDate.ToString("MMM") + "-" + myFirstMonthDay.ToString().PadLeft(totalWidth: 2, paddingChar: '0');

                //Set the button properties.
                myGoToDayButton.Clicked += this.GoToDayButton_Clicked;
                myGoToDayButton.HorizontalOptions = LayoutOptions.CenterAndExpand;
                myGoToDayButton.VerticalOptions = LayoutOptions.CenterAndExpand;
                myStackLayout.Children.Add(myGoToDayButton);
                myDayNumber = myDayNumber + 1;
            }

            DateTime mySecondMonth = myFirstMonthStartDate.AddMonths(1);
            int mySecondMonthDayCounter = 1;

            for (int mySecondLoopCounter = myDayNumber; mySecondLoopCounter <= 34; mySecondLoopCounter++)
            {
                //Set the button text.
                Button myGoToDayButton2 = new Button();
                myGoToDayButton2.Text = string.Empty;
                myGoToDayButton2.Text = myGoToDayButton2.Text + DayMappingPage.DefaultDayButtonPrefix + myDayNumber.ToString().PadLeft(totalWidth: 2, paddingChar: '0');
                myGoToDayButton2.Text = myGoToDayButton2.Text + " " + DayMappingPage.DefaultDayButtonSeparatorChar + " ";
                myGoToDayButton2.Text = myGoToDayButton2.Text + mySecondMonth.ToString("MMM") + "-" + mySecondMonthDayCounter.ToString().PadLeft(totalWidth: 2, paddingChar: '0');

                //Set the button properties.
                myGoToDayButton2.Clicked += this.GoToDayButton_Clicked;
                myGoToDayButton2.HorizontalOptions = LayoutOptions.CenterAndExpand;
                myGoToDayButton2.VerticalOptions = LayoutOptions.CenterAndExpand;
                myStackLayout.Children.Add(myGoToDayButton2);
                myDayNumber = myDayNumber + 1;
                mySecondMonthDayCounter = mySecondMonthDayCounter + 1;
            }

            //Create a ScrollView.
            ScrollView myScrollView = new ScrollView();

            //Add the StackLayout to the ScrollView.
            myScrollView.Content = myStackLayout;

            //Set the page Content to the ScrollView.
            this.Content = myScrollView;
        }

        private void GoToDayButton_Clicked(object sender, System.EventArgs e)
        {
            //TODO. Figure out the day to navigate to here.
            //
            //this.DisplayAlert("test", DateTime.Now.ToString("o"), "Ok");

            Button myButton = (Button)sender;
            string myButtonText = myButton.Text;
            string[] myButtonTextParts = myButtonText.Split(" ".ToCharArray());
            string myMonthAbbreviation = (myButtonTextParts[0] + string.Empty).Trim();
            int myMonthNumber = this.ConverterObject.ConvertToMonthByForce(myMonthAbbreviation);

            string myDay = (myButtonTextParts[1] + string.Empty).Trim();
            int myDayNumber = int.MinValue;

            if (!(int.TryParse(myDay, out myDayNumber)))
            {
                myDayNumber = Common.Helpers.Constants.DefaultDay;
            }

            //this.DisplayAlert(title: "test alert", message: "Note myButtonTextParts[0]='" + myButtonTextParts[0] + "' and myButtonTextParts[1]='" + myButtonTextParts[1] + "' here.", cancel: "Close");

            Application.Current.MainPage = new DayMappingPage(targetMonth: myMonthNumber, targetDay: myDayNumber);
        }

        private void HomeButton_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        #endregion Methods
    }
}
