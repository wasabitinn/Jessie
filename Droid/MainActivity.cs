using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
namespace Jessie.Droid
{
    [Activity(Label = "MasterActivity", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main); //把controler 與View link

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += delegate
            {
                var intent = new Intent(this, typeof(Mainflow.MasterActivity));
                StartActivity(intent);
            };
        }
    }
}

