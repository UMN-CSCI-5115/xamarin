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
    [Activity(Label = "ActivityMainPage")]
    public class ActivityMainPage : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.MainPage);


            // Create your application here

            Button findEvents = FindViewById<Button>(Resource.Id.findEvents);
            findEvents.Click += (IntentSender, e) =>
            {
                StartActivity(typeof(ActivityEventSearch));
            };


            Button findGroups = FindViewById<Button>(Resource.Id.findGroups);
            findGroups.Click += (IntentSender, e) =>
            {
                StartActivity(typeof(Login));
            };

            Button subscriptions = FindViewById<Button>(Resource.Id.subscriptions);
            subscriptions.Click += (IntentSender, e) =>
            {
                StartActivity(typeof(Login));
            };

            Button manageGroups = FindViewById<Button>(Resource.Id.manageGroups);
            manageGroups.Click += (IntentSender, e) =>
            {
                StartActivity(typeof(Login));
            };

            Button settings = FindViewById<Button>(Resource.Id.settings);
            settings.Click += (IntentSender, e) =>
            {
                StartActivity(typeof(Login));
            };
            
        }
    }
}