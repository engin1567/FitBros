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
    [Activity(Label = "BmiActivity", Theme = "@style/AppTheme", NoHistory = true)]
    public class BmiActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_bmi);

            // variables

            var inputWeight = FindViewById<EditText>(Resource.Id.editText_weight);
            var inputHeight = FindViewById<EditText>(Resource.Id.editText_height);

            var btnCalculateBMI = FindViewById<Button>(Resource.Id.button_calculateBMI);
            var btnIsItHealthy = FindViewById<Button>(Resource.Id.button_isItHealthy);
            var btnBasicHealthyInfo = FindViewById<Button>(Resource.Id.button_basicHealthyInfo);
            var btnBack = FindViewById<Button>(Resource.Id.button_backFromBMI);

            // button clicks

            btnCalculateBMI.Click += (s, e) =>
            {
                try
                {
                    // bmi calculation
                    var bmi = (Convert.ToDouble(inputWeight.Text) / Convert.ToDouble(inputHeight.Text) / Convert.ToDouble(inputHeight.Text) * 10000);

                    // show bmi calculation to user

                    Android.App.AlertDialog.Builder dialog = new AlertDialog.Builder(this);

                    AlertDialog alert = dialog.Create();
                    alert.SetTitle("Your result");
                    alert.SetMessage(String.Format("Weight: {0}kg\nHeight: {1}cm\n\nYour Body-Mass-Index value equals: {2:0.0}", inputWeight.Text, inputHeight.Text, bmi));
                    alert.SetButton("OK", (c, ev) =>
                    {
                        // reset the input fields
                        inputWeight.Text = null;
                        inputHeight.Text = null;
                    });

                    alert.Show();
                }
                catch
                {
                    // show error message to user

                    Android.App.AlertDialog.Builder dialog = new AlertDialog.Builder(this);

                    AlertDialog alert = dialog.Create();
                    alert.SetTitle("Check your inputs");
                    alert.SetMessage("An error occured while trying to calculate your BMI. Please check your inputs!");
                    alert.SetButton("OK", (c, ev) =>
                    {
                        // do nothing
                    });

                    alert.Show();
                }
            };

            btnIsItHealthy.Click += (s, e) =>
            {
                Android.App.AlertDialog.Builder dialog = new AlertDialog.Builder(this);
                AlertDialog alert = dialog.Create();
                alert.SetTitle("Is it healthy?");
                alert.SetMessage("BMI Categories:\n\nUnderweight: < 18.5\nNormal weight: 18.5 - 24.9\nOverweight: 25 - 29.9\nObesity: 30 or greater");
                alert.SetButton("OK", (c, ev) =>
                {
                });

                alert.Show();
            };

            btnBasicHealthyInfo.Click += (s, e) =>
            {
                Intent nextActivity = new Intent(this, typeof(BasicHealthInfoActivity));
                StartActivity(nextActivity);
            };

            btnBack.Click += (s, e) =>
            {
                Finish();
            };
        }
    }
}