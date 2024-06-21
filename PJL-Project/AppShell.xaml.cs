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
            Routing.RegisterRoute("SignUpPage", typeof(SignUpPage));
            Routing.RegisterRoute("NotFoundPage", typeof(NotFoundPage));
            Routing.RegisterRoute("SeeAllPage", typeof(SeeAllPage));
        }
    }
}
