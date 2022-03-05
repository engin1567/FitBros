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
    [Activity(Label = "WorkoutActivity", Theme = "@style/AppTheme", NoHistory = true)]
    public class WorkoutsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_workouts);

            // variables

            var btnSevenMinuteWorkout = FindViewById<Button>(Resource.Id.button_sevenMinuteWorkout);
            var btnBack = FindViewById<Button>(Resource.Id.button_backFromWorkouts);

            // button clicks

            btnSevenMinuteWorkout.Click += (s, e) =>
            {
                // show info of the workout

                Android.App.AlertDialog.Builder dialog = new AlertDialog.Builder(this);

                AlertDialog alert = dialog.Create();
                alert.SetTitle("7 minute workout");
                alert.SetMessage(String.Format("A total of 12 exercises which are done for 30 seconds each."));

                // start the workout

                alert.SetButton("Start", (c, ev) =>
                {
                    Intent nextActivity = new Intent(this, typeof(WorkoutActivity));
                    nextActivity.PutExtra("workoutName", "sevenminuteworkout");

                    StartActivity(nextActivity);
                });

                // show exercise list

                alert.SetButton2("Exercises", (c, ev) =>
                {
                    Intent nextActivity = new Intent(this, typeof(ExercisesActivity));
                    nextActivity.PutExtra("workoutName", "sevenminuteworkout");

                    StartActivity(nextActivity);
                });

                // go back

                alert.SetButton3("Back", (c, ev) =>
                {
                    // do nothing (go back)
                });

                alert.Show();
            };

            btnBack.Click += (s, e) =>
            {
                Finish();
            };
        }
    }
}