﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace eduNICA
{
    [Activity(Label = "Activity_Admin_Docente")]
    public class Activity_Admin_Docente : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Admin_Docente);
            // Create your application here
        }
    }
}