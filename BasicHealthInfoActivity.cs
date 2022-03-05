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
    [Activity(Label = "BasicHealthInfoActivity", Theme = "@style/AppTheme", NoHistory = true)]
    public class BasicHealthInfoActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_basicHealthInfo);

            // variables

            var txtHealthInfoParagraph = FindViewById<TextView>(Resource.Id.textview_healthInfoParagraph);
            var btnBackFromBasicHealthInfo = FindViewById<Button>(Resource.Id.button_backFromBasicHealthInfo);

            txtHealthInfoParagraph.Text = String.Format("\n\nProtein\n\n" +
                "Protein is one of the main nutrients that every person needs to maintain a healthy body. It helps to repair any internal or external damage, supports the immune system and contributes to an overall feeling of wellbeing. At a cellular level, proteins are used for just about everything, from transporting messages, carry out the instructions of DANN and defending, preserving and repairing essential life functions.\n\n" +
                "Protein for exercise\n\n" +
                "Anyone undertaking any kind of exercise routine is definitely going to need more protein than someone who doesn’t. This is because when you exercise, you are effectively tearing and breaking muscle fibres apart, which then need to be repaired by the body, which requires protein. If you are exercising but find yourself with low energy or feel that you are not building any muscle, it may be down to not having enough protein in your diet.Make an effort to eat more protein through your meals and supplement your intake with protein - rich snacks like chicken or Fish. You should start to feel better and get better results for all of your hard work.\n\n" +
                "Carbs\n\n" +
                "Out of all the energy sources for the human body, researchers have found that carbohydrates are the main source of energy in the human diet. This means that carbs aren’t just for athletes. Carbs are a great source of energy for anyone’s daily activities, including exercise. You can think of carbohydrates as a source of fuel for the body, otherwise known as calories.As we’ve previously learned, there are two types of carbohydrates: simple carbs and complex carbs.Simple carbs are a quick, sporadic source of energy, while complex carbs are a good source of steady energy. While Candy is a simple carb because of the sugar, sweet potatoes are for example a source of carb.\n\n" +
                "Fat\n\n" +
                "Most people confuse dietary fat with cosmetic fat.  The fat you eat and the fat on your body are two completely different things. It’s important that our bodies have a balance of omega 3, 6 and 9 fatty acids.Omega - 3 and omega - 6 fatty acids are both considered polyunsaturated fatty acids, and we can only obtain them through our diets.While omega - 3 fatty acids have anti - inflammatory properties, omega - 6 fatty acids are pro - inflammatory.While it’s necessary for us to have levels of omega - 6 in our bodies, a diet that’s too high in omega - 6 will lead to harmful levels of inflammation.Omega - 9 fatty acids, on the other hand, are considered monounsaturated fatty acids that can be produced naturally in our bodies. However, a diet high in omega - 9 can also decrease inflammation levels. Overall, healthy fats are necessary for our bodies to fight(and sometimes produce) inflammation.Some ways you can get your recommended amounts of plant - based, healthy fats are by eating coconut oil, MCT oil, avocados, chia seeds, walnuts, and flax seeds.\n\n" +
                "Creatine\n\n" +
                "Creatine is a substance that is found naturally in muscle cells. It helps your muscles produce energy during heavy lifting or high-intensity exercise. Taking creatine as a supplement is very popular among athletes and bodybuilders in order to gain muscle, enhance strength and improve exercise performance. Chemically speaking, it shares many similarities with amino acids.Your body can produce it from the amino acids glycine and arginine. Several factors affect your body’s creatine stores, including meat intake, exercise, amount of muscle mass and levels of hormones like testosterone. About 95 % of your body’s creatine is stored in muscles in the form of phosphocreatine.The other 5 % is found in your brain, kidneys and liver. When you supplement, you increase your stores of phosphocreatine.This is a form of stored energy in the cells, as it helps your body produce more of a high - energy molecule called ATP. ATP is often called the body’s energy currency.When you have more ATP, your body can perform better during exercise. Creatine also alters several cellular processes that lead to increased muscle mass, strength and recovery.\n\n" +
                "Cut\n\n" +
                "A cutting diet is usually used by bodybuilders and fitness enthusiasts to cut body fat while maintaining muscle mass. The key distinctions with other weight loss diets are that a cutting diet is catered to each individual, tends to be higher in protein and carbs, and should be accompanied by weightlifting. Lifting weights regularly is important because it promotes muscle growth, helping combat muscle loss when you start cutting calories. A cutting diet lasts 2–4 months, depending on how lean you are before dieting, and is normally timed around bodybuilding competitions, athletic events, or occasions like holidays.\n\n" +
                "Bulk\n\n" +
                "Bulking is the muscle-gaining phase. You’re meant to intentionally consume more calories than your body needs for a set period — often 4–6 months. These extra calories provide your body with the necessary fuel to boost muscle size and strength while weight training. To varying degrees, body fat tends to accumulate during bulking due to excess calorie intake. Cutting, or the fat loss phase, refers to a gradual decrease in calorie intake and increase in aerobic training to reduce excess body fat from the bulking phase, allowing for improved muscle definition.\n\n" +
                "Mainteance\n\n" +
                "A maintenance phase is one phase or “macrocycle” (a large portion of a training year) that you should use during the start and duration of each athletic or competitive season. This phase is used to preserve the strength, power, and muscle mass that was built in the many months prior to the season.\n\n");

            // buttons

            btnBackFromBasicHealthInfo.Click += (s, e) =>
            {
                Finish();
            };
        }
    }
}