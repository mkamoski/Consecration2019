using System;
//using Android;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Consecration2019;
using Consecration2019.Droid;
using Xamarin;
using Xamarin.Forms;
using Xamarin.Forms.Platform;
//using Xamarin.Forms.Platform.Android;

namespace Consecration2019.Droid
{
    [Activity(Label = "Consecration2019", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            //As of 2019-02-24, after the rename and update of the nuget for xamarin forms, these lines stopped compiling, but maybe they are not necessary.
            //
            //TabLayoutResource = Resource.Layout.Tabbar;
            //ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
    }
}