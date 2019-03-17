using System;
using Xamarin.Forms;

namespace Consecration2019
{
    public partial class MainPage : ContentPage
    {
        #region Constructors

        public MainPage()
        {
            this.InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void PickStartDay_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new StartPickerPage();
        }

        #endregion Methods
    }
}
