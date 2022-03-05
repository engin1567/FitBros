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
    [Activity(Label = "ExercisesActivity", Theme = "@style/AppTheme", NoHistory = true)]
    public class ExercisesActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_exercises);

            // variables

            string workoutName = Intent.GetStringExtra("workoutName");
            var txtWorkoutExercises = FindViewById<TextView>(Resource.Id.textView_workoutExercises);

            // change text according to which workout was chosen

            if (workoutName == "sevenminuteworkout")
            {
                txtWorkoutExercises.Text = String.Format(
                    "\n\nJumping Jack\n\n" +
                    "Stand upright with your legs together, arms at your sides. Bend your knees slightly, and jump into the air. As you jump, spread your legs to be about shoulder-width apart. Stretch your arms out and over your head. Jump back to starting position. Repeat.\n\n" +
                    "Wall sit\n\n" +
                    "Make sure your back is flat against the wall. Place your feet firmly on the ground, shoulder-width apart, and then about 60cm out from the wall. Slide your back down the wall while keeping your core engaged and bending your legs until they’re in a 90-degree angle—or right angle.  Your knees should be directly above your ankles, not jutting out in front of them. HOLD your position, while contracting your ab muscles. When you’re ready to wrap it up, take a few seconds to slowly come back to a standing position while leaning against the wall.\n\n" +
                    "Push-up\n\n" +
                    "On the ground, set your hands at a distance that is slightly wider than shoulder-width apart. The middle finger should point straight forward. Clench your butt, and then tighten your abs as if you’re bracing to get punched.Your shoulders should be near to your body. Now you a ready to perform a push up.\n\n" +
                    "Abdominal crunch\n\n" +
                    "Lie down on your back. Plant your feet on the floor, hip-width apart. Bend your knees and place your arms across your chest. Contract your abs and inhale. Exhale and lift your upper body, keeping your head and neck relaxed. Inhale and return to the starting position.\n\n" +
                    "Step-up\n\n" +
                    "Maintain a neutral head and neck position and a tall posture. Your shoulders should be slightly ahead of your hips and your arms should be long with a slight bend in your elbows.Now push your foot onto the box and step up.As you begin to stand up, keep your chest high, squeeze your glute, allow your knee to straighten and your hips to travel forward.\n\n" +
                    "Squat\n\n" +
                    "Stand straight with feet hip-width apart. Tighten your stomach muscles. Lower down, as if sitting in an invisible chair. Straighten your legs to lift back up. Repeat the movement.\n\n" +
                    "Triceps dip\n\n" +
                    "Press into your palms to lift your body and slide forward just far enough that your behind clears the edge of the chair. Lower yourself until your elbows are bent between 45 and 90 degrees.Control the movement throughout the range of motion. Push yourself back up slowly until your arms are almost straight and repeat.\n\n" +
                    "Plank\n\n" +
                    "Begin in the plank position, face down with your forearms and toes on the floor. Your elbows are directly under your shoulders and your forearms are facing forward. Your head is relaxed and you should be looking at the floor. Engage your abdominal muscles, drawing your navel toward your spine.Keep your torso straight and rigid and your body in a straight line from your ears to your toes with no sagging or bending.This is the neutral spine position.Ensure your shoulders are down, not creeping up toward your ears. Your heels should be over the balls of your feet. Hold this position for 10 seconds.Release to floor.\n\n" +
                    "High knees\n\n" +
                    "Stand straight with your feet shoulder-width apart. Face forward and open your chest. Bring your knees up to waist level and then slowly land on the balls of your feet. Repeat until the set is complete.\n\n" +
                    "Lunge\n\n" +
                    "Stand in a split stance with the right foot roughly 2 to 3 feet in front of the left foot. Your torso is straight, the shoulders are back and down, your core is engaged, and your hands are resting on your hips. Bend the knees and lower your body until the back knee is a few inches from the floor.At the bottom of the movement, the front thigh is parallel to the ground, the back knee points toward the floor, and your weight is evenly distributed between both legs. Push back up to the starting position, keeping your weight on the heel of the front foot.\n\n" +
                    "Side plank\n\n" +
                    "Push your right forearm into the ground to lift your torso and straighten your legs. Keep your core tight and ensure your hips are lifted. Your body should be close to a straight line. Try to hold this position for 20 or more seconds before switching sides.\n\n");
            }

            var btnBack = FindViewById<Button>(Resource.Id.button_backFromExercises);

            btnBack.Click += (s, e) =>
            {
                Finish();
            };
        }
    }
}