using PJL_Project.Views;

namespace PJL_Project
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("InfoPage", typeof(InfoPage));
            Routing.RegisterRoute("LoginPage", typeof(LoginPage));
            Routing.RegisterRoute("SingUpPage", typeof(SingUpPage));
            Routing.RegisterRoute("ConfigPage", typeof(ConfigPage));
            Routing.RegisterRoute("SeeAllPage", typeof(SeeAllPage));
            Routing.RegisterRoute("NoItemsPage", typeof(NoItemsPage));
        }
    }
}
