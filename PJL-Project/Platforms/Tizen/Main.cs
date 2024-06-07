using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using System;

namespace PJL_Project
{
    internal class Program : MauiApplication
    {

/* Unmerged change from project 'PJL-Project (net8.0-android)'
Before:
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
After:
        protected override MauiApp CreateMauiApp() => MauiProgramHelpers.CreateMauiApp();
*/
        protected override MauiApp CreateMauiApp() => global::MauiProgramHelpers.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
