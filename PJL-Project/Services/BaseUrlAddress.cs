namespace PJL_Project.Services
{
    public static class BaseUrlAddress
    {
        private const string Url = "http://10.0.2.2:5214";

        public static string UrlRotaApi => $"{Url}/api/";
    }
}
