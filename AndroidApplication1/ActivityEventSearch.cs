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
            EditText searchEventsText = FindViewById<EditText>(Resource.Id.eventSearch);
            searchEventsText.Click += (IntentSender, e) =>
            {
                searchEventsText

            };
            Button searchEvents = FindViewById<Button>(Resource.Id.eventSearch);
            searchEvents.Click += (IntentSender, e) =>
            {
                StartActivity(typeof(Login));
            };




        }
    }
}