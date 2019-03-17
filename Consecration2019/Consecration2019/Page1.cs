using Xamarin;
using Xamarin.Forms;

namespace Consecration2019
{
    public class Page1 : ContentPage
    {
        public Page1()
        {
            Button myButton1 = new Button();
            myButton1.Clicked += this.MyButton1_Clicked;
            myButton1.HorizontalOptions = LayoutOptions.CenterAndExpand;
            myButton1.VerticalOptions = LayoutOptions.CenterAndExpand;
            myButton1.Text = "Go Back To Main";

            this.Content = new StackLayout
            {
                Children = 
                {
                    new Label { Text = "test label 1"  }, 
                    new Label { Text = "test label 2!" },
                    myButton1
                    
                }
            };
        }

        private void MyButton1_Clicked(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
            //Application.Current.MainPage = new MainPage();

            Application.Current.MainPage = new MainPage();

            //this.Navigation.PushModalAsync(new MainPage());


        }
    }
}




