using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace PJL_Project.WinUI
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : MauiWinUIApplication
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
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
