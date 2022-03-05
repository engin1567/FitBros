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
using System.Timers;

namespace FitBros2
{
    [Activity(Label = "WorkoutActivity", Theme = "@style/AppTheme", NoHistory = true)]
    public class WorkoutActivity : Activity
    {
        // global variables
        private System.Timers.Timer timer;

        private int hour = 0, min = 0, sec = 0;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_workout);

            // variables
            string workoutName = Intent.GetStringExtra("workoutName");

            var txtWorkout = FindViewById<TextView>(Resource.Id.textView_workout);
            var txtTimer = FindViewById<TextView>(Resource.Id.textView_timer);
            var txtCurrentExercise = FindViewById<TextView>(Resource.Id.textView_currentExercise);
            var btnNextExercise = FindViewById<Button>(Resource.Id.button_nextExercise);
            var btnPreviousExercise = FindViewById<Button>(Resource.Id.button_previousExercise);
            var btnQuitWorkout = FindViewById<Button>(Resource.Id.button_quitWorkout);

            int currentExercise = 0;
            int exerciseAmount = 0;

            // correct workout name and exercises

            List<string> exercises = new List<string>();

            if (workoutName == "sevenminuteworkout")
            {
                // workout name
                txtWorkout.Text = "7 minute workout";

                // exercises
                exercises.Add("Jumping jack");
                exercises.Add("Wall sit");
                exercises.Add("Push-up");
                exercises.Add("Abdominal crunch");
                exercises.Add("Step-up");
                exercises.Add("Squat");
                exercises.Add("Triceps dip");
                exercises.Add("Plank");
                exercises.Add("High knees");
                exercises.Add("Lunge");
                exercises.Add("Push-up and rotation");
                exercises.Add("Side plank");

                exerciseAmount = 12;

                txtCurrentExercise.Text = "Current exercise: Jumping jack";
            }

            // timer

            timer = new System.Timers.Timer
            {
                Interval = 1000 // 1 second
            };
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            // button clicks

            btnNextExercise.Click += (s, e) =>
            {
                if (btnNextExercise.Text == "Finish workout")
                {
                    Android.App.AlertDialog.Builder dialog = new AlertDialog.Builder(this);

                    AlertDialog alert = dialog.Create();
                    alert.SetTitle("Congratulations");
                    alert.SetMessage("Your workout is finished. Great job!");
                    alert.SetButton("OK", (c, ev) =>
                    {
                        // finish the workout, switch to workouts menu
                        timer.Stop();
                        Finish();

                        Intent nextActivity = new Intent(this, typeof(WorkoutsActivity));
                        StartActivity(nextActivity);
                    });

                    alert.Show();
                }
                else
                {
                    ChooseNextExercise(exercises, currentExercise, exerciseAmount);
                }
            };

            btnPreviousExercise.Click += (s, e) =>
            {
                ChoosePreviousExercise(exercises, currentExercise, exerciseAmount);
            };

            btnQuitWorkout.Click += (s, e) =>
                {
                    Android.App.AlertDialog.Builder dialog = new AlertDialog.Builder(this);

                    AlertDialog alert = dialog.Create();
                    alert.SetTitle("Confirm");
                    alert.SetMessage("Are you sure that you want to quit your workout?");
                    alert.SetButton("NO", (c, ev) =>
                    {
                        // do nothing
                    });

                    alert.SetButton2("YES", (c, ev) =>
                    {
                        // stop the workout, switch to workouts menu
                        timer.Stop();
                        Finish();

                        Intent nextActivity = new Intent(this, typeof(WorkoutsActivity));
                        StartActivity(nextActivity);
                    });

                    alert.Show();
                };
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var txtTimer = FindViewById<TextView>(Resource.Id.textView_timer);

            sec++;

            if (sec == 60)
            {
                min++;
                sec = 0;
            }
            if (min == 60)
            {
                hour++;
                min = 0;
            }

            RunOnUiThread(() => { txtTimer.Text = $"Workout time: {hour}:{min}:{sec}"; });
        }

        private void ChooseNextExercise(List<String> exercises, int currentExercise, int exerciseAmount)
        {
            // variables

            var txtCurrentExercise = FindViewById<TextView>(Resource.Id.textView_currentExercise);
            var btnNextExercise = FindViewById<Button>(Resource.Id.button_nextExercise);

            for (int i = 0; i < exerciseAmount; i++)
            {
                if (txtCurrentExercise.Text.Equals("Current exercise: " + exercises[i]) && currentExercise < exerciseAmount)
                {
                    // for last exercise
                    if (i == exercises.Count - 1)
                    {
                        btnNextExercise.Text = "Finish workout";
                        return;
                    }
                    else
                    {
                        // for all others
                        i++;
                        currentExercise++;
                        txtCurrentExercise.Text = "Current exercise: " + exercises[i];
                    }
                }
            }
        }

        private void ChoosePreviousExercise(List<String> exercises, int currentExercise, int exerciseAmount)
        {
            // variables

            var txtCurrentExercise = FindViewById<TextView>(Resource.Id.textView_currentExercise);
            var btnNextExercise = FindViewById<Button>(Resource.Id.button_nextExercise);

            for (int i = 0; i < exerciseAmount; i++)
            {
                if (txtCurrentExercise.Text.Equals("Current exercise: " + exercises[i]) && currentExercise >= 0)
                {
                    // for last exercise
                    if (i == 0)
                    {
                        // do nothing
                    }
                    else if (i == exercises.Count - 1)
                    {
                        i--;
                        currentExercise--;
                        txtCurrentExercise.Text = "Current exercise: " + exercises[i];
                        btnNextExercise.Text = "Next";
                        return;
                    }
                    else
                    {
                        // for all others
                        i--;
                        currentExercise--;
                        txtCurrentExercise.Text = "Current exercise: " + exercises[i];
                    }
                }
            }
        }
    }
}