using Foundation;

namespace PJL_Project
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {

/* Unmerged change from project 'PJL-Project (net8.0-android)'
Before:
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
After:
        protected override MauiApp CreateMauiApp() => MauiProgramHelpers.CreateMauiApp();
*/
        protected override MauiApp CreateMauiApp() => global::MauiProgramHelpers.CreateMauiApp();
    }
}
