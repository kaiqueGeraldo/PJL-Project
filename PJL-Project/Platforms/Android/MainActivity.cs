﻿using Android.App;
using Android.Content.PM;
using Android.OS;

namespace PJL_Project
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Define a cor da barra de status
            Window?.SetStatusBarColor(Android.Graphics.Color.ParseColor("#131316"));
        }
    }
}
