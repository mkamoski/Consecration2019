using Xamarin.Forms;

namespace Consecration2019
{
    public class DayPage02 : ContentPage
    {
        #region Constructors

        public DayPage02()
        {
            StackLayout myStackLayout = new StackLayout();

            Label myHeaderLabel = new Label();
            myHeaderLabel.Text = "Prayers For Day 02";
            myHeaderLabel.HorizontalOptions = LayoutOptions.Center;
            myHeaderLabel.VerticalOptions = LayoutOptions.CenterAndExpand;
            myStackLayout.Children.Add(myHeaderLabel);

            Button myHomeButton = new Button();
            myHomeButton.Text = "Return to main page.";
            myHomeButton.Clicked += this.HomeButton_Clicked;
            myHomeButton.HorizontalOptions = LayoutOptions.CenterAndExpand;
            myHomeButton.VerticalOptions = LayoutOptions.CenterAndExpand;
            myStackLayout.Children.Add(myHomeButton);

            const string MyDefaultText = "" +
                "Day 02: The quick brown fox jumps over the lazy dog. " +
                "The quick brown fox jumps over the lazy dog. " +
                "The quick brown fox jumps over the lazy dog. " +
                "The quick brown fox jumps over the lazy dog. " +
                "The quick brown fox jumps over the lazy dog. " +
                "The quick brown fox jumps over the lazy dog. " +
                "The quick brown fox jumps over the lazy dog. " +
                "The quick brown fox jumps over the lazy dog. " +
                "The quick brown fox jumps over the lazy dog. " +
                "";

            Label myDayTextLabel = new Label();
            myHeaderLabel.Text = MyDefaultText;
            myHeaderLabel.HorizontalOptions = LayoutOptions.Center;
            myHeaderLabel.VerticalOptions = LayoutOptions.CenterAndExpand;
            myStackLayout.Children.Add(myHeaderLabel);

            //Create a ScrollView.
            ScrollView myScrollView = new ScrollView();

            //Add the StackLayout to the ScrollView.
            myScrollView.Content = myStackLayout;

            //Set the page Content to the ScrollView.
            this.Content = myScrollView;
        }

        #endregion Constructors

        #region Methods

        private void HomeButton_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        #endregion Methods
    }
}