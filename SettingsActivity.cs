using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FitBros2
{
    [Activity(Label = "SettingsActivity", Theme = "@style/AppTheme", NoHistory = true)]
    public class SettingsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_settings);

            // variables

            var btnBack = FindViewById<Button>(Resource.Id.button_backFromSettings);

            // button clicks

            btnBack.Click += (s, e) =>
            {
                Finish();
            };
        }
    }
}