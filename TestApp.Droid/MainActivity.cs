using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MvvmCross.Forms.Platforms.Android.Views;

namespace TestApp.Droid
{
    [Activity(Label = "Test App", 
        Icon = "@drawable/icon", 
        Theme = "@style/AppTheme", 
        NoHistory = false,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
        LaunchMode = LaunchMode.SingleTask)]
    public class MainActivity : MvxFormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
        }

        public override void OnBackPressed()
        {
            base.OnBackPressed();
        }
    }
}

