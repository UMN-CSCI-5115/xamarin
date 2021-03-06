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

namespace AndroidApplication1
{
    [Activity(Label = "ActivityEventSearch")]
    public class ActivityEventSearch : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here

            SetContentView(Resource.Layout.EventSearch);


            // Create your application here
            Button searchEvents = FindViewById<Button>(Resource.Id.eventSearchButton);
            searchEvents.Click += (IntentSender, e) =>
            {
                StartActivity(typeof(ActivityEventSearchResults));
            };

            Spinner eventCategories = FindViewById<Spinner>(Resource.Id.eventCategories);

            eventCategories.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);

            var adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.planets_array, Android.Resource.Layout.SimpleSpinnerItem);

            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            eventCategories.Adapter = adapter;



        }

        private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;

            string toast = string.Format("The planet is {0}", spinner.GetItemAtPosition(e.Position));
            Toast.MakeText(this, toast, ToastLength.Long).Show();
        }
    }
}