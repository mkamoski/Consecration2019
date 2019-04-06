using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Consecration2019
{
	public class DayPage01 : ContentPage
	{

        Consecration2019.Presentation.Helpers.Utility utilityObjectField = null;

        public Consecration2019.Presentation.Helpers.Utility UtilityObject
        {
            get
            {
                if (this.utilityObjectField == null)
                {
                    this.utilityObjectField = new Presentation.Helpers.Utility();
                }

                return this.utilityObjectField;
            }
        }

        public DayPage01 ()
		{
            //Content = new StackLayout {
            //	Children = {
            //		new Label { Text = "Welcome to Xamarin.Forms!" }
            //	}
            //};

            StackLayout myStackLayout = new StackLayout();

            //Label myHeaderLabel = new Label();
            //myHeaderLabel.Text = "Prayers For Day 01";
            //myHeaderLabel.HorizontalOptions = LayoutOptions.Center;
            //myHeaderLabel.VerticalOptions = LayoutOptions.CenterAndExpand;
            //myStackLayout.Children.Add(myHeaderLabel);

            myStackLayout.Children.Add(this.UtilityObject.GetHeaderLabel("Prayers for Day 01"));

            Button myHomeButton = new Button();
            myHomeButton.Text = "Return to main page.";
            myHomeButton.Clicked += this.HomeButton_Clicked;
            myHomeButton.HorizontalOptions = LayoutOptions.CenterAndExpand;
            myHomeButton.VerticalOptions = LayoutOptions.CenterAndExpand;
            myStackLayout.Children.Add(myHomeButton);

            Label myDayTextLabel = new Label();
            myDayTextLabel.Text = "Day 01: The quick brown fox jumped over the lazy dog.";
            myDayTextLabel.HorizontalOptions = LayoutOptions.Center;
            myDayTextLabel.VerticalOptions = LayoutOptions.CenterAndExpand;
            myStackLayout.Children.Add(myDayTextLabel);

            //Create a ScrollView.
            ScrollView myScrollView = new ScrollView();

            //Add the StackLayout to the ScrollView.
            myScrollView.Content = myStackLayout;

            //Set the page Content to the ScrollView.
            this.Content = myScrollView;

        }

        private void HomeButton_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

    }
}