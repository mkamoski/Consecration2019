
using Xamarin.Forms;

namespace Consecration2019
{
    public class View2 : ContentView
    {
        public View2()
        {
            this.Content = new StackLayout
            {
                Children = 
                {
                    new Label { Text = "Welcome to Xamarin.Forms! This is View1." 
                    }
                }
            };
        }
    }
}