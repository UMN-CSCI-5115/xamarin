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
    [Activity(Label = "ActivityGroupSearch")]
    public class ActivityGroupSearch : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);


                SetContentView(Resource.Layout.GroupSearch);


            // Create your application here
            Button searchGroups = FindViewById<Button>(Resource.Id.groupSearchButton);
            searchGroups.Click += (IntentSender, e) =>
            {
                StartActivity(typeof(ActivityGroupSearchResults));
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

            string toast = string.Format("The category is {0}", spinner.GetItemAtPosition(e.Position));
            Toast.MakeText(this, toast, ToastLength.Long).Show();
        }
        
        
        
        }
    }
