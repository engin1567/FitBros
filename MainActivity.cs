using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace FitBros2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            // variables

            var btnStartAWorkout = FindViewById<Button>(Resource.Id.button_startAWorkout);
            var btnCalculateYourBMI = FindViewById<Button>(Resource.Id.button_calculateYourBMI);
            var btnApplicationSettings = FindViewById<Button>(Resource.Id.button_settings);
            var btnQuitTheApplication = FindViewById<Button>(Resource.Id.button_quitTheApplication);

            // button clicks

            btnStartAWorkout.Click += (s, e) =>
            {
                Intent nextActivity = new Intent(this, typeof(WorkoutsActivity));
                StartActivity(nextActivity);
            };

            btnCalculateYourBMI.Click += (s, e) =>
            {
                Intent nextActivity = new Intent(this, typeof(BmiActivity));
                StartActivity(nextActivity);
            };

            btnApplicationSettings.Click += (s, e) =>
            {
                Intent nextActivity = new Intent(this, typeof(SettingsActivity));
                StartActivity(nextActivity);
            };

            btnQuitTheApplication.Click += (s, e) =>
            {
                FinishAffinity();
            };
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}