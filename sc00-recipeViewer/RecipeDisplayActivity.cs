using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics.Drawables;

namespace sc00_recipeViewer
{
    [Activity(Label = "RecipeDisplayActivity")]
    public class RecipeDisplayActivity : Activity
    {
        private RecipeChooser recipeChooser = new RecipeChooser();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Setting layout to recipe details
            SetContentView(Resource.Layout.RecipeDetails);

            //Retrieving selected dish from spinnner
            string dish = Intent.GetStringExtra("dish");

            TextView instructions = (TextView)FindViewById<TextView>(Resource.Id.instructions);
            ImageView image = (ImageView)FindViewById<ImageView>(Resource.Id.dishPicture);

            //Displaying instructions
            instructions.Text = recipeChooser.getInstructions(dish);

            //Displaying image
            if(dish == "Pancakes")
            {
                image.SetImageResource(Resource.Drawable.Pancakes);
            } else if(dish == "Chicken Fingers")
            {
                image.SetImageResource(Resource.Drawable.Chicken);
            } else
            {
                image.SetImageResource(Resource.Drawable.Cake);
            }

            Button btnText = (Button)FindViewById<Button>(Resource.Id.btnSms);
            Button btnCall = (Button)FindViewById<Button>(Resource.Id.btnCall);
            Button btnEmail = (Button)FindViewById<Button>(Resource.Id.btnEmail);

            //SMS
            btnText.Click += delegate
            {
                var uri = Android.Net.Uri.Parse("smsto:5555555555");
                Intent intent = new Intent(Intent.ActionSendto, uri);
                intent.PutExtra("sms_body", "I vote for " + dish);
                StartActivity(intent);
            };

            //Call method
            btnCall.Click += delegate
            {
                var uri = Android.Net.Uri.Parse("tel:5555555555");
                Intent myIntent = new Intent(Intent.ActionDial, uri);
                StartActivity(myIntent);
            };

            //Email
            btnEmail.Click += delegate
            {
                var uri = Android.Net.Uri.Parse("mailto:bestrecipes@gmail.com");
                Intent myIntent = new Intent(Intent.ActionSendto, uri);
                StartActivity(myIntent);
            };

        }
    }
}