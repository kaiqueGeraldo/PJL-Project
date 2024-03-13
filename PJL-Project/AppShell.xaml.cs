using PJL_Project.Views;

namespace PJL_Project
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("LoginPage", typeof(LoginPage));
            Routing.RegisterRoute("SingUpPage", typeof(SingUpPage));
            Routing.RegisterRoute("HomePage", typeof(HomePage));
            Routing.RegisterRoute("CategoryPage", typeof(CategoryPage));
            Routing.RegisterRoute("BagPage", typeof(BagPage));
            Routing.RegisterRoute("BookmarkPage", typeof(BookmarkPage));
            Routing.RegisterRoute("PerfilPage", typeof(PerfilPage));
            Routing.RegisterRoute("ConfigPage", typeof(ConfigPage));
            Routing.RegisterRoute("SeeAllPage", typeof(SeeAllPage));
            Routing.RegisterRoute("NoItemsPage", typeof(NoItemsPage));
        }
    }
}
