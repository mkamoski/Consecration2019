
...............................................................................
Overview

This is an app for Consecration.


...............................................................................
TODO.

Add a local logging function.
Add a service-based logging function.
Add a "send log" function that will email the error log to me.

...............................................................................
Notes

            //myStartDayList.Add("test 01");
            //myStartDayList.Add("test 01");
            //myStartDayList.Add("test 01");
            //myStartDayList.Add("test 01");
            //myStartDayList.Add("test 01");
            //myStartDayList.Add("test 01");
            //myStartDayList.Add("test 10");
            //myStartDayList.Add("test 10");
            //myStartDayList.Add("test 01");
            //myStartDayList.Add("test 01");
            //myStartDayList.Add("test 01");
            //myStartDayList.Add("test 01");



            // 09 Jan , Apparition of the Immaculate Virgin Mary at Lourdes , 11 Feb 20 Feb , The Annunciation , 25 Mar 13 Jun , Our Lady of Mt.Carmel , 16 Jul 13 Jul , The Assumption , 15 Aug 06 Aug , Nativity of theBlessed Virgin Mary , 08 Sep 13 Aug , Our Lady ofSorrows , 15 Sep 19 Oct , Presentation ofthe Blessed Virgin Mary , 21 Nov 05 Nov , ImmaculateConception , 08 Dec 09 Nov , Our Lady ofGuadalupe , 12 Dec


            //<Button Text="TestButton2" HorizontalOptions="CenterAndExpand" VerticalOptions="CenterAndExpand" Clicked="TestButton2_Clicked"></Button>
            // <Label Text="Consecration 2019" HorizontalOptions="Center" VerticalOptions="CenterAndExpand" />
            //myButton1.Clicked += this.MyButton1_Clicked;


        private Common.Helpers.Converter converterField = null;

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


//This is 1 way to get data from the button clicked. Reference: get button data; get button it; get button text;
//
private void DayButton_Clicked(object sender, System.EventArgs e)
{
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


//This is 1 way to navigate to a new page. Reference: go to page; navigate to page; switch page; switch forms; navigate to page; navigate to new page; 
//
private void TestButton2_Clicked(object sender, EventArgs e)
{
    Application.Current.MainPage = new Page1();
}


//This is 1 way to show a modal popup. Reference: show alert; show popup; show modal; modal alert; modal popup; show message; modal message;
//
private void TestButton3_Clicked(object sender, EventArgs e)
{
    this.DisplayAlert(title: "test TestButton3_Clicked", message: " Build 2019-02-24-16-09 ", cancel: "Close");
}

...............................................................................
Clipboard

