using Android.App;
using Android.Content.PM;
using Android.Gms.Cast.Framework;
using Android.OS;

namespace GPSDontWorkforCasting
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState); 
            // Initialize CastContext
            var castcontext = CastContext.GetSharedInstance(this.ApplicationContext); }
        }
}
