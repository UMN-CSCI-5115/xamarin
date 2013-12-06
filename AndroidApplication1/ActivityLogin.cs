using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace AndroidApplication1
{
    [Activity(Label = "ActivityLogin", MainLauncher = true, Icon = "@drawable/icon")]
    public class Login : Activity
    {
        //int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Login);

            // Get our button from the layout resource,
            // and attach an event to it
            Button loginButton = FindViewById<Button>(Resource.Id.loginbutton);
            loginButton.Click +=  (sender, e) => {
    StartActivity(typeof(ActivityMainPage));
};//delegate { SetContentView(Resource.Layout.MainPage); };


 //           button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

