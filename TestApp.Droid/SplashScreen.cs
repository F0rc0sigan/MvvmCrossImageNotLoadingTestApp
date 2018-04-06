
using Android.App;
using Android.Content.PM;
using MvvmCross.Platforms.Android.Views;

namespace TestApp.Droid
{
    [Activity(
          MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/AppTheme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait
        , ConfigurationChanges = ConfigChanges.Locale)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }

        protected override void TriggerFirstNavigate()
        {
            StartActivity(typeof(MainActivity));
            base.TriggerFirstNavigate();
        }
    }
}