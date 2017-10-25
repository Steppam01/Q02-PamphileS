using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace sc00_recipeViewer
{
    [Activity(Label = "sc00_recipeViewer", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button btnRecipeDetails = (Button)FindViewById<Button>(Resource.Id.btnRecipeDetails);

            btnRecipeDetails.Click += delegate
            {
                var recipeDisplayActivity = new Intent(this, typeof(RecipeDetailsActivity));
                Spinner dishes = (Spinner)FindViewById<Spinner>(Resource.Id.dishSelect);

                //Passing recipe data
                recipeDisplayActivity.PutExtra("dish", dishes.SelectedItem.ToString());

                StartActivity(recipeDisplayActivity);
            };
        }
    }
}

