using Android.App;
using Android.Runtime;

namespace PJL_Project
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }


/* Unmerged change from project 'PJL-Project (net8.0-android)'
Before:
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
After:
        protected override MauiApp CreateMauiApp() => MauiProgramHelpers.CreateMauiApp();
*/
        protected override MauiApp CreateMauiApp() => global::MauiProgramHelpers.CreateMauiApp();
    }
}
